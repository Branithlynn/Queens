
namespace Queens.Views
{
    partial class ChooseSizeView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NInput = new System.Windows.Forms.TextBox();
            this.MInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mlabel = new System.Windows.Forms.Label();
            this.NLabel = new System.Windows.Forms.Label();
            this.ErrorLabelN = new System.Windows.Forms.Label();
            this.ErrorLabelM = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NInput
            // 
            this.NInput.Location = new System.Drawing.Point(340, 157);
            this.NInput.Name = "NInput";
            this.NInput.Size = new System.Drawing.Size(125, 27);
            this.NInput.TabIndex = 0;
            // 
            // MInput
            // 
            this.MInput.Location = new System.Drawing.Point(340, 213);
            this.MInput.Name = "MInput";
            this.MInput.Size = new System.Drawing.Size(125, 27);
            this.MInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter N and M for the size of the board:";
            // 
            // Mlabel
            // 
            this.Mlabel.AutoSize = true;
            this.Mlabel.Location = new System.Drawing.Point(279, 216);
            this.Mlabel.Name = "Mlabel";
            this.Mlabel.Size = new System.Drawing.Size(25, 20);
            this.Mlabel.TabIndex = 3;
            this.Mlabel.Text = "M:";
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Location = new System.Drawing.Point(279, 164);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(23, 20);
            this.NLabel.TabIndex = 4;
            this.NLabel.Text = "N:";
            // 
            // ErrorLabelN
            // 
            this.ErrorLabelN.AutoSize = true;
            this.ErrorLabelN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabelN.Location = new System.Drawing.Point(340, 187);
            this.ErrorLabelN.Name = "ErrorLabelN";
            this.ErrorLabelN.Size = new System.Drawing.Size(0, 17);
            this.ErrorLabelN.TabIndex = 5;
            // 
            // ErrorLabelM
            // 
            this.ErrorLabelM.AutoSize = true;
            this.ErrorLabelM.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabelM.Location = new System.Drawing.Point(340, 243);
            this.ErrorLabelM.Name = "ErrorLabelM";
            this.ErrorLabelM.Size = new System.Drawing.Size(0, 17);
            this.ErrorLabelM.TabIndex = 6;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(352, 284);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 29);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChooseSizeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ErrorLabelM);
            this.Controls.Add(this.ErrorLabelN);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.Mlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MInput);
            this.Controls.Add(this.NInput);
            this.Name = "ChooseSizeView";
            this.Text = "Choose Size";
            this.Load += new System.EventHandler(this.ChooseSizeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NInput;
        private System.Windows.Forms.TextBox MInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Mlabel;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.Label ErrorLabelN;
        private System.Windows.Forms.Label ErrorLabelM;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button button1;
    }
}

