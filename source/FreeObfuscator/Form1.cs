using FreeObfuscator.Algorithms;
using System;
using System.Windows.Forms;

namespace FreeObfuscator
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        // OBFUSCATE .NET MODULE
        private void FileSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OpenFile = new OpenFileDialog())
            {
                OpenFile.Title = "Open .exe File!";
                OpenFile.Filter = "Exe Files (*.exe)|*.exe";

                if (OpenFile.ShowDialog() == DialogResult.OK) { ObfusFilePath.Text = OpenFile.FileName; }
            }
        }

        private void ObfuscateBtn_Click(object sender, EventArgs e)
        {
            string filePath = ObfusFilePath.Text;

/*            bool control_flow = ControlFlowCheck.Checked;*/
            bool proxy_string = ProxyCheck.Checked;
            bool junk_methods = JunkCheck.Checked;
            bool renameFuncs = RenameFuncs.Checked;


            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("File path cannot be empty.", "~ Information ~", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!proxy_string && !junk_methods && !renameFuncs)
            {
                MessageBox.Show("You need to select at least one option!", "~ Information ~", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "~ Save Obfuscated File ~";
                save.Filter = "Exe Files (*.exe)|*.exe";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string result = NetObfuscate.Obfuscate(filePath, save.FileName, proxy_string, junk_methods, renameFuncs);

                    if (result == "Obfuscated") { MessageBox.Show("File Obfuscated successfully!", "~Information ~", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                    else { MessageBox.Show("Internal building-error", "~ Information", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }



        // OBFUSCATE BAT MODULES
        private void BatObfuscateBtn_Click(object sender, EventArgs e)
        {
            string BatchPath = BatchFile_Path.Text;

            if (string.IsNullOrEmpty(BatchPath)) { MessageBox.Show("Forms cannot be empty!", "~ information ~", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "Save Obfuscation file";
                save.Filter = "BAT Files (*.bat)|*.bat";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    BatAlgo.ObfuscateBatch(BatchPath, save.FileName);
                    MessageBox.Show("~Information~", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SelectBatchBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OpenBatch = new OpenFileDialog())
            {
                OpenBatch.Title = "Open .BAT File!";
                OpenBatch.Filter = "BAT Files (*.bat)|*.bat";

                if (OpenBatch.ShowDialog() == DialogResult.OK) { BatchFile_Path.Text = OpenBatch.FileName; }
            }
        }

        // END
    }
}
