namespace P5_1_714220059
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
            this.OutputLabel = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.Hellobutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(5, 20);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(264, 23);
            this.OutputLabel.TabIndex = 0;
            this.OutputLabel.Text = "label1";
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OutputLabel.Click += new System.EventHandler(this.x);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(12, 72);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 20);
            this.Output.TabIndex = 1;
            // 
            // Hellobutton
            // 
            this.Hellobutton.Location = new System.Drawing.Point(57, 87);
            this.Hellobutton.Name = "Hellobutton";
            this.Hellobutton.Size = new System.Drawing.Size(82, 25);
            this.Hellobutton.TabIndex = 2;
            this.Hellobutton.Text = "sayHello";
            this.Hellobutton.UseVisualStyleBackColor = true;
            this.Hellobutton.Click += new System.EventHandler(this.Hellobutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(161, 87);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 25);
            this.exitbutton.TabIndex = 3;
            this.exitbutton.Text = "Exit\r\n";
            this.exitbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(278, 153);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.Hellobutton);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.OutputLabel);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button Hellobutton;
        private System.Windows.Forms.Button exitbutton;
    }
}

