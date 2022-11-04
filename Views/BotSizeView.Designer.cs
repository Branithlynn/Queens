
namespace Queens.Views
{
    partial class BotSizeView
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ErrorLabelM = new System.Windows.Forms.Label();
            this.ErrorLabelN = new System.Windows.Forms.Label();
            this.NLabel = new System.Windows.Forms.Label();
            this.Mlabel = new System.Windows.Forms.Label();
            this.MInput = new System.Windows.Forms.TextBox();
            this.NInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(102, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(597, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please Enter N and M for the size of the board:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(339, 277);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 29);
            this.StartButton.TabIndex = 15;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ErrorLabelM
            // 
            this.ErrorLabelM.AutoSize = true;
            this.ErrorLabelM.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabelM.Location = new System.Drawing.Point(327, 236);
            this.ErrorLabelM.Name = "ErrorLabelM";
            this.ErrorLabelM.Size = new System.Drawing.Size(0, 17);
            this.ErrorLabelM.TabIndex = 14;
            // 
            // ErrorLabelN
            // 
            this.ErrorLabelN.AutoSize = true;
            this.ErrorLabelN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabelN.Location = new System.Drawing.Point(327, 180);
            this.ErrorLabelN.Name = "ErrorLabelN";
            this.ErrorLabelN.Size = new System.Drawing.Size(0, 17);
            this.ErrorLabelN.TabIndex = 13;
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Location = new System.Drawing.Point(266, 157);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(23, 20);
            this.NLabel.TabIndex = 12;
            this.NLabel.Text = "N:";
            // 
            // Mlabel
            // 
            this.Mlabel.AutoSize = true;
            this.Mlabel.Location = new System.Drawing.Point(266, 209);
            this.Mlabel.Name = "Mlabel";
            this.Mlabel.Size = new System.Drawing.Size(25, 20);
            this.Mlabel.TabIndex = 11;
            this.Mlabel.Text = "M:";
            // 
            // MInput
            // 
            this.MInput.Location = new System.Drawing.Point(327, 206);
            this.MInput.Name = "MInput";
            this.MInput.Size = new System.Drawing.Size(125, 27);
            this.MInput.TabIndex = 10;
            // 
            // NInput
            // 
            this.NInput.Location = new System.Drawing.Point(327, 150);
            this.NInput.Name = "NInput";
            this.NInput.Size = new System.Drawing.Size(125, 27);
            this.NInput.TabIndex = 9;
            // 
            // BotSizeView
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
            this.Controls.Add(this.MInput);
            this.Controls.Add(this.NInput);
            this.Controls.Add(this.label2);
            this.Name = "BotSizeView";
            this.Text = "BotSizeView";
            this.Load += new System.EventHandler(this.BotSizeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ErrorLabelM;
        private System.Windows.Forms.Label ErrorLabelN;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.Label Mlabel;
        private System.Windows.Forms.TextBox MInput;
        private System.Windows.Forms.TextBox NInput;
    }
}