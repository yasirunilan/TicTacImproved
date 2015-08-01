using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TicTac 
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
         
        int turnCount = 0;
        Random rnd = new Random();
        int[] numbers = new int[9];
        String winner;
        String mode;
        String level;
        int Player1Win = 0;
        int Player2Win = 0;
        History history = new History();
        String MyConnectionString = "Server=localhost;Database=tic;Uid=root;Pwd=qwerty";
        
        
        private void buttonA0_Click(object sender, EventArgs e)
        {
            //increment the turn counter with the button click
            turnCount++;
            //check whether to display cross or circle
            if (turnCount % 2 == 1)
            {
                
                buttonA0.Text = "X";
                
            }
            else
            {
                buttonA0.Text = "O";
            }

            
            buttonA0.Enabled = false;
            TurnChanger(turnCount);


            //call EasyPlay if the user has selected easy mode otherwise paly hard
            if (labelMode.Text == "Single Player")
            {
                winner=CheckConditions();
            }
            else if (mode == "Two Player")
            {
                winner=CheckForWin();
            }

            labelWinner.Text = winner;
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            String GameWinner = winner;
            int Player1Score = Player1Win;
            int Player2Score = Player2Win;
            mode = labelMode.Text;
            level = labelLevel.Text;

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd;


            DialogResult exit = MessageBox.Show("Want to save?", "Save", MessageBoxButtons.YesNoCancel);
            if (exit == DialogResult.Yes)
            {
                connection.Open();
                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO history_easy(scoreP,name,scoreC) VALUES(@scoreP,@name,@scoreC)";
                    cmd.Parameters.AddWithValue("@scoreP", Player1Score);
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@scoreC", Player2Score);
                    
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                        LoadData();
                    }
                }
            }
            else if (exit == DialogResult.No)
            {
                System.Windows.Forms.Application.Exit();
            }
            
        }


        private void TurnChanger(int turnCount)
        {
            if (turnCount % 2 == 1)
            {
                labelTurnIndicator.Text = labelP2Name.Text + "'s  Turn";
            }
            else
            {
                labelTurnIndicator.Text = labelP1Name.Text + "'s  Turn";
            }
        }

        private String CheckConditions()
        {
            if (labelLevel.Text == "easy")
            {
                winner=EasyPlay();
            }
            else if (labelLevel.Text == "hard")
            {

            }

            return winner;
        }


        private String CheckForWin()
        {
            Button[] btnarray = { buttonA0, buttonA1, buttonA2, buttonB0, buttonB1, buttonB2, buttonC0, buttonC1, buttonC2 };

            String Player1 = labelP1Name.Text ;
            String Player2 = labelP2Name.Text;


            if ((btnarray[0].Text == btnarray[1].Text) && (btnarray[0].Text == btnarray[2].Text) && (btnarray[0].Text == "X"))
            {
                winner = Player1 ;
                
            }
            else if ((btnarray[0].Text == btnarray[1].Text) && (btnarray[0].Text == btnarray[2].Text) && (btnarray[0].Text == "O"))
            {
                winner = Player2;
                
            }
            else if ((btnarray[0].Text == btnarray[3].Text) && (btnarray[0].Text == btnarray[6].Text) && (btnarray[0].Text == "X"))
            {
                winner = Player1;
                
            }
            else if ((btnarray[0].Text == btnarray[3].Text) && (btnarray[0].Text == btnarray[6].Text) && (btnarray[0].Text == "O"))
            {
                winner = Player2;
                
            }
            else if ((btnarray[0].Text == btnarray[4].Text) && (btnarray[0].Text == btnarray[8].Text) && (btnarray[0].Text == "X"))
            {
                winner = Player1;
                
            }
            else if ((btnarray[0].Text == btnarray[4].Text) && (btnarray[0].Text == btnarray[8].Text) && (btnarray[0].Text == "O"))
            {
                winner = Player2;
                
            }

            else if ((btnarray[1].Text == btnarray[4].Text) && (btnarray[1].Text == btnarray[7].Text) && (btnarray[1].Text == "X"))
            {
                winner = Player1;
                
            }
            else if ((btnarray[1].Text == btnarray[4].Text) && (btnarray[1].Text == btnarray[7].Text) && (btnarray[1].Text == "O"))
            {
                winner = Player2;
                
            }

            else if ((btnarray[2].Text == btnarray[5].Text) && (btnarray[2].Text == btnarray[8].Text) && (btnarray[2].Text == "X"))
            {
                winner = Player1;
                
            }
            else if ((btnarray[2].Text == btnarray[5].Text) && (btnarray[2].Text == btnarray[8].Text) && (btnarray[2].Text == "O"))
            {
                winner = Player2;
                
            }
            else if ((btnarray[2].Text == btnarray[4].Text) && (btnarray[2].Text == btnarray[6].Text) && (btnarray[2].Text == "X"))
            {
                winner = Player1;
                
            }
            else if ((btnarray[2].Text == btnarray[4].Text) && (btnarray[2].Text == btnarray[6].Text) && (btnarray[2].Text == "O"))
            {
                winner = Player2;
                
            }

            else if ((btnarray[3].Text == btnarray[4].Text) && (btnarray[3].Text == btnarray[5].Text) && (btnarray[3].Text == "X"))
            {
                winner = Player1;
                
            }
            else if ((btnarray[3].Text == btnarray[4].Text) && (btnarray[3].Text == btnarray[5].Text) && (btnarray[3].Text == "O"))
            {
                winner = Player2;
                
            }

            else if ((btnarray[6].Text == btnarray[7].Text) && (btnarray[6].Text == btnarray[8].Text) && (btnarray[6].Text == "X"))
            {
                winner = Player1;
                
            }
            else if ((btnarray[6].Text == btnarray[7].Text) && (btnarray[6].Text == btnarray[8].Text) && (btnarray[6].Text == "O"))
            {
                winner = Player2;
                
            }



            if (winner != null)
            {
                labelTurnIndicator.Text = "Game Finished!!";
                foreach (Button i in btnarray)
                {
                    i.Enabled = false;
                }
                labelWinner.Text = winner + "  wins !!";
                if(winner==Player1){
                    Player1Win++;
                }
                else
                {
                    Player2Win++;
                }
                textBoxScore1.Text = Player1Win.ToString();
                textBoxScore2.Text = Player2Win.ToString();
                return winner;

            }
            else
                return null;


        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
            //increment the turn counter with the button click
            turnCount++;
            //check whether to display cross or circle
            if (turnCount % 2 == 1)
            {

                buttonA1.Text = "X";

            }
            else
            {
                buttonA1.Text = "O";
            }


            buttonA1.Enabled = false;
            TurnChanger(turnCount);


            //call EasyPlay if the user has selected easy mode otherwise paly hard
            if (labelMode.Text == "Single Player")
            {
                winner = CheckConditions();
            }
            else if (mode == "Two Player")
            {
                winner = CheckForWin();
            }

            labelWinner.Text = winner;
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            //increment the turn counter with the button click
            turnCount++;
            //check whether to display cross or circle
            if (turnCount % 2 == 1)
            {

                buttonA2.Text = "X";

            }
            else
            {
                buttonA2.Text = "O";
            }


            buttonA2.Enabled = false;
            TurnChanger(turnCount);


            //call EasyPlay if the user has selected easy mode otherwise paly hard
            if (labelMode.Text == "Single Player")
            {
                winner = CheckConditions();
            }
            else if (mode == "Two Player")
            {
                winner = CheckForWin();
            }

            labelWinner.Text = winner;
        }

        private void buttonB0_Click(object sender, EventArgs e)
        {
            //increment the turn counter with the button click
            turnCount++;
            //check whether to display cross or circle
            if (turnCount % 2 == 1)
            {

                buttonB0.Text = "X";

            }
            else
            {
                buttonB0.Text = "O";
            }


            buttonB0.Enabled = false;
            TurnChanger(turnCount);


            //call EasyPlay if the user has selected easy mode otherwise paly hard
            if (labelMode.Text == "Single Player")
            {
                winner = CheckConditions();
            }
            else if (mode == "Two Player")
            {
                winner = CheckForWin();
            }

            labelWinner.Text = winner;
        }

        private void buttonB1_Click(object sender, EventArgs e)
        {
            //increment the turn counter with the button click
            turnCount++;
            //check whether to display cross or circle
            if (turnCount % 2 == 1)
            {

                buttonB1.Text = "X";

            }
            else
            {
                buttonB1.Text = "O";
            }


            buttonB1.Enabled = false;
            TurnChanger(turnCount);


            //call EasyPlay if the user has selected easy mode otherwise paly hard
            if (labelMode.Text == "Single Player")
            {
                winner = CheckConditions();
            }
            else if (mode == "Two Player")
            {
                winner = CheckForWin();
            }

            labelWinner.Text = winner;
        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            //increment the turn counter with the button click
            turnCount++;
            //check whether to display cross or circle
            if (turnCount % 2 == 1)
            {

                buttonB2.Text = "X";

            }
            else
            {
                buttonB2.Text = "O";
            }


            buttonB2.Enabled = false;
            TurnChanger(turnCount);


            //call EasyPlay if the user has selected easy mode otherwise paly hard
            if (labelMode.Text == "Single Player")
            {
                winner = CheckConditions();
            }
            else if (mode == "Two Player")
            {
                winner = CheckForWin();
            }

            labelWinner.Text = winner;
        }

        private void buttonC0_Click(object sender, EventArgs e)
        {
            //increment the turn counter with the button click
            turnCount++;
            //check whether to display cross or circle
            if (turnCount % 2 == 1)
            {

                buttonC0.Text = "X";

            }
            else
            {
                buttonC0.Text = "O";
            }


            buttonC0.Enabled = false;
            TurnChanger(turnCount);


            //call EasyPlay if the user has selected easy mode otherwise paly hard
            if (labelMode.Text == "Single Player")
            {
                winner = CheckConditions();
            }
            else if (mode == "Two Player")
            {
                winner = CheckForWin();
            }

            labelWinner.Text = winner;
        }

        private void buttonC1_Click(object sender, EventArgs e)
        {
            //increment the turn counter with the button click
            turnCount++;
            //check whether to display cross or circle
            if (turnCount % 2 == 1)
            {

                buttonC1.Text = "X";

            }
            else
            {
                buttonC1.Text = "O";
            }


            buttonC1.Enabled = false;
            TurnChanger(turnCount);


            //call EasyPlay if the user has selected easy mode otherwise paly hard
            if (labelMode.Text == "Single Player")
            {
                winner = CheckConditions();
            }
            else if (mode == "Two Player")
            {
                winner = CheckForWin();
            }

            labelWinner.Text = winner;
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            //increment the turn counter with the button click
            turnCount++;
            //check whether to display cross or circle
            if (turnCount % 2 == 1)
            {

                buttonC2.Text = "X";

            }
            else
            {
                buttonC2.Text = "O";
            }


            buttonC2.Enabled = false;
            TurnChanger(turnCount);


            //call EasyPlay if the user has selected easy mode otherwise paly hard
            if (labelMode.Text == "Single Player")
            {
                winner = CheckConditions();
            }
            else if (mode == "Two Player")
            {
                winner = CheckForWin();
            }

            labelWinner.Text = winner;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            buttonA0.Enabled = true;
            buttonA1.Enabled = true;
            buttonA2.Enabled = true;
            buttonB0.Enabled = true;
            buttonB1.Enabled = true;
            buttonB2.Enabled = true;
            buttonC0.Enabled = true;
            buttonC1.Enabled = true;
            buttonC2.Enabled = true;

            buttonA0.Text = " ";
            buttonA1.Text = " ";
            buttonA2.Text = " ";
            buttonB0.Text = " ";
            buttonB1.Text = " ";
            buttonB2.Text = " ";
            buttonC0.Text = " "; 
            buttonC1.Text = " "; 
            buttonC2.Text = " ";



            turnCount=0;
            winner = null;
            labelTurnIndicator.Text = "Start The Game";
            labelWinner.Text =  "";

            

        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            
            
        }


        private String EasyPlay()
        {
            winner = CheckForWin();
            if (winner == null)
            {
                //initialize the button array for the use in this function
                Button[] btnarray = { buttonA0, buttonA1, buttonA2, buttonB0,buttonB1, buttonB2,buttonC0, buttonC1, buttonC2};


                int random = 0;
                //if game has not ended
                if (turnCount != 9)
                {
                    //select a button which is still enabled
                    while (btnarray[random].Enabled == false)
                    {
                        random = rnd.Next(0, 9);
                    }
                    //increment the turnCount and do other changes
                    turnCount++;

                    btnarray[random].Text = "O";
                    btnarray[random].Enabled = false;
                }
                //change the turn
                TurnChanger(turnCount);
                //check for a winner
                winner=CheckForWin();
            }

            return winner;


        }

        private void LoadData()
        {
            history.Visible = true;
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM history_easy";
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                history.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Clone();
                }
            }
        }

    }
}
