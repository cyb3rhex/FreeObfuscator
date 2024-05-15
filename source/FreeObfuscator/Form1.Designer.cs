namespace FreeObfuscator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.SelectBatchBtn = new MetroFramework.Controls.MetroButton();
            this.BatObfuscateBtn = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.BatchFile_Path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.RenameFuncs = new MetroFramework.Controls.MetroCheckBox();
            this.ProxyCheck = new MetroFramework.Controls.MetroCheckBox();
            this.JunkCheck = new MetroFramework.Controls.MetroCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FileSelect = new MetroFramework.Controls.MetroButton();
            this.ObfusFilePath = new System.Windows.Forms.TextBox();
            this.ObfuscateBtn = new MetroFramework.Controls.MetroButton();
            this.ObfusPanel = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.ObfusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.SelectBatchBtn);
            this.metroTabPage2.Controls.Add(this.BatObfuscateBtn);
            this.metroTabPage2.Controls.Add(this.label3);
            this.metroTabPage2.Controls.Add(this.BatchFile_Path);
            this.metroTabPage2.Controls.Add(this.label4);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(436, 189);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Bat Obfuscator";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbar = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // SelectBatchBtn
            // 
            this.SelectBatchBtn.Location = new System.Drawing.Point(369, 65);
            this.SelectBatchBtn.Name = "SelectBatchBtn";
            this.SelectBatchBtn.Size = new System.Drawing.Size(64, 30);
            this.SelectBatchBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.SelectBatchBtn.TabIndex = 5;
            this.SelectBatchBtn.Text = "Select";
            this.SelectBatchBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SelectBatchBtn.Click += new System.EventHandler(this.SelectBatchBtn_Click);
            // 
            // BatObfuscateBtn
            // 
            this.BatObfuscateBtn.Location = new System.Drawing.Point(54, 108);
            this.BatObfuscateBtn.Name = "BatObfuscateBtn";
            this.BatObfuscateBtn.Size = new System.Drawing.Size(295, 50);
            this.BatObfuscateBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.BatObfuscateBtn.TabIndex = 7;
            this.BatObfuscateBtn.Text = "Obfusate";
            this.BatObfuscateBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BatObfuscateBtn.Click += new System.EventHandler(this.BatObfuscateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightGreen;
            this.label3.Location = new System.Drawing.Point(49, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = ".BAT";
            // 
            // BatchFile_Path
            // 
            this.BatchFile_Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BatchFile_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BatchFile_Path.Font = new System.Drawing.Font("Consolas", 9F);
            this.BatchFile_Path.ForeColor = System.Drawing.Color.LimeGreen;
            this.BatchFile_Path.Location = new System.Drawing.Point(6, 65);
            this.BatchFile_Path.Multiline = true;
            this.BatchFile_Path.Name = "BatchFile_Path";
            this.BatchFile_Path.Size = new System.Drawing.Size(358, 28);
            this.BatchFile_Path.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "FILE [          ]";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.RenameFuncs);
            this.metroTabPage1.Controls.Add(this.ProxyCheck);
            this.metroTabPage1.Controls.Add(this.JunkCheck);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.FileSelect);
            this.metroTabPage1.Controls.Add(this.ObfusFilePath);
            this.metroTabPage1.Controls.Add(this.ObfuscateBtn);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(436, 189);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Obfuscate .NET";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // RenameFuncs
            // 
            this.RenameFuncs.AutoSize = true;
            this.RenameFuncs.ForeColor = System.Drawing.Color.White;
            this.RenameFuncs.Location = new System.Drawing.Point(145, 85);
            this.RenameFuncs.Name = "RenameFuncs";
            this.RenameFuncs.Size = new System.Drawing.Size(102, 15);
            this.RenameFuncs.Style = MetroFramework.MetroColorStyle.Green;
            this.RenameFuncs.TabIndex = 10;
            this.RenameFuncs.Text = "Rename-Funcs";
            this.RenameFuncs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RenameFuncs.UseVisualStyleBackColor = true;
            // 
            // ProxyCheck
            // 
            this.ProxyCheck.AutoSize = true;
            this.ProxyCheck.ForeColor = System.Drawing.Color.White;
            this.ProxyCheck.Location = new System.Drawing.Point(20, 85);
            this.ProxyCheck.Name = "ProxyCheck";
            this.ProxyCheck.Size = new System.Drawing.Size(89, 15);
            this.ProxyCheck.Style = MetroFramework.MetroColorStyle.Green;
            this.ProxyCheck.TabIndex = 9;
            this.ProxyCheck.Text = "Proxy-String";
            this.ProxyCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProxyCheck.UseVisualStyleBackColor = true;
            // 
            // JunkCheck
            // 
            this.JunkCheck.AutoSize = true;
            this.JunkCheck.ForeColor = System.Drawing.Color.White;
            this.JunkCheck.Location = new System.Drawing.Point(264, 85);
            this.JunkCheck.Name = "JunkCheck";
            this.JunkCheck.Size = new System.Drawing.Size(99, 15);
            this.JunkCheck.Style = MetroFramework.MetroColorStyle.Green;
            this.JunkCheck.TabIndex = 8;
            this.JunkCheck.Text = "Junk-Methods";
            this.JunkCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.JunkCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(46, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = ".NET/DLL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "FILE [                    ]";
            // 
            // FileSelect
            // 
            this.FileSelect.Location = new System.Drawing.Point(369, 50);
            this.FileSelect.Name = "FileSelect";
            this.FileSelect.Size = new System.Drawing.Size(64, 30);
            this.FileSelect.Style = MetroFramework.MetroColorStyle.Purple;
            this.FileSelect.TabIndex = 4;
            this.FileSelect.Text = "Select";
            this.FileSelect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FileSelect.Click += new System.EventHandler(this.FileSelect_Click);
            // 
            // ObfusFilePath
            // 
            this.ObfusFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ObfusFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObfusFilePath.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ObfusFilePath.ForeColor = System.Drawing.Color.LimeGreen;
            this.ObfusFilePath.Location = new System.Drawing.Point(4, 50);
            this.ObfusFilePath.Multiline = true;
            this.ObfusFilePath.Name = "ObfusFilePath";
            this.ObfusFilePath.Size = new System.Drawing.Size(359, 29);
            this.ObfusFilePath.TabIndex = 3;
            // 
            // ObfuscateBtn
            // 
            this.ObfuscateBtn.Location = new System.Drawing.Point(82, 121);
            this.ObfuscateBtn.Name = "ObfuscateBtn";
            this.ObfuscateBtn.Size = new System.Drawing.Size(250, 45);
            this.ObfuscateBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.ObfuscateBtn.TabIndex = 2;
            this.ObfuscateBtn.Text = "Obfuscate";
            this.ObfuscateBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ObfuscateBtn.Click += new System.EventHandler(this.ObfuscateBtn_Click);
            // 
            // ObfusPanel
            // 
            this.ObfusPanel.Controls.Add(this.metroTabPage1);
            this.ObfusPanel.Controls.Add(this.metroTabPage2);
            this.ObfusPanel.Location = new System.Drawing.Point(-1, 63);
            this.ObfusPanel.Name = "ObfusPanel";
            this.ObfusPanel.SelectedIndex = 0;
            this.ObfusPanel.Size = new System.Drawing.Size(444, 228);
            this.ObfusPanel.Style = MetroFramework.MetroColorStyle.Green;
            this.ObfusPanel.TabIndex = 0;
            this.ObfusPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 300);
            this.Controls.Add(this.ObfusPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "FreeObfuscator by k3rnel-dev";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ObfusPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabControl ObfusPanel;
        private MetroFramework.Controls.MetroButton ObfuscateBtn;
        private MetroFramework.Controls.MetroButton FileSelect;
        private System.Windows.Forms.TextBox ObfusFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton SelectBatchBtn;
        private MetroFramework.Controls.MetroButton BatObfuscateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BatchFile_Path;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroCheckBox ProxyCheck;
        private MetroFramework.Controls.MetroCheckBox JunkCheck;
        private MetroFramework.Controls.MetroCheckBox RenameFuncs;
    }
}

