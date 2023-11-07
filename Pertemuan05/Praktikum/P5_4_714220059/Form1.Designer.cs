namespace P5_4_714220059
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
            this.Nama1 = new System.Windows.Forms.Label();
            this.kelamin = new System.Windows.Forms.Label();
            this.Tanggal = new System.Windows.Forms.Label();
            this.TeksPesan = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Kelas = new System.Windows.Forms.GroupBox();
            this.piano = new System.Windows.Forms.CheckBox();
            this.Biola = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.Gitar = new System.Windows.Forms.CheckBox();
            this.Vokal = new System.Windows.Forms.CheckBox();
            this.sex = new System.Windows.Forms.CheckBox();
            this.Drum = new System.Windows.Forms.CheckBox();
            this.konduk = new System.Windows.Forms.CheckBox();
            this.Jadwal = new System.Windows.Forms.GroupBox();
            this.Senin = new System.Windows.Forms.RadioButton();
            this.Selasa = new System.Windows.Forms.RadioButton();
            this.Minggu = new System.Windows.Forms.RadioButton();
            this.Sabtu = new System.Windows.Forms.RadioButton();
            this.MessageButtons = new System.Windows.Forms.Button();
            this.MessageBoxIcon = new System.Windows.Forms.Button();
            this.Kelas.SuspendLayout();
            this.Jadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nama1
            // 
            this.Nama1.AutoSize = true;
            this.Nama1.Location = new System.Drawing.Point(91, 70);
            this.Nama1.Name = "Nama1";
            this.Nama1.Size = new System.Drawing.Size(51, 20);
            this.Nama1.TabIndex = 0;
            this.Nama1.Text = "Nama";
            this.Nama1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kelamin
            // 
            this.kelamin.AutoSize = true;
            this.kelamin.Location = new System.Drawing.Point(91, 124);
            this.kelamin.Name = "kelamin";
            this.kelamin.Size = new System.Drawing.Size(106, 20);
            this.kelamin.TabIndex = 1;
            this.kelamin.Text = "Jenis Kelamin";
            // 
            // Tanggal
            // 
            this.Tanggal.AutoSize = true;
            this.Tanggal.Location = new System.Drawing.Point(91, 188);
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Size = new System.Drawing.Size(105, 20);
            this.Tanggal.TabIndex = 2;
            this.Tanggal.Text = "Tanggal Lahir";
            // 
            // TeksPesan
            // 
            this.TeksPesan.Location = new System.Drawing.Point(216, 64);
            this.TeksPesan.Name = "TeksPesan";
            this.TeksPesan.Size = new System.Drawing.Size(200, 26);
            this.TeksPesan.TabIndex = 3;
            this.TeksPesan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.comboBox1.Location = new System.Drawing.Point(216, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Kelas
            // 
            this.Kelas.Controls.Add(this.piano);
            this.Kelas.Controls.Add(this.Biola);
            this.Kelas.Controls.Add(this.checkBox8);
            this.Kelas.Controls.Add(this.Gitar);
            this.Kelas.Controls.Add(this.Vokal);
            this.Kelas.Controls.Add(this.sex);
            this.Kelas.Controls.Add(this.Drum);
            this.Kelas.Controls.Add(this.konduk);
            this.Kelas.Location = new System.Drawing.Point(95, 305);
            this.Kelas.Name = "Kelas";
            this.Kelas.Size = new System.Drawing.Size(336, 247);
            this.Kelas.TabIndex = 6;
            this.Kelas.TabStop = false;
            this.Kelas.Text = "Pilihan Kelas";
            // 
            // piano
            // 
            this.piano.AutoSize = true;
            this.piano.Location = new System.Drawing.Point(188, 41);
            this.piano.Name = "piano";
            this.piano.Size = new System.Drawing.Size(75, 24);
            this.piano.TabIndex = 16;
            this.piano.Text = "Piano";
            this.piano.UseVisualStyleBackColor = true;
            // 
            // Biola
            // 
            this.Biola.AutoSize = true;
            this.Biola.Location = new System.Drawing.Point(6, 41);
            this.Biola.Name = "Biola";
            this.Biola.Size = new System.Drawing.Size(70, 24);
            this.Biola.TabIndex = 12;
            this.Biola.Text = "Biola";
            this.Biola.UseVisualStyleBackColor = true;
            this.Biola.CheckedChanged += new System.EventHandler(this.Biola_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(188, 139);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(104, 24);
            this.checkBox8.TabIndex = 19;
            this.checkBox8.Text = "Komputer";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // Gitar
            // 
            this.Gitar.AutoSize = true;
            this.Gitar.Location = new System.Drawing.Point(6, 71);
            this.Gitar.Name = "Gitar";
            this.Gitar.Size = new System.Drawing.Size(70, 24);
            this.Gitar.TabIndex = 13;
            this.Gitar.Text = "Gitar";
            this.Gitar.UseVisualStyleBackColor = true;
            // 
            // Vokal
            // 
            this.Vokal.AutoSize = true;
            this.Vokal.Location = new System.Drawing.Point(188, 101);
            this.Vokal.Name = "Vokal";
            this.Vokal.Size = new System.Drawing.Size(75, 24);
            this.Vokal.TabIndex = 18;
            this.Vokal.Text = "Vokal";
            this.Vokal.UseVisualStyleBackColor = true;
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(6, 101);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(120, 24);
            this.sex.TabIndex = 14;
            this.sex.Text = "Sexophone ";
            this.sex.UseVisualStyleBackColor = true;
            // 
            // Drum
            // 
            this.Drum.AutoSize = true;
            this.Drum.Location = new System.Drawing.Point(188, 71);
            this.Drum.Name = "Drum";
            this.Drum.Size = new System.Drawing.Size(78, 24);
            this.Drum.TabIndex = 17;
            this.Drum.Text = "Drum ";
            this.Drum.UseVisualStyleBackColor = true;
            // 
            // konduk
            // 
            this.konduk.AutoSize = true;
            this.konduk.Location = new System.Drawing.Point(6, 139);
            this.konduk.Name = "konduk";
            this.konduk.Size = new System.Drawing.Size(108, 24);
            this.konduk.TabIndex = 15;
            this.konduk.Text = "Konduktor";
            this.konduk.UseVisualStyleBackColor = true;
            // 
            // Jadwal
            // 
            this.Jadwal.Controls.Add(this.Senin);
            this.Jadwal.Controls.Add(this.Selasa);
            this.Jadwal.Controls.Add(this.Minggu);
            this.Jadwal.Controls.Add(this.Sabtu);
            this.Jadwal.Location = new System.Drawing.Point(540, 305);
            this.Jadwal.Name = "Jadwal";
            this.Jadwal.Size = new System.Drawing.Size(296, 237);
            this.Jadwal.TabIndex = 7;
            this.Jadwal.TabStop = false;
            this.Jadwal.Text = "Pilihan Jadwal";
            // 
            // Senin
            // 
            this.Senin.AutoSize = true;
            this.Senin.Location = new System.Drawing.Point(26, 30);
            this.Senin.Name = "Senin";
            this.Senin.Size = new System.Drawing.Size(223, 24);
            this.Senin.TabIndex = 8;
            this.Senin.TabStop = true;
            this.Senin.Text = "Senin & Rabu, 14.00 - 16.00";
            this.Senin.UseVisualStyleBackColor = true;
            this.Senin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Selasa
            // 
            this.Selasa.AutoSize = true;
            this.Selasa.Location = new System.Drawing.Point(26, 73);
            this.Selasa.Name = "Selasa";
            this.Selasa.Size = new System.Drawing.Size(227, 24);
            this.Selasa.TabIndex = 9;
            this.Selasa.TabStop = true;
            this.Selasa.Text = "Selasa & Kamis, 14.00-16.00";
            this.Selasa.UseVisualStyleBackColor = true;
            // 
            // Minggu
            // 
            this.Minggu.AutoSize = true;
            this.Minggu.Location = new System.Drawing.Point(26, 164);
            this.Minggu.Name = "Minggu";
            this.Minggu.Size = new System.Drawing.Size(175, 24);
            this.Minggu.TabIndex = 11;
            this.Minggu.TabStop = true;
            this.Minggu.Text = "Minggu,13.00-17.00";
            this.Minggu.UseVisualStyleBackColor = true;
            // 
            // Sabtu
            // 
            this.Sabtu.AutoSize = true;
            this.Sabtu.Location = new System.Drawing.Point(26, 117);
            this.Sabtu.Name = "Sabtu";
            this.Sabtu.Size = new System.Drawing.Size(226, 24);
            this.Sabtu.TabIndex = 10;
            this.Sabtu.TabStop = true;
            this.Sabtu.Text = "Sabtu& Minggu, 14.00-16.00";
            this.Sabtu.UseVisualStyleBackColor = true;
            // 
            // MessageButtons
            // 
            this.MessageButtons.BackColor = System.Drawing.Color.Blue;
            this.MessageButtons.Location = new System.Drawing.Point(341, 604);
            this.MessageButtons.Name = "MessageButtons";
            this.MessageButtons.Size = new System.Drawing.Size(90, 32);
            this.MessageButtons.TabIndex = 20;
            this.MessageButtons.Text = "Tampilkan";
            this.MessageButtons.UseVisualStyleBackColor = false;
            this.MessageButtons.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessageBoxIcon
            // 
            this.MessageBoxIcon.BackColor = System.Drawing.Color.Blue;
            this.MessageBoxIcon.Location = new System.Drawing.Point(552, 604);
            this.MessageBoxIcon.Name = "MessageBoxIcon";
            this.MessageBoxIcon.Size = new System.Drawing.Size(89, 32);
            this.MessageBoxIcon.TabIndex = 21;
            this.MessageBoxIcon.Text = "Selesai";
            this.MessageBoxIcon.UseVisualStyleBackColor = false;
            this.MessageBoxIcon.Click += new System.EventHandler(this.MessageBoxIcon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(974, 660);
            this.Controls.Add(this.MessageBoxIcon);
            this.Controls.Add(this.MessageButtons);
            this.Controls.Add(this.Jadwal);
            this.Controls.Add(this.Kelas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TeksPesan);
            this.Controls.Add(this.Tanggal);
            this.Controls.Add(this.kelamin);
            this.Controls.Add(this.Nama1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Kelas.ResumeLayout(false);
            this.Kelas.PerformLayout();
            this.Jadwal.ResumeLayout(false);
            this.Jadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nama1;
        private System.Windows.Forms.Label kelamin;
        private System.Windows.Forms.Label Tanggal;
        private System.Windows.Forms.TextBox TeksPesan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox Kelas;
        private System.Windows.Forms.CheckBox piano;
        private System.Windows.Forms.CheckBox Biola;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox Gitar;
        private System.Windows.Forms.CheckBox Vokal;
        private System.Windows.Forms.CheckBox sex;
        private System.Windows.Forms.CheckBox Drum;
        private System.Windows.Forms.CheckBox konduk;
        private System.Windows.Forms.GroupBox Jadwal;
        private System.Windows.Forms.RadioButton Senin;
        private System.Windows.Forms.RadioButton Selasa;
        private System.Windows.Forms.RadioButton Minggu;
        private System.Windows.Forms.RadioButton Sabtu;
        private System.Windows.Forms.Button MessageButtons;
        private System.Windows.Forms.Button MessageBoxIcon;
    }
}

