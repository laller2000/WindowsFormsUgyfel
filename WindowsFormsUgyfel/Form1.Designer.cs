namespace WindowsFormsUgyfel
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Szuletes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Beosztas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnBeolvas = new System.Windows.Forms.Button();
            this.btnFajlbair = new System.Windows.Forms.Button();
            this.listBox_Dolgozok = new System.Windows.Forms.ListBox();
            this.comboBox_Helyseg = new System.Windows.Forms.ComboBox();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.radioButton_Ferfi = new System.Windows.Forms.RadioButton();
            this.radibutton_Egyeb = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Szuletes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(110, 25);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(239, 22);
            this.textBox_Nev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Születési év:";
            // 
            // numericUpDown_Szuletes
            // 
            this.numericUpDown_Szuletes.Location = new System.Drawing.Point(144, 138);
            this.numericUpDown_Szuletes.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown_Szuletes.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown_Szuletes.Name = "numericUpDown_Szuletes";
            this.numericUpDown_Szuletes.Size = new System.Drawing.Size(153, 22);
            this.numericUpDown_Szuletes.TabIndex = 3;
            this.numericUpDown_Szuletes.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Beosztás";
            // 
            // comboBox_Beosztas
            // 
            this.comboBox_Beosztas.FormattingEnabled = true;
            this.comboBox_Beosztas.Items.AddRange(new object[] {
            "Főnök",
            "Titkár",
            "Raktáros",
            "Takarítónő"});
            this.comboBox_Beosztas.Location = new System.Drawing.Point(130, 184);
            this.comboBox_Beosztas.Name = "comboBox_Beosztas";
            this.comboBox_Beosztas.Size = new System.Drawing.Size(180, 24);
            this.comboBox_Beosztas.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Helység";
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(114, 301);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 23);
            this.btnLista.TabIndex = 8;
            this.btnLista.Text = "Listáhozadd";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnBeolvas
            // 
            this.btnBeolvas.Location = new System.Drawing.Point(266, 297);
            this.btnBeolvas.Name = "btnBeolvas";
            this.btnBeolvas.Size = new System.Drawing.Size(83, 33);
            this.btnBeolvas.TabIndex = 9;
            this.btnBeolvas.Text = "Beolvas";
            this.btnBeolvas.UseVisualStyleBackColor = true;
            this.btnBeolvas.Click += new System.EventHandler(this.btnBeolvas_Click);
            // 
            // btnFajlbair
            // 
            this.btnFajlbair.Location = new System.Drawing.Point(372, 291);
            this.btnFajlbair.Name = "btnFajlbair";
            this.btnFajlbair.Size = new System.Drawing.Size(83, 33);
            this.btnFajlbair.TabIndex = 10;
            this.btnFajlbair.Text = "Fájbair";
            this.btnFajlbair.UseVisualStyleBackColor = true;
            this.btnFajlbair.Click += new System.EventHandler(this.btnFajlbair_Click);
            // 
            // listBox_Dolgozok
            // 
            this.listBox_Dolgozok.FormattingEnabled = true;
            this.listBox_Dolgozok.ItemHeight = 16;
            this.listBox_Dolgozok.Location = new System.Drawing.Point(594, 25);
            this.listBox_Dolgozok.Name = "listBox_Dolgozok";
            this.listBox_Dolgozok.Size = new System.Drawing.Size(280, 260);
            this.listBox_Dolgozok.TabIndex = 11;
            // 
            // comboBox_Helyseg
            // 
            this.comboBox_Helyseg.FormattingEnabled = true;
            this.comboBox_Helyseg.Items.AddRange(new object[] {
            "Eger",
            "Debrecen",
            "Bagos",
            "Miskolc"});
            this.comboBox_Helyseg.Location = new System.Drawing.Point(155, 234);
            this.comboBox_Helyseg.Name = "comboBox_Helyseg";
            this.comboBox_Helyseg.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Helyseg.TabIndex = 12;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Location = new System.Drawing.Point(70, 69);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(47, 21);
            this.radioButton_No.TabIndex = 13;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "Nő";
            this.radioButton_No.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ferfi
            // 
            this.radioButton_Ferfi.AutoSize = true;
            this.radioButton_Ferfi.Location = new System.Drawing.Point(179, 69);
            this.radioButton_Ferfi.Name = "radioButton_Ferfi";
            this.radioButton_Ferfi.Size = new System.Drawing.Size(57, 21);
            this.radioButton_Ferfi.TabIndex = 14;
            this.radioButton_Ferfi.TabStop = true;
            this.radioButton_Ferfi.Text = "Férfi";
            this.radioButton_Ferfi.UseVisualStyleBackColor = true;
            // 
            // radibutton_Egyeb
            // 
            this.radibutton_Egyeb.AutoSize = true;
            this.radibutton_Egyeb.Location = new System.Drawing.Point(293, 69);
            this.radibutton_Egyeb.Name = "radibutton_Egyeb";
            this.radibutton_Egyeb.Size = new System.Drawing.Size(69, 21);
            this.radibutton_Egyeb.TabIndex = 15;
            this.radibutton_Egyeb.TabStop = true;
            this.radibutton_Egyeb.Text = "Egyéb";
            this.radibutton_Egyeb.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "Mentes";
            this.openFileDialog1.Filter = "Szövegfálj (*.txt)|*.txt|Minden (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Szövegfálj (*.txt)|*.txt|Minden (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 430);
            this.Controls.Add(this.radibutton_Egyeb);
            this.Controls.Add(this.radioButton_Ferfi);
            this.Controls.Add(this.radioButton_No);
            this.Controls.Add(this.comboBox_Helyseg);
            this.Controls.Add(this.listBox_Dolgozok);
            this.Controls.Add(this.btnFajlbair);
            this.Controls.Add(this.btnBeolvas);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Beosztas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_Szuletes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ügyfélnyilvántartás";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Szuletes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Szuletes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Beosztas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnBeolvas;
        private System.Windows.Forms.Button btnFajlbair;
        private System.Windows.Forms.ListBox listBox_Dolgozok;
        private System.Windows.Forms.ComboBox comboBox_Helyseg;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.RadioButton radioButton_Ferfi;
        private System.Windows.Forms.RadioButton radibutton_Egyeb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

