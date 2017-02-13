namespace Simon_Says
{
    partial class GameoverScreen
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
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.patternlengthLabel = new System.Windows.Forms.Label();
            this.patternnumberLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverLabel.Location = new System.Drawing.Point(51, 42);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(200, 39);
            this.gameoverLabel.TabIndex = 0;
            this.gameoverLabel.Text = "Game Over!";
            // 
            // patternlengthLabel
            // 
            this.patternlengthLabel.AutoSize = true;
            this.patternlengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternlengthLabel.Location = new System.Drawing.Point(24, 95);
            this.patternlengthLabel.Name = "patternlengthLabel";
            this.patternlengthLabel.Size = new System.Drawing.Size(186, 22);
            this.patternlengthLabel.TabIndex = 1;
            this.patternlengthLabel.Text = "Your pattern length is:";
            // 
            // patternnumberLabel
            // 
            this.patternnumberLabel.AutoSize = true;
            this.patternnumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternnumberLabel.Location = new System.Drawing.Point(216, 95);
            this.patternnumberLabel.Name = "patternnumberLabel";
            this.patternnumberLabel.Size = new System.Drawing.Size(58, 22);
            this.patternnumberLabel.TabIndex = 2;
            this.patternnumberLabel.Text = "label2";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(109, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GameoverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patternnumberLabel);
            this.Controls.Add(this.patternlengthLabel);
            this.Controls.Add(this.gameoverLabel);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "GameoverScreen";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Label patternlengthLabel;
        private System.Windows.Forms.Label patternnumberLabel;
        private System.Windows.Forms.Button button1;
    }
}
