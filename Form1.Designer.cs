namespace PasswordGenerator
{
    public partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tb_output_lenght = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_zeichen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.cb_address = new System.Windows.Forms.CheckBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.cb_username = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(18, 20);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(195, 20);
            this.tb_output.TabIndex = 1;
            this.tb_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_output.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_output);
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 56);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generated Password";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(232, 198);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.tb_output_lenght);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.tb_zeichen);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(224, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Characters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox7.Location = new System.Drawing.Point(14, 141);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(112, 17);
            this.checkBox7.TabIndex = 10;
            this.checkBox7.Text = "Generated Lenght";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(157, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox4.Location = new System.Drawing.Point(129, 37);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(65, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Symbols";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox3.Location = new System.Drawing.Point(14, 37);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(68, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Numbers";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox2.Location = new System.Drawing.Point(129, 13);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Big Letters";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // tb_output_lenght
            // 
            this.tb_output_lenght.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_output_lenght.Location = new System.Drawing.Point(160, 138);
            this.tb_output_lenght.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tb_output_lenght.Name = "tb_output_lenght";
            this.tb_output_lenght.ReadOnly = true;
            this.tb_output_lenght.Size = new System.Drawing.Size(43, 20);
            this.tb_output_lenght.TabIndex = 4;
            this.tb_output_lenght.Text = "12";
            this.tb_output_lenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_output_lenght.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox1.Location = new System.Drawing.Point(14, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Small Letters";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tb_zeichen
            // 
            this.tb_zeichen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_zeichen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_zeichen.Location = new System.Drawing.Point(14, 63);
            this.tb_zeichen.Multiline = true;
            this.tb_zeichen.Name = "tb_zeichen";
            this.tb_zeichen.Size = new System.Drawing.Size(195, 64);
            this.tb_zeichen.TabIndex = 5;
            this.tb_zeichen.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            this.tb_zeichen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_zeichen.TextChanged += new System.EventHandler(this.tb_zeichen_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.checkBox6);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.checkBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(224, 172);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_address);
            this.groupBox2.Controls.Add(this.cb_address);
            this.groupBox2.Controls.Add(this.tb_username);
            this.groupBox2.Controls.Add(this.cb_username);
            this.groupBox2.Location = new System.Drawing.Point(14, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 121);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(11, 89);
            this.tb_address.Name = "tb_address";
            this.tb_address.ReadOnly = true;
            this.tb_address.Size = new System.Drawing.Size(172, 20);
            this.tb_address.TabIndex = 3;
            this.tb_address.TextChanged += new System.EventHandler(this.tb_address_TextChanged);
            // 
            // cb_address
            // 
            this.cb_address.AutoSize = true;
            this.cb_address.Enabled = false;
            this.cb_address.Location = new System.Drawing.Point(11, 68);
            this.cb_address.Name = "cb_address";
            this.cb_address.Size = new System.Drawing.Size(64, 17);
            this.cb_address.TabIndex = 2;
            this.cb_address.Text = "Address";
            this.cb_address.UseVisualStyleBackColor = true;
            this.cb_address.CheckedChanged += new System.EventHandler(this.cb_address_CheckedChanged);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(11, 41);
            this.tb_username.Name = "tb_username";
            this.tb_username.ReadOnly = true;
            this.tb_username.Size = new System.Drawing.Size(172, 20);
            this.tb_username.TabIndex = 1;
            this.tb_username.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cb_username
            // 
            this.cb_username.AutoSize = true;
            this.cb_username.Enabled = false;
            this.cb_username.Location = new System.Drawing.Point(11, 19);
            this.cb_username.Name = "cb_username";
            this.cb_username.Size = new System.Drawing.Size(114, 17);
            this.cb_username.TabIndex = 0;
            this.cb_username.Text = "Username / E-Mail";
            this.cb_username.UseVisualStyleBackColor = true;
            this.cb_username.CheckedChanged += new System.EventHandler(this.cb_username_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(23, 56);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(82, 17);
            this.checkBox6.TabIndex = 2;
            this.checkBox6.Text = "User/E-Mail";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 1;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(14, 14);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(91, 17);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Save to a File";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(231, 283);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(13, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(255, 315);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_output_lenght;
        public System.Windows.Forms.TextBox tb_zeichen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TextBox tb_output;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.CheckBox checkBox5;
        public System.Windows.Forms.CheckBox checkBox4;
        public System.Windows.Forms.CheckBox checkBox3;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox tb_address;
        public System.Windows.Forms.CheckBox cb_address;
        public System.Windows.Forms.TextBox tb_username;
        public System.Windows.Forms.CheckBox cb_username;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
    }
}

