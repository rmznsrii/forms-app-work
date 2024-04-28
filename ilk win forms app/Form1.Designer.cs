namespace ilk_win_forms_app
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
            this.messagebox1 = new System.Windows.Forms.Button();
            this.messagebox2 = new System.Windows.Forms.Button();
            this.textButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.textBoxButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.baslik = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxButton = new System.Windows.Forms.Button();
            this.comboBoxLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxSurname = new System.Windows.Forms.TextBox();
            this.formButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messagebox1
            // 
            this.messagebox1.Location = new System.Drawing.Point(34, 91);
            this.messagebox1.Name = "messagebox1";
            this.messagebox1.Size = new System.Drawing.Size(113, 34);
            this.messagebox1.TabIndex = 1;
            this.messagebox1.Text = "MessageBox Düz";
            this.messagebox1.UseVisualStyleBackColor = true;
            this.messagebox1.Click += new System.EventHandler(this.messagebox1_Click);
            // 
            // messagebox2
            // 
            this.messagebox2.Location = new System.Drawing.Point(34, 228);
            this.messagebox2.Name = "messagebox2";
            this.messagebox2.Size = new System.Drawing.Size(113, 32);
            this.messagebox2.TabIndex = 2;
            this.messagebox2.Text = "MessageBox Y/N/C";
            this.messagebox2.UseVisualStyleBackColor = true;
            this.messagebox2.Click += new System.EventHandler(this.messagebox2_Click);
            // 
            // textButton
            // 
            this.textButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textButton.Location = new System.Drawing.Point(34, 349);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(113, 37);
            this.textButton.TabIndex = 3;
            this.textButton.Text = "Text Değişicek";
            this.textButton.UseVisualStyleBackColor = false;
            this.textButton.Click += new System.EventHandler(this.textButton_Click);
            this.textButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textButton_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Değişicek";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(296, 288);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(188, 66);
            this.textBox1.TabIndex = 5;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.AutoSize = true;
            this.textBoxLabel.Location = new System.Drawing.Point(556, 309);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(0, 13);
            this.textBoxLabel.TabIndex = 6;
            // 
            // textBoxButton
            // 
            this.textBoxButton.Location = new System.Drawing.Point(349, 383);
            this.textBoxButton.Name = "textBoxButton";
            this.textBoxButton.Size = new System.Drawing.Size(87, 29);
            this.textBoxButton.TabIndex = 7;
            this.textBoxButton.Text = "Göster";
            this.textBoxButton.UseVisualStyleBackColor = true;
            this.textBoxButton.Click += new System.EventHandler(this.textBoxButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(346, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Metni Çek";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.BackColor = System.Drawing.Color.Yellow;
            this.baslik.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(266, 260);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(264, 16);
            this.baslik.TabIndex = 9;
            this.baslik.Text = "KULLANICININ GİRDİĞİ *\'LI METNİ GÖSTERME";
            this.baslik.Click += new System.EventHandler(this.baslik_Click);
            this.baslik.DoubleClick += new System.EventHandler(this.baslik_DoubleClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(307, 123);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Buton 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(412, 123);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Buton 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(360, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "İşaretle!";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(606, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxButton
            // 
            this.comboBoxButton.Location = new System.Drawing.Point(640, 146);
            this.comboBoxButton.Name = "comboBoxButton";
            this.comboBoxButton.Size = new System.Drawing.Size(88, 23);
            this.comboBoxButton.TabIndex = 14;
            this.comboBoxButton.Text = "MesajKutusu";
            this.comboBoxButton.UseVisualStyleBackColor = true;
            this.comboBoxButton.Click += new System.EventHandler(this.comboBoxButton_Click);
            // 
            // comboBoxLabel
            // 
            this.comboBoxLabel.AutoSize = true;
            this.comboBoxLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLabel.Location = new System.Drawing.Point(627, 91);
            this.comboBoxLabel.Name = "comboBoxLabel";
            this.comboBoxLabel.Size = new System.Drawing.Size(112, 17);
            this.comboBoxLabel.TabIndex = 15;
            this.comboBoxLabel.Text = "Hangi Gündeyiz?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(210, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "FORM NESNELERİNİ TANIMA VE ETKİLEŞİMDE BULUNMA ÇALIŞMASI";
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(628, 253);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(100, 20);
            this.textboxName.TabIndex = 17;
            // 
            // textboxSurname
            // 
            this.textboxSurname.Location = new System.Drawing.Point(628, 306);
            this.textboxSurname.Name = "textboxSurname";
            this.textboxSurname.Size = new System.Drawing.Size(100, 20);
            this.textboxSurname.TabIndex = 18;
            // 
            // formButton
            // 
            this.formButton.Location = new System.Drawing.Point(618, 369);
            this.formButton.Name = "formButton";
            this.formButton.Size = new System.Drawing.Size(122, 23);
            this.formButton.TabIndex = 19;
            this.formButton.Text = "Diğer Forma Aktar";
            this.formButton.UseVisualStyleBackColor = true;
            this.formButton.Click += new System.EventHandler(this.formButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(812, 452);
            this.Controls.Add(this.formButton);
            this.Controls.Add(this.textboxSurname);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLabel);
            this.Controls.Add(this.comboBoxButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxButton);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textButton);
            this.Controls.Add(this.messagebox2);
            this.Controls.Add(this.messagebox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlk Form Pencerem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button messagebox1;
        private System.Windows.Forms.Button messagebox2;
        private System.Windows.Forms.Button textButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textBoxLabel;
        private System.Windows.Forms.Button textBoxButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button comboBoxButton;
        private System.Windows.Forms.Label comboBoxLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxSurname;
        private System.Windows.Forms.Button formButton;
    }
}

