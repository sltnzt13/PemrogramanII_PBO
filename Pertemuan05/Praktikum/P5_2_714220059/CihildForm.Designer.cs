namespace P5_2_714220059
{
    partial class CihildForm
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
            this.DisplayButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.DateButton = new System.Windows.Forms.RadioButton();
            this.TimeOption = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.Location = new System.Drawing.Point(12, 50);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(93, 46);
            this.DisplayButton.TabIndex = 0;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(0, 16);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(292, 31);
            this.OutputLabel.TabIndex = 1;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(200, 121);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 25);
            this.Exit.TabIndex = 2;
            this.Exit.Text = " ";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.TimeOption);
            this.groupBox.Controls.Add(this.DateButton);
            this.groupBox.Location = new System.Drawing.Point(8, 152);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 104);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Choose Output";
            // 
            // DateButton
            // 
            this.DateButton.Location = new System.Drawing.Point(16, 30);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(168, 24);
            this.DateButton.TabIndex = 1;
            this.DateButton.TabStop = true;
            this.DateButton.Text = "Display Current D&ate";
            this.DateButton.UseVisualStyleBackColor = true;
            // 
            // TimeOption
            // 
            this.TimeOption.Location = new System.Drawing.Point(48, 48);
            this.TimeOption.Name = "TimeOption";
            this.TimeOption.Size = new System.Drawing.Size(168, 24);
            this.TimeOption.TabIndex = 0;
            this.TimeOption.TabStop = false;
            this.TimeOption.Text = "Display Current &Time";
            // 
            // CihildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 263);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.DisplayButton);
            this.Name = "CihildForm";
            this.Text = "ChildForm";
            this.Load += new System.EventHandler(this.CihildForm_Load);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton DateButton;
        private System.Windows.Forms.GroupBox TimeOption;
    }
}