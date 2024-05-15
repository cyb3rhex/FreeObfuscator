using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace FreeObfuscator.Algorithms
{
    internal class NetObfuscate
    {
        public static string Obfuscate(string filePath, string outputFilePath, bool proxyString, bool junk_method, bool renamefuncs)
        {
            if (!File.Exists(filePath))
            {
                return "~ File does not exist!";
            }

            ModuleContext modCtx = ModuleDef.CreateModuleContext();
            var module = ModuleDefMD.Load(filePath, modCtx);


            if (renamefuncs) { RenameProtector.Execute(module); }

            if (junk_method) { JunkMethods.Execute(module); }

/*            if (controlflow) { ControlFlow.Execute(module); }*/ // Maybe outdate added :D

            if (proxyString) { ProxyString.Execute(module); }

            module.Write(outputFilePath, new dnlib.DotNet.Writer.ModuleWriterOptions(module) { Logger = DummyLogger.NoThrowInstance });

            return "Obfuscated";
        }

        private class RenameProtector
        {
            public static int count_xxx = 0;

            public static void Execute(ModuleDef module)
            {
                module.Name = "OBFUSCATED";

                foreach (TypeDef type in module.Types)
                {
                    if (type.IsGlobalModuleType || type.IsRuntimeSpecialName || type.IsSpecialName || type.IsWindowsRuntime || type.IsInterface)
                        continue;

                    count_xxx++;

                    type.Name = RandomString(40);
                    type.Namespace = "";

                    foreach (PropertyDef property in type.Properties)
                    {
                        count_xxx++;
                        property.Name = RandomString(40);
                    }

                    foreach (FieldDef fields in type.Fields)
                    {
                        count_xxx++;
                        fields.Name = RandomString(40);
                    }

                    foreach (EventDef eventdef in type.Events)
                    {
                        count_xxx++;
                        eventdef.Name = RandomString(40);
                    }

                    foreach (MethodDef method in type.Methods)
                    {
                        if (method.IsConstructor) continue;
                        count_xxx++;
                        method.Name = RandomString(40);
                    }
                }
            }

            private static Random random = new Random();

            private static string RandomString(int length)
            {
                const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }
        }

        private class JunkMethods
        {
            public static void Execute(ModuleDef module)
            {
                foreach (TypeDef type in module.Types)
                {
                    for (int i = 0; i < 100; i++) // Create 100 junk methods for each type
                    {
                        MethodDef junkMethod = new MethodDefUser(RandomString(10), MethodSig.CreateStatic(module.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static);
                        junkMethod.Body = new CilBody();
                        junkMethod.Body.Instructions.Add(OpCodes.Ret.ToInstruction());

                        type.Methods.Add(junkMethod);
                    }
                }
                
                for (int i = 0; i < 50; i++) // Create 50 junk classes
                {
                    TypeDef junkType = new TypeDefUser(RandomString(10), module.CorLibTypes.Object.TypeDefOrRef);
                    module.Types.Add(junkType);
                    
                    for (int j = 0; j < 10; j++) // For each junk class, create 10 junk methods
                    {
                        MethodDef junkMethod = new MethodDefUser(RandomString(10), MethodSig.CreateStatic(module.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static);
                        junkMethod.Body = new CilBody();
                        junkMethod.Body.Instructions.Add(OpCodes.Ret.ToInstruction());

                        junkType.Methods.Add(junkMethod);
                    }
                }
            }

            private static Random random = new Random();

            private static string RandomString(int length)
            {
                const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }
        }

        private class ProxyString
        {
            public static void Execute(ModuleDef module)
            {
                foreach (TypeDef type in module.Types)
                {
                    foreach (MethodDef method in type.Methods)
                    {
                        if (!method.HasBody) continue;

                        for (int i = 0; i < method.Body.Instructions.Count; i++)
                        {
                            if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr)
                            {
                                //Original String
                                string oldString = (string)method.Body.Instructions[i].Operand;

                                //Encrypted String by Base64
                                string newString = Convert.ToBase64String(Encoding.UTF8.GetBytes(oldString));

                                //Change the OpCode for the Original Instruction
                                method.Body.Instructions[i].OpCode = OpCodes.Nop;

                                //Add Instructions
                                method.Body.Instructions.Insert(i + 1, Instruction.Create(OpCodes.Call, module.Import(typeof(System.Text.Encoding).GetMethod("get_UTF8"))));
                                method.Body.Instructions.Insert(i + 2, Instruction.Create(OpCodes.Ldstr, newString));
                                method.Body.Instructions.Insert(i + 3, Instruction.Create(OpCodes.Call, module.Import(typeof(System.Convert).GetMethod("FromBase64String", new Type[] { typeof(string) }))));
                                method.Body.Instructions.Insert(i + 4, Instruction.Create(OpCodes.Callvirt, module.Import(typeof(System.Text.Encoding).GetMethod("GetString", new Type[] { typeof(byte[]) }))));

                                //Skip the Instructions that we have just added
                                i += 4;
                            }
                        }
                    }
                }
            }
        }

    }
}
