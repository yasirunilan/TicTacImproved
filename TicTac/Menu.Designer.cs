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
            this.radioButtonSP = new System.Windows.Forms.RadioButton();
            this.radioButtonTP = new System.Windows.Forms.RadioButton();
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
            this.panelPlayMode.Location = new System.Drawing.Point(15, 13);
            this.panelPlayMode.Name = "panelPlayMode";
            this.panelPlayMode.Size = new System.Drawing.Size(257, 62);
            this.panelPlayMode.TabIndex = 0;
            // 
            // panelLevel
            // 
            this.panelLevel.Controls.Add(this.radioButtonHard);
            this.panelLevel.Controls.Add(this.radioButtonEasy);
            this.panelLevel.Location = new System.Drawing.Point(15, 91);
            this.panelLevel.Name = "panelLevel";
            this.panelLevel.Size = new System.Drawing.Size(257, 40);
            this.panelLevel.TabIndex = 1;
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Location = new System.Drawing.Point(159, 19);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(48, 17);
            this.radioButtonHard.TabIndex = 1;
            this.radioButtonHard.TabStop = true;
            this.radioButtonHard.Text = "Hard";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            this.radioButtonHard.CheckedChanged += new System.EventHandler(this.radioButtonHard_CheckedChanged);
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.Location = new System.Drawing.Point(24, 19);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(48, 17);
            this.radioButtonEasy.TabIndex = 0;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Text = "Easy";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            this.radioButtonEasy.CheckedChanged += new System.EventHandler(this.radioButtonEasy_CheckedChanged);
            // 
            // panelP1
            // 
            this.panelP1.Controls.Add(this.textBoxP1);
            this.panelP1.Controls.Add(this.labelP1);
            this.panelP1.Location = new System.Drawing.Point(16, 145);
            this.panelP1.Name = "panelP1";
            this.panelP1.Size = new System.Drawing.Size(256, 23);
            this.panelP1.TabIndex = 2;
            // 
            // textBoxP1
            // 
            this.textBoxP1.Location = new System.Drawing.Point(118, 1);
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.Size = new System.Drawing.Size(115, 20);
            this.textBoxP1.TabIndex = 1;
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Location = new System.Drawing.Point(20, 7);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(76, 13);
            this.labelP1.TabIndex = 0;
            this.labelP1.Text = "Player 1 Name";
            // 
            // panelP2
            // 
            this.panelP2.Controls.Add(this.textBoxP2);
            this.panelP2.Controls.Add(this.labelP2);
            this.panelP2.Location = new System.Drawing.Point(16, 178);
            this.panelP2.Name = "panelP2";
            this.panelP2.Size = new System.Drawing.Size(256, 23);
            this.panelP2.TabIndex = 3;
            // 
            // textBoxP2
            // 
            this.textBoxP2.Location = new System.Drawing.Point(118, 1);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.Size = new System.Drawing.Size(115, 20);
            this.textBoxP2.TabIndex = 1;
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Location = new System.Drawing.Point(20, 7);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(79, 13);
            this.labelP2.TabIndex = 0;
            this.labelP2.Text = "Player 2  Name";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(197, 226);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(16, 226);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // radioButtonSP
            // 
            this.radioButtonSP.AutoSize = true;
            this.radioButtonSP.Location = new System.Drawing.Point(24, 3);
            this.radioButtonSP.Name = "radioButtonSP";
            this.radioButtonSP.Size = new System.Drawing.Size(86, 17);
            this.radioButtonSP.TabIndex = 0;
            this.radioButtonSP.TabStop = true;
            this.radioButtonSP.Text = "Single Player";
            this.radioButtonSP.UseVisualStyleBackColor = true;
            this.radioButtonSP.CheckedChanged += new System.EventHandler(this.radioButtonSP_CheckedChanged);
            // 
            // radioButtonTP
            // 
            this.radioButtonTP.AutoSize = true;
            this.radioButtonTP.Location = new System.Drawing.Point(24, 42);
            this.radioButtonTP.Name = "radioButtonTP";
            this.radioButtonTP.Size = new System.Drawing.Size(78, 17);
            this.radioButtonTP.TabIndex = 1;
            this.radioButtonTP.TabStop = true;
            this.radioButtonTP.Text = "Two Player";
            this.radioButtonTP.UseVisualStyleBackColor = true;
            this.radioButtonTP.CheckedChanged += new System.EventHandler(this.radioButtonTP_CheckedChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.panelP2);
            this.Controls.Add(this.panelP1);
            this.Controls.Add(this.panelLevel);
            this.Controls.Add(this.panelPlayMode);
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

