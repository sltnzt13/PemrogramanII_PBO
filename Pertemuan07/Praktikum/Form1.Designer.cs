namespace P7_1_714220059.test
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxProdi = new System.Windows.Forms.TextBox();
            this.textBoxKelas = new System.Windows.Forms.TextBox();
            this.buttonCek = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonSenin = new System.Windows.Forms.RadioButton();
            this.radioButtonMinggu = new System.Windows.Forms.RadioButton();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.checkBoxKuliah = new System.Windows.Forms.CheckBox();
            this.checkBoxTraveling = new System.Windows.Forms.CheckBox();
            this.checkBoxTidur = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prodi ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(181, 44);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(252, 26);
            this.textBoxNama.TabIndex = 3;
            // 
            // textBoxProdi
            // 
            this.textBoxProdi.Location = new System.Drawing.Point(181, 106);
            this.textBoxProdi.Name = "textBoxProdi";
            this.textBoxProdi.Size = new System.Drawing.Size(252, 26);
            this.textBoxProdi.TabIndex = 4;
            // 
            // textBoxKelas
            // 
            this.textBoxKelas.Location = new System.Drawing.Point(181, 160);
            this.textBoxKelas.Name = "textBoxKelas";
            this.textBoxKelas.Size = new System.Drawing.Size(252, 26);
            this.textBoxKelas.TabIndex = 5;
            // 
            // buttonCek
            // 
            this.buttonCek.Location = new System.Drawing.Point(181, 229);
            this.buttonCek.Name = "buttonCek";
            this.buttonCek.Size = new System.Drawing.Size(75, 37);
            this.buttonCek.TabIndex = 6;
            this.buttonCek.Text = "Cek";
            this.buttonCek.UseVisualStyleBackColor = true;
            this.buttonCek.Click += new System.EventHandler(this.buttonCek_Click);
            // 
            // buttonTutup
            // 
            this.buttonTutup.Location = new System.Drawing.Point(319, 233);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(114, 33);
            this.buttonTutup.TabIndex = 7;
            this.buttonTutup.Text = "Tutup Form";
            this.buttonTutup.UseVisualStyleBackColor = true;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "LIST KEGIATAN";
            // 
            // radioButtonSenin
            // 
            this.radioButtonSenin.AutoSize = true;
            this.radioButtonSenin.Location = new System.Drawing.Point(88, 338);
            this.radioButtonSenin.Name = "radioButtonSenin";
            this.radioButtonSenin.Size = new System.Drawing.Size(75, 24);
            this.radioButtonSenin.TabIndex = 9;
            this.radioButtonSenin.TabStop = true;
            this.radioButtonSenin.Text = "Senin";
            this.radioButtonSenin.UseVisualStyleBackColor = true;
            this.radioButtonSenin.CheckedChanged += new System.EventHandler(this.radioButtonSenin_CheckedChanged);
            // 
            // radioButtonMinggu
            // 
            this.radioButtonMinggu.AutoSize = true;
            this.radioButtonMinggu.Location = new System.Drawing.Point(88, 384);
            this.radioButtonMinggu.Name = "radioButtonMinggu";
            this.radioButtonMinggu.Size = new System.Drawing.Size(86, 24);
            this.radioButtonMinggu.TabIndex = 10;
            this.radioButtonMinggu.TabStop = true;
            this.radioButtonMinggu.Text = "Minggu";
            this.radioButtonMinggu.UseVisualStyleBackColor = true;
            this.radioButtonMinggu.CheckedChanged += new System.EventHandler(this.radioButtonMinggu_CheckedChanged);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(256, 565);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(64, 27);
            this.buttonPrint.TabIndex = 14;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(389, 565);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(138, 35);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset Form";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // checkBoxKuliah
            // 
            this.checkBoxKuliah.AutoSize = true;
            this.checkBoxKuliah.Location = new System.Drawing.Point(90, 425);
            this.checkBoxKuliah.Name = "checkBoxKuliah";
            this.checkBoxKuliah.Size = new System.Drawing.Size(78, 24);
            this.checkBoxKuliah.TabIndex = 16;
            this.checkBoxKuliah.Text = "Kuliah";
            this.checkBoxKuliah.UseVisualStyleBackColor = true;
            // 
            // checkBoxTraveling
            // 
            this.checkBoxTraveling.AutoSize = true;
            this.checkBoxTraveling.Location = new System.Drawing.Point(88, 474);
            this.checkBoxTraveling.Name = "checkBoxTraveling";
            this.checkBoxTraveling.Size = new System.Drawing.Size(98, 24);
            this.checkBoxTraveling.TabIndex = 17;
            this.checkBoxTraveling.Text = "Traveling";
            this.checkBoxTraveling.UseVisualStyleBackColor = true;
            // 
            // checkBoxTidur
            // 
            this.checkBoxTidur.AutoSize = true;
            this.checkBoxTidur.Location = new System.Drawing.Point(89, 518);
            this.checkBoxTidur.Name = "checkBoxTidur";
            this.checkBoxTidur.Size = new System.Drawing.Size(70, 24);
            this.checkBoxTidur.TabIndex = 18;
            this.checkBoxTidur.Text = "Tidur";
            this.checkBoxTidur.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 613);
            this.Controls.Add(this.checkBoxTidur);
            this.Controls.Add(this.checkBoxTraveling);
            this.Controls.Add(this.checkBoxKuliah);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.radioButtonMinggu);
            this.Controls.Add(this.radioButtonSenin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonCek);
            this.Controls.Add(this.textBoxKelas);
            this.Controls.Add(this.textBoxProdi);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxProdi;
        private System.Windows.Forms.TextBox textBoxKelas;
        private System.Windows.Forms.Button buttonCek;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonSenin;
        private System.Windows.Forms.RadioButton radioButtonMinggu;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBoxKuliah;
        private System.Windows.Forms.CheckBox checkBoxTraveling;
        private System.Windows.Forms.CheckBox checkBoxTidur;
    }
}

