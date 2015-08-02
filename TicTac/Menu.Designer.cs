namespace TicTac
{
    partial class Menu
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
            this.panelPlayMode = new System.Windows.Forms.Panel();
            this.radioButtonTP = new System.Windows.Forms.RadioButton();
            this.radioButtonSP = new System.Windows.Forms.RadioButton();
            this.panelLevel = new System.Windows.Forms.Panel();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.panelP1 = new System.Windows.Forms.Panel();
            this.textBoxP1 = new System.Windows.Forms.TextBox();
            this.labelP1 = new System.Windows.Forms.Label();
            this.panelP2 = new System.Windows.Forms.Panel();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.labelP2 = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelPlayMode.SuspendLayout();
            this.panelLevel.SuspendLayout();
            this.panelP1.SuspendLayout();
            this.panelP2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlayMode
            // 
            this.panelPlayMode.Controls.Add(this.radioButtonTP);
            this.panelPlayMode.Controls.Add(this.radioButtonSP);
            this.panelPlayMode.Location = new System.Drawing.Point(25, 20);
            this.panelPlayMode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelPlayMode.Name = "panelPlayMode";
            this.panelPlayMode.Size = new System.Drawing.Size(428, 95);
            this.panelPlayMode.TabIndex = 0;
            // 
            // radioButtonTP
            // 
            this.radioButtonTP.AutoSize = true;
            this.radioButtonTP.BackColor = System.Drawing.Color.Orange;
            this.radioButtonTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTP.Location = new System.Drawing.Point(40, 52);
            this.radioButtonTP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radioButtonTP.Name = "radioButtonTP";
            this.radioButtonTP.Size = new System.Drawing.Size(113, 24);
            this.radioButtonTP.TabIndex = 1;
            this.radioButtonTP.Text = "Two Player";
            this.radioButtonTP.UseVisualStyleBackColor = false;
            this.radioButtonTP.CheckedChanged += new System.EventHandler(this.radioButtonTP_CheckedChanged);
            // 
            // radioButtonSP
            // 
            this.radioButtonSP.AutoSize = true;
            this.radioButtonSP.BackColor = System.Drawing.Color.Orange;
            this.radioButtonSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSP.ForeColor = System.Drawing.Color.Black;
            this.radioButtonSP.Location = new System.Drawing.Point(40, 5);
            this.radioButtonSP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radioButtonSP.Name = "radioButtonSP";
            this.radioButtonSP.Size = new System.Drawing.Size(131, 24);
            this.radioButtonSP.TabIndex = 0;
            this.radioButtonSP.Text = "Single Player";
            this.radioButtonSP.UseVisualStyleBackColor = false;
            this.radioButtonSP.CheckedChanged += new System.EventHandler(this.radioButtonSP_CheckedChanged);
            // 
            // panelLevel
            // 
            this.panelLevel.Controls.Add(this.radioButtonHard);
            this.panelLevel.Controls.Add(this.radioButtonEasy);
            this.panelLevel.Location = new System.Drawing.Point(25, 140);
            this.panelLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelLevel.Name = "panelLevel";
            this.panelLevel.Size = new System.Drawing.Size(428, 62);
            this.panelLevel.TabIndex = 1;
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.BackColor = System.Drawing.Color.Orange;
            this.radioButtonHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHard.Location = new System.Drawing.Point(265, 23);
            this.radioButtonHard.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(66, 24);
            this.radioButtonHard.TabIndex = 1;
            this.radioButtonHard.Text = "Hard";
            this.radioButtonHard.UseVisualStyleBackColor = false;
            this.radioButtonHard.CheckedChanged += new System.EventHandler(this.radioButtonHard_CheckedChanged);
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.BackColor = System.Drawing.Color.Orange;
            this.radioButtonEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEasy.Location = new System.Drawing.Point(40, 23);
            this.radioButtonEasy.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(66, 24);
            this.radioButtonEasy.TabIndex = 0;
            this.radioButtonEasy.Text = "Easy";
            this.radioButtonEasy.UseVisualStyleBackColor = false;
            this.radioButtonEasy.CheckedChanged += new System.EventHandler(this.radioButtonEasy_CheckedChanged);
            // 
            // panelP1
            // 
            this.panelP1.Controls.Add(this.textBoxP1);
            this.panelP1.Controls.Add(this.labelP1);
            this.panelP1.Location = new System.Drawing.Point(27, 223);
            this.panelP1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelP1.Name = "panelP1";
            this.panelP1.Size = new System.Drawing.Size(427, 35);
            this.panelP1.TabIndex = 2;
            // 
            // textBoxP1
            // 
            this.textBoxP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxP1.Location = new System.Drawing.Point(202, 2);
            this.textBoxP1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.Size = new System.Drawing.Size(221, 24);
            this.textBoxP1.TabIndex = 1;
            this.textBoxP1.Text = "Player1";
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.BackColor = System.Drawing.Color.Orange;
            this.labelP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1.Location = new System.Drawing.Point(5, 6);
            this.labelP1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(118, 18);
            this.labelP1.TabIndex = 0;
            this.labelP1.Text = "Player 1 Name";
            // 
            // panelP2
            // 
            this.panelP2.Controls.Add(this.textBoxP2);
            this.panelP2.Controls.Add(this.labelP2);
            this.panelP2.Location = new System.Drawing.Point(27, 274);
            this.panelP2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelP2.Name = "panelP2";
            this.panelP2.Size = new System.Drawing.Size(427, 35);
            this.panelP2.TabIndex = 3;
            // 
            // textBoxP2
            // 
            this.textBoxP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxP2.Location = new System.Drawing.Point(203, 3);
            this.textBoxP2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.Size = new System.Drawing.Size(219, 24);
            this.textBoxP2.TabIndex = 1;
            this.textBoxP2.Text = "Player2";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.BackColor = System.Drawing.Color.Orange;
            this.labelP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2.Location = new System.Drawing.Point(3, 6);
            this.labelP2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(123, 18);
            this.labelP2.TabIndex = 0;
            this.labelP2.Text = "Player 2  Name";
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Orange;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(328, 337);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(125, 46);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Orange;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(27, 337);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 46);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(473, 402);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.panelP2);
            this.Controls.Add(this.panelP1);
            this.Controls.Add(this.panelLevel);
            this.Controls.Add(this.panelPlayMode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.panelPlayMode.ResumeLayout(false);
            this.panelPlayMode.PerformLayout();
            this.panelLevel.ResumeLayout(false);
            this.panelLevel.PerformLayout();
            this.panelP1.ResumeLayout(false);
            this.panelP1.PerformLayout();
            this.panelP2.ResumeLayout(false);
            this.panelP2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlayMode;
        private System.Windows.Forms.Panel panelLevel;
        private System.Windows.Forms.RadioButton radioButtonHard;
        private System.Windows.Forms.RadioButton radioButtonEasy;
        private System.Windows.Forms.Panel panelP1;
        private System.Windows.Forms.TextBox textBoxP1;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Panel panelP2;
        private System.Windows.Forms.TextBox textBoxP2;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RadioButton radioButtonTP;
        private System.Windows.Forms.RadioButton radioButtonSP;
    }
}

