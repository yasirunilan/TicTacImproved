namespace TicTac
{
    partial class StartWindow
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTTTName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Orange;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonPlay.Location = new System.Drawing.Point(70, 91);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(114, 37);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Orange;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(70, 153);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(114, 35);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTTTName
            // 
            this.labelTTTName.AutoSize = true;
            this.labelTTTName.BackColor = System.Drawing.Color.Orange;
            this.labelTTTName.Font = new System.Drawing.Font("Blackoak Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTTName.Location = new System.Drawing.Point(34, 40);
            this.labelTTTName.Name = "labelTTTName";
            this.labelTTTName.Size = new System.Drawing.Size(215, 20);
            this.labelTTTName.TabIndex = 2;
            this.labelTTTName.Text = "Tic Tac Toe";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(281, 261);
            this.Controls.Add(this.labelTTTName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlay);
            this.MaximizeBox = false;
            this.Name = "StartWindow";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.StartWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTTTName;
    }
}