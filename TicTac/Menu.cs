using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.ControlBox = false;
            
        }

        String mode;
        String level;
        String player1;
        String player2;

        


        private void buttonTP_Click(object sender, EventArgs e)
        {
            panelLevel.Enabled = false;
            panelP2.Enabled = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //display a message box when the user clicks exit button
            DialogResult exit = MessageBox.Show("Do you want to exit the Game?", "Exit", MessageBoxButtons.YesNo);

            //exit the application if user confirms the exit command
            if (exit == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            player1 = textBoxP1.Text;
            player2 = textBoxP2.Text;

            Game game = new Game();
            
            this.Visible = false;
            
            game.labelLevel.Text = level;
            game.labelMode.Text = mode;
            game.Visible = true;
            game.labelP1Name.Text = player1;
            game.labelP2Name.Text = player2;
           // this.Dispose();

        }

        private void buttonSP_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonSP_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSP.Checked == true)
            {
                mode = "Single Player";
                textBoxP2.Text = "Computer";
                panelLevel.Enabled = true;
                panelP2.Enabled = false;
            }
        }

        private void radioButtonTP_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTP.Checked == true)
            {
                mode = "Two Player";
                textBoxP2.Text = "";
                panelLevel.Enabled = false;
                panelP2.Enabled = true;
            }
        }

        private void radioButtonEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEasy.Checked == true)
            {
                level = "easy";
            }
        }

        private void radioButtonHard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHard.Checked == true)
            {
                level = "hard";
            }
        }
    }
}
