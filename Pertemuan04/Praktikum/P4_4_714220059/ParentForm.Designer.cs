namespace P5_3_714220059
{
    partial class Text
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
            this.txtMerkHP = new System.Windows.Forms.TextBox();
            this.rb_android = new System.Windows.Forms.RadioButton();
            this.cbYa = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_ios = new System.Windows.Forms.RadioButton();
            this.btnTampilankan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merk HP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMerkHP
            // 
            this.txtMerkHP.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMerkHP.Location = new System.Drawing.Point(216, 68);
            this.txtMerkHP.Name = "txtMerkHP";
            this.txtMerkHP.Size = new System.Drawing.Size(289, 31);
            this.txtMerkHP.TabIndex = 1;
            this.txtMerkHP.TextChanged += new System.EventHandler(this.txtMerkHP_TextChanged);
            // 
            // rb_android
            // 
            this.rb_android.AutoSize = true;
            this.rb_android.Location = new System.Drawing.Point(216, 134);
            this.rb_android.Name = "rb_android";
            this.rb_android.Size = new System.Drawing.Size(89, 24);
            this.rb_android.TabIndex = 2;
            this.rb_android.TabStop = true;
            this.rb_android.Text = "Android";
            this.rb_android.UseVisualStyleBackColor = true;
            // 
            // cbYa
            // 
            this.cbYa.AutoSize = true;
            this.cbYa.Location = new System.Drawing.Point(216, 190);
            this.cbYa.Name = "cbYa";
            this.cbYa.Size = new System.Drawing.Size(55, 24);
            this.cbYa.TabIndex = 3;
            this.cbYa.Text = "Ya";
            this.cbYa.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(25, 136);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 26);
            this.label.TabIndex = 4;
            this.label.Text = "OS";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sudah Diperbaiki?";
            // 
            // rb_ios
            // 
            this.rb_ios.AutoSize = true;
            this.rb_ios.Location = new System.Drawing.Point(330, 134);
            this.rb_ios.Name = "rb_ios";
            this.rb_ios.Size = new System.Drawing.Size(60, 24);
            this.rb_ios.TabIndex = 6;
            this.rb_ios.TabStop = true;
            this.rb_ios.Text = "iOS";
            this.rb_ios.UseVisualStyleBackColor = true;
            // 
            // btnTampilankan
            // 
            this.btnTampilankan.Location = new System.Drawing.Point(132, 276);
            this.btnTampilankan.Name = "btnTampilankan";
            this.btnTampilankan.Size = new System.Drawing.Size(90, 32);
            this.btnTampilankan.TabIndex = 7;
            this.btnTampilankan.Text = "Tampilkan";
            this.btnTampilankan.UseVisualStyleBackColor = true;
            this.btnTampilankan.Click += new System.EventHandler(this.btnTampilankan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(289, 276);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 32);
            this.btnKeluar.TabIndex = 8;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(517, 422);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnTampilankan);
            this.Controls.Add(this.rb_ios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cbYa);
            this.Controls.Add(this.rb_android);
            this.Controls.Add(this.txtMerkHP);
            this.Controls.Add(this.label1);
            this.Name = "Text";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMerkHP;
        private System.Windows.Forms.RadioButton rb_android;
        private System.Windows.Forms.CheckBox cbYa;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_ios;
        private System.Windows.Forms.Button btnTampilankan;
        private System.Windows.Forms.Button btnKeluar;
    }
}

