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
        }

        Game game = new Game();


        private void buttonTP_Click(object sender, EventArgs e)
        {
            panelLevel.Enabled = false;
            panelP2.Enabled = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //display a message box when the user clicks exit button
            DialogResult exit = MessageBox.Show("Do you want to exit the Game?", "Want to exit", MessageBoxButtons.YesNo);

            //exit the application if user confirms the exit command
            if (exit == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Visible = false;

        }
    }
}
