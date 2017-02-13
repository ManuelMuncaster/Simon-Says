namespace Simon_Says
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.ForeColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(162, 68);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(59, 61);
            this.redButton.TabIndex = 0;
            this.redButton.Text = "button1";
            this.redButton.UseVisualStyleBackColor = false;
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.LawnGreen;
            this.greenButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.greenButton.Location = new System.Drawing.Point(82, 68);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(59, 61);
            this.greenButton.TabIndex = 1;
            this.greenButton.Text = "button2";
            this.greenButton.UseVisualStyleBackColor = false;
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.ForeColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(82, 149);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(59, 61);
            this.yellowButton.TabIndex = 2;
            this.yellowButton.Text = "button3";
            this.yellowButton.UseVisualStyleBackColor = false;
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.ForeColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(162, 149);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(59, 61);
            this.blueButton.TabIndex = 3;
            this.blueButton.Text = "button1";
            this.blueButton.UseVisualStyleBackColor = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
    }
}
