using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FreeObfuscator.Algorithms
{
    internal class BatAlgo
    {
        public static void ObfuscateBatch(string batchPath, string savePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(batchPath))
                using (StreamWriter writer = new StreamWriter(savePath))
                {
                    writer.WriteLine("::obfuscated by FreeObfuscator https://github.com/k3rnel-dev/FreeObfuscator");

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(":"))
                        {
                            writer.WriteLine(line);
                            continue;
                        }

                        StringBuilder obfuscatedLine = new StringBuilder();
                        bool inPercent = false;
                        foreach (char ch in line)
                        {
                            if (!inPercent)
                            {
                                if (ch == '\n')
                                {
                                    writer.WriteLine();
                                }
                                else if (ch == '%')
                                {
                                    obfuscatedLine.Append(ch);
                                    inPercent = true;
                                }
                                else
                                {
                                    int randomLength = new Random().Next(1, 11);
                                    string randomString = RandomString(randomLength);
                                    obfuscatedLine.Append($"{ch}%{randomString}%");
                                }
                            }
                            else
                            {
                                if (ch == '%')
                                {
                                    obfuscatedLine.Append(ch);
                                    inPercent = false;
                                }
                                else if (ch == '\n')
                                {
                                    obfuscatedLine.Append("\n");
                                    inPercent = false;
                                }
                                else
                                {
                                    obfuscatedLine.Append(ch);
                                }
                            }
                        }

                        writer.WriteLine(obfuscatedLine);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("~ Internal Error ~", $"Internal Building Error: {ex}"); }
        }

        private static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789☀☁☂☃☼☽★☆☾℃℉☀ -‘๑’-☁ϟ☂︸☃⁂☼☽✩✪✫✬✭✮✯✰牡マキグナルファ系路克瑞大阪市立学鎰命科ャマ能力ϒ人は妻スティ要望通り玉宏¥サ丹谷Ѫ灯影伝鶐ԱաԲբԳգԴդԵեԶզԷէԸըԹթԺժԻիԼլԽխԾծԿկՀհՁձՂղՃճՄմՅյՆնՇշՈոՉչՊպՋջՌռՍսՎվՏտՐրՑցՒւՓփՔքՕօՖֆლ(´ڡ`ლ)ლ(ಠ益ಠლ)ლ(╹◡╹ლ)ლ(◉◞౪◟◉‵ლヾ(⌐■_■)ノ♪(◕‿◕)| (• ◡•)|(❍ᴥ❍ʋ)⒑⒒⒓⒔⒕⒖⒗⒘⒙⒚⒛";
            char[] charArray = chars.ToCharArray();
            Random rng = new Random();
            int n = charArray.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                char value = charArray[k];
                charArray[k] = charArray[n];
                charArray[n] = value;
            }
            StringBuilder randomString = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                randomString.Append(charArray[random.Next(charArray.Length)]);
            }
            return randomString.ToString();
        }

    }
}
