namespace MVC4ASPNETWebApiClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttStandardTest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCLS = new System.Windows.Forms.Button();
            this.bttGeneraChiavi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChiavePrivata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChiavePubblica = new System.Windows.Forms.TextBox();
            this.txtHEXChiave = new System.Windows.Forms.TextBox();
            this.bttHackTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkTokenVariabile = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTokenVariabile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTokenFisso = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttStandardTest
            // 
            this.bttStandardTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttStandardTest.Location = new System.Drawing.Point(351, 169);
            this.bttStandardTest.Name = "bttStandardTest";
            this.bttStandardTest.Size = new System.Drawing.Size(75, 23);
            this.bttStandardTest.TabIndex = 6;
            this.bttStandardTest.Text = "&Test";
            this.bttStandardTest.UseVisualStyleBackColor = true;
            this.bttStandardTest.Click += new System.EventHandler(this.bttStandardTest_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(8, 295);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(440, 79);
            this.textBox1.TabIndex = 2;
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(48, 14);
            this.txtURL.MaxLength = 48;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(393, 20);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "http://localhost.fiddler:50174/api/values/125";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL:";
            // 
            // btnCLS
            // 
            this.btnCLS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCLS.Location = new System.Drawing.Point(8, 380);
            this.btnCLS.Name = "btnCLS";
            this.btnCLS.Size = new System.Drawing.Size(75, 23);
            this.btnCLS.TabIndex = 3;
            this.btnCLS.Text = "&Pulisci";
            this.btnCLS.UseVisualStyleBackColor = true;
            this.btnCLS.Click += new System.EventHandler(this.bttPulisci_Click);
            // 
            // bttGeneraChiavi
            // 
            this.bttGeneraChiavi.Location = new System.Drawing.Point(6, 18);
            this.bttGeneraChiavi.Name = "bttGeneraChiavi";
            this.bttGeneraChiavi.Size = new System.Drawing.Size(103, 23);
            this.bttGeneraChiavi.TabIndex = 0;
            this.bttGeneraChiavi.Text = "&Genera chiavi";
            this.bttGeneraChiavi.UseVisualStyleBackColor = true;
            this.bttGeneraChiavi.Click += new System.EventHandler(this.bttGeneraChiavi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chiave privata:";
            // 
            // txtChiavePrivata
            // 
            this.txtChiavePrivata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChiavePrivata.Location = new System.Drawing.Point(108, 47);
            this.txtChiavePrivata.Name = "txtChiavePrivata";
            this.txtChiavePrivata.Size = new System.Drawing.Size(318, 20);
            this.txtChiavePrivata.TabIndex = 1;
            this.txtChiavePrivata.Text = resources.GetString("txtChiavePrivata.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chiave pubblica:";
            // 
            // txtChiavePubblica
            // 
            this.txtChiavePubblica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChiavePubblica.Location = new System.Drawing.Point(108, 73);
            this.txtChiavePubblica.Name = "txtChiavePubblica";
            this.txtChiavePubblica.Size = new System.Drawing.Size(318, 20);
            this.txtChiavePubblica.TabIndex = 2;
            this.txtChiavePubblica.Text = resources.GetString("txtChiavePubblica.Text");
            // 
            // txtHEXChiave
            // 
            this.txtHEXChiave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHEXChiave.Location = new System.Drawing.Point(9, 31);
            this.txtHEXChiave.Multiline = true;
            this.txtHEXChiave.Name = "txtHEXChiave";
            this.txtHEXChiave.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHEXChiave.Size = new System.Drawing.Size(417, 127);
            this.txtHEXChiave.TabIndex = 0;
            this.txtHEXChiave.Text = resources.GetString("txtHEXChiave.Text");
            // 
            // bttHackTest
            // 
            this.bttHackTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttHackTest.Location = new System.Drawing.Point(351, 169);
            this.bttHackTest.Name = "bttHackTest";
            this.bttHackTest.Size = new System.Drawing.Size(75, 23);
            this.bttHackTest.TabIndex = 1;
            this.bttHackTest.Text = "&Test";
            this.bttHackTest.UseVisualStyleBackColor = true;
            this.bttHackTest.Click += new System.EventHandler(this.bttHackTest_Clink);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chiave copiata:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 224);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkTokenVariabile);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtTokenVariabile);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtTokenFisso);
            this.tabPage1.Controls.Add(this.txtChiavePrivata);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.bttGeneraChiavi);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtChiavePubblica);
            this.tabPage1.Controls.Add(this.bttStandardTest);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chiamata con chiave pubblica";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkTokenVariabile
            // 
            this.chkTokenVariabile.AutoSize = true;
            this.chkTokenVariabile.Checked = true;
            this.chkTokenVariabile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTokenVariabile.Location = new System.Drawing.Point(108, 152);
            this.chkTokenVariabile.Name = "chkTokenVariabile";
            this.chkTokenVariabile.Size = new System.Drawing.Size(133, 17);
            this.chkTokenVariabile.TabIndex = 5;
            this.chkTokenVariabile.Text = "Cambia token variabile";
            this.chkTokenVariabile.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Token variabile:";
            // 
            // txtTokenVariabile
            // 
            this.txtTokenVariabile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTokenVariabile.Location = new System.Drawing.Point(108, 126);
            this.txtTokenVariabile.MaxLength = 36;
            this.txtTokenVariabile.Name = "txtTokenVariabile";
            this.txtTokenVariabile.Size = new System.Drawing.Size(318, 20);
            this.txtTokenVariabile.TabIndex = 4;
            this.txtTokenVariabile.Text = "15919A4B-CC41-44EB-B2B1-80EB6F06DA3F";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Token fisso:";
            // 
            // txtTokenFisso
            // 
            this.txtTokenFisso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTokenFisso.Location = new System.Drawing.Point(108, 100);
            this.txtTokenFisso.MaxLength = 36;
            this.txtTokenFisso.Name = "txtTokenFisso";
            this.txtTokenFisso.Size = new System.Drawing.Size(318, 20);
            this.txtTokenFisso.TabIndex = 3;
            this.txtTokenFisso.Text = "322F3958-DEFD-4E05-94AE-8CAD7D69330A";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.bttHackTest);
            this.tabPage2.Controls.Add(this.txtHEXChiave);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(432, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HackTest";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Risposta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 430);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCLS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MVC4ASPNETWebApiClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttStandardTest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCLS;
        private System.Windows.Forms.Button bttGeneraChiavi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChiavePrivata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChiavePubblica;
        private System.Windows.Forms.TextBox txtHEXChiave;
        private System.Windows.Forms.Button bttHackTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTokenFisso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTokenVariabile;
        private System.Windows.Forms.CheckBox chkTokenVariabile;
    }
}

