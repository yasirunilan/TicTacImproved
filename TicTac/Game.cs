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
            this.ControlBox = false;
        }
        Menu menu = new Menu();
        int turnCount = 0;
        int random = 0;
        Random rnd = new Random();
        int[] numbers = new int[9];
        String winner;
        String mode;
        String level;
        int Player1Win = 0;
        int Player2Win = 0;
        History history = new History();
        String MyConnectionString = "Server=localhost;Database=tictactoe;Uid=root;Pwd=qwerty";
        MySqlCommand cmd;

        #region buttonA0Click

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
            else if (labelMode.Text == "Two Player")
            {
                labelLevel.Text = "arrived here";
                winner=winner=CheckForWin();
            }

            labelWinner.Text = winner;
            
        }

        #endregion

        #region ExitButton

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
         }

        #endregion

        #region TurnChanger

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

        #endregion

        #region CheckConditions

        private String CheckConditions()
        {
            if (labelLevel.Text == "easy")
            {
                winner=EasyPlay();
            }
            else if (labelLevel.Text == "hard")
            {
                winner = HardPlay();
            }

            return winner;
        }
        #endregion

        #region CheckForWin

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
        #endregion

        #region buttonA1Click

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
            else if (labelMode.Text == "Two Player")
            {
                winner = winner=CheckForWin();
            }

            labelWinner.Text = winner;
        }

        #endregion

        #region buttonA2Click

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
            else if (labelMode.Text == "Two Player")
            {
                winner = winner=CheckForWin();
            }

            labelWinner.Text = winner;
        }

        #endregion

        #region buttonB0Click

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
            else if (labelMode.Text == "Two Player")
            {
                winner = winner=CheckForWin();
            }

            labelWinner.Text = winner;
        }
        #endregion

        #region buttonB1Click

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
            else if (labelMode.Text == "Two Player")
            {
                winner = winner=CheckForWin();
            }

            labelWinner.Text = winner;
        }
        #endregion

        #region buttonB2Click

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
            else if (labelMode.Text == "Two Player")
            {
                winner = winner=CheckForWin();
            }

            labelWinner.Text = winner;
        }
        #endregion


        #region buttonC0Click

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
            else if (labelMode.Text == "Two Player")
            {
                winner = winner=CheckForWin();
            }

            labelWinner.Text = winner;
        }
        #endregion

        #region buttonC1Click

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
            else if (labelMode.Text == "Two Player")
            {
                winner = winner=CheckForWin();
            }

            labelWinner.Text = winner;
        }
        #endregion

        #region buttonC2Click

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
            else if (labelMode.Text == "Two Player")
            {
                winner = winner=CheckForWin();
            }

            labelWinner.Text = winner;
        }

        #endregion

        #region NewButton

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

        #endregion

        #region HistoryButton

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            
            if (labelLevel.Text=="easy")
            {
                history.Visible = true;
                LoadEasyData();

            }
            else if (labelLevel.Text == "hard")
            {
                history.Visible = true;
                LoadHardData();
            }
            else
            {
                MessageBox.Show("This feature is not availabe for two player mode", "History");
            }
            
        }

        #endregion

        #region EasyPlay

        private String EasyPlay()
        {
            winner = CheckForWin();
            if (winner == null)
            {
                //initialize the button array for the use in this function
                Button[] btnarray = { buttonA0, buttonA1, buttonA2, buttonB0,buttonB1, buttonB2,buttonC0, buttonC1, buttonC2};


                
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
                winner = CheckForWin();
            }

            return winner;


        }

        #endregion

        #region LoadEasyData

        private void LoadEasyData()
        {
            
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM easy";
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

        #endregion

        #region LoadHardData

        private void LoadHardData()
        {
            history.Visible = true;
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM hard";
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

        #endregion



        #region HardPlay
        private String HardPlay()
        {
            
            winner = CheckForWin();
            
            if (winner == null)
            {
                
                Button[] btnarray = { buttonA0, buttonA1, buttonA2, buttonB0, buttonB1, buttonB2, buttonC0, buttonC1, buttonC2 };


                if (turnCount != 9)
                {
                    turnCount++;

                    if (btnarray[0].Text == "O" && btnarray[1].Text == "O" && btnarray[2].Text == "")
                    {
                        
                         btnarray[2].Text = "O";
                         btnarray[2].Enabled = false;
                         

                        
                    }

                    else if (btnarray[1].Text == "O" && btnarray[2].Text == "O" && btnarray[0].Text == "")
                    {
                        btnarray[0].Text = "O";
                        btnarray[0].Enabled = false;
                        
                    }

                    else if (btnarray[0].Text == "O" && btnarray[2].Text == "O" && btnarray[1].Text == "")
                    {
                        btnarray[1].Text = "O";
                        btnarray[1].Enabled = false;
                        
                    }

                    else if (btnarray[0].Text == "O" && btnarray[6].Text == "O" && btnarray[3].Text == "")
                    {
                        btnarray[3].Text = "O";
                        btnarray[3].Enabled = false;
                        
                    }

                    else if (btnarray[0].Text == "O" && btnarray[3].Text == "O" && btnarray[6].Text == "")
                    {
                        btnarray[6].Text = "O";
                        btnarray[6].Enabled = false;
                        

                    }

                    else if (btnarray[3].Text == "O" && btnarray[6].Text == "O" && btnarray[0].Text == "")
                    {
                        btnarray[0].Text = "O";
                        btnarray[0].Enabled = false;
                        

                    }

                    else if (btnarray[0].Text == "O" && btnarray[4].Text == "O" && btnarray[8].Text == "")
                    {
                        btnarray[8].Text = "O";
                        btnarray[8].Enabled = false;
                        

                    }

                    else if (btnarray[4].Text == "O" && btnarray[8].Text == "O" && btnarray[0].Text == "")
                    {
                        btnarray[0].Text = "O";
                        btnarray[0].Enabled = false;
                        

                    }

                    else if (btnarray[0].Text == "O" && btnarray[8].Text == "O" && btnarray[4].Text == "")
                    {
                        btnarray[4].Text = "O";
                        btnarray[4].Enabled = false;
                        

                    }

                    else if (btnarray[1].Text == "O" && btnarray[4].Text == "O" && btnarray[7].Text == "")
                    {
                        btnarray[7].Text = "O";
                        btnarray[7].Enabled = false;
                        

                    }

                    else if (btnarray[1].Text == "O" && btnarray[7].Text == "O" && btnarray[4].Text == "")
                    {
                        btnarray[4].Text = "O";
                        btnarray[4].Enabled = false;
                        

                    }

                    else if (btnarray[4].Text == "O" && btnarray[7].Text == "O" && btnarray[1].Text == "")
                    {
                        btnarray[1].Text = "O";
                        btnarray[1].Enabled = false;
                        

                    }

                    else if (btnarray[2].Text == "O" && btnarray[5].Text == "O" && btnarray[8].Text == "")
                    {
                        btnarray[8].Text = "O";
                        btnarray[8].Enabled = false;
                        

                    }

                    

                    else if (btnarray[2].Text == "O" && btnarray[8].Text == "O" && btnarray[5].Text == "")
                    {
                        btnarray[5].Text = "O";
                        btnarray[5].Enabled = false;
                        

                    }

                    else if (btnarray[5].Text == "O" && btnarray[8].Text == "O" && btnarray[2].Text == "")
                    {
                        btnarray[2].Text = "O";
                        btnarray[2].Enabled = false;
                        

                    }

                    else if (btnarray[3].Text == "O" && btnarray[4].Text == "O" && btnarray[5].Text == "")
                    {
                        btnarray[5].Text = "O";
                        btnarray[5].Enabled = false;
                        
                    }

                    else if (btnarray[3].Text == "O" && btnarray[5].Text == "O" && btnarray[4].Text == "")
                    {
                        btnarray[4].Text = "O";
                        btnarray[4].Enabled = false;
                        

                    }

                    else if (btnarray[4].Text == "O" && btnarray[5].Text == "O" && btnarray[3].Text == "")
                    {
                        btnarray[3].Text = "O";
                        btnarray[3].Enabled = false;
                        
                    }

                    else if (btnarray[6].Text == "O" && btnarray[8].Text == "O" && btnarray[7].Text == "")
                    {
                        btnarray[7].Text = "O";
                        btnarray[7].Enabled = false;
                        
                    }

                    else if (btnarray[7].Text == "O" && btnarray[8].Text == "O" && btnarray[6].Text == "")
                    {
                        btnarray[6].Text = "O";
                        btnarray[6].Enabled = false;
                        
                    }

                    else if (btnarray[6].Text == "O" && btnarray[7].Text == "O" && btnarray[8].Text == "")
                    {
                        btnarray[8].Text = "O";
                        btnarray[8].Enabled = false;
                        
                    }

                    else if (btnarray[2].Text == "O" && btnarray[4].Text == "O" && btnarray[6].Text == "")
                    {
                        btnarray[6].Text = "O";
                        btnarray[6].Enabled = false;
                        
                    }

                    else if (btnarray[4].Text == "O" && btnarray[6].Text == "O" && btnarray[2].Text == "")
                    {
                        btnarray[2].Text = "O";
                        btnarray[2].Enabled = false;
                        
                    }

                    else if (btnarray[2].Text == "O" && btnarray[6].Text == "O" && btnarray[4].Text == "")
                    {
                        btnarray[4].Text = "O";
                        btnarray[4].Enabled = false;
                        
                    }



                    else if (btnarray[4].Text == "")
                    {
                        
                        btnarray[4].Text = "O";
                        btnarray[4].Enabled = false;
                       

                    }

                    else if (btnarray[0].Text == "X" && btnarray[1].Text == "X" && btnarray[2].Text == "")
                    {
                        btnarray[2].Text = "O";
                        btnarray[2].Enabled = false;
                        
                    }
                    else if (btnarray[0].Text == "X" && btnarray[2].Text == "X" && btnarray[1].Text == "")
                    {
                        btnarray[1].Text = "O";
                        btnarray[1].Enabled = false;

                    }
                    else if (btnarray[1].Text == "X" && btnarray[2].Text == "X" && btnarray[0].Text == "")
                    {
                        btnarray[0].Text = "O";
                        btnarray[0].Enabled = false;

                    }
                    else if (btnarray[0].Text == "X" && btnarray[3].Text == "X" && btnarray[6].Text == "")
                    {
                        btnarray[6].Text = "O";
                        btnarray[6].Enabled = false;

                    }
                    else if (btnarray[0].Text == "X" && btnarray[6].Text == "X" && btnarray[3].Text == "")
                    {
                        btnarray[3].Text = "O";
                        btnarray[3].Enabled = false;

                    }
                    else if (btnarray[6].Text == "X" && btnarray[3].Text == "X" && btnarray[0].Text == "")
                    {
                        btnarray[0].Text = "O";
                        btnarray[0].Enabled = false;

                    }
                    else if (btnarray[6].Text == "X" && btnarray[7].Text == "X" && btnarray[8].Text == "")
                    {
                        btnarray[8].Text = "O";
                        btnarray[8].Enabled = false;

                    }
                    else if (btnarray[6].Text == "X" && btnarray[8].Text == "X" && btnarray[7].Text == "")
                    {
                        btnarray[7].Text = "O";
                        btnarray[7].Enabled = false;

                    }
                    else if (btnarray[7].Text == "X" && btnarray[8].Text == "X" && btnarray[6].Text == "")
                    {
                        btnarray[6].Text = "O";
                        btnarray[6].Enabled = false;

                    }
                    else if (btnarray[2].Text == "X" && btnarray[5].Text == "X" && btnarray[8].Text == "")
                    {
                        btnarray[8].Text = "O";
                        btnarray[8].Enabled = false;

                    }
                    else if (btnarray[2].Text == "X" && btnarray[8].Text == "X" && btnarray[5].Text == "")
                    {
                        btnarray[5].Text = "O";
                        btnarray[5].Enabled = false;

                    }
                    else if (btnarray[5].Text == "X" && btnarray[8].Text == "X" && btnarray[2].Text == "")
                    {
                        btnarray[2].Text = "O";
                        btnarray[2].Enabled = false;

                    }
                    else if (btnarray[0].Text == "X" && btnarray[4].Text == "X" && btnarray[8].Text == "")
                    {
                        btnarray[8].Text = "O";
                        btnarray[8].Enabled = false;

                    }
                    else if (btnarray[0].Text == "X" && btnarray[8].Text == "X" && btnarray[4].Text == "")
                    {
                        btnarray[4].Text = "O";
                        btnarray[4].Enabled = false;

                    }
                    else if (btnarray[8].Text == "X" && btnarray[4].Text == "X" && btnarray[0].Text == "")
                    {
                        btnarray[0].Text = "O";
                        btnarray[0].Enabled = false;

                    }
                    else if (btnarray[2].Text == "X" && btnarray[4].Text == "X" && btnarray[6].Text == "")
                    {
                        btnarray[6].Text = "O";
                        btnarray[6].Enabled = false;

                    }
                    else if (btnarray[2].Text == "X" && btnarray[6].Text == "X" && btnarray[4].Text == "")
                    {
                        btnarray[4].Text = "O";
                        btnarray[4].Enabled = false;

                    }
                    else if (btnarray[6].Text == "X" && btnarray[4].Text == "X" && btnarray[2].Text == "")
                    {
                        btnarray[2].Text = "O";
                        btnarray[2].Enabled = false;

                    }
                    else if (btnarray[1].Text == "X" && btnarray[4].Text == "X" && btnarray[7].Text == "")
                    {
                        btnarray[7].Text = "O";
                        btnarray[7].Enabled = false;

                    }
                    else if (btnarray[1].Text == "X" && btnarray[7].Text == "X" && btnarray[4].Text == "")
                    {
                        btnarray[4].Text = "O";
                        btnarray[4].Enabled = false;

                    }
                    else if (btnarray[4].Text == "X" && btnarray[7].Text == "X" && btnarray[1].Text == "")
                    {
                        btnarray[1].Text = "O";
                        btnarray[1].Enabled = false;

                    }
                    else if (btnarray[3].Text == "X" && btnarray[4].Text == "X" && btnarray[5].Text == "")
                    {
                        btnarray[5].Text = "O";
                        btnarray[5].Enabled = false;

                    }
                    else if (btnarray[3].Text == "X" && btnarray[5].Text == "X" && btnarray[4].Text == "")
                    {
                        btnarray[4].Text = "O";
                        btnarray[4].Enabled = false;

                    }
                    else if (btnarray[4].Text == "X" && btnarray[5].Text == "X" && btnarray[3].Text == "")
                    {
                        btnarray[3].Text = "O";
                        btnarray[3].Enabled = false;

                    }
                    else
                    {
                        //select a button which is still enabled
                        while (btnarray[random].Enabled == false)
                        {
                            random = rnd.Next(0, 9);
                        }
                        

                        btnarray[random].Text = "O";
                        btnarray[random].Enabled = false;
                    

                    }
                    
                    winner = CheckForWin();
                    
                    
                }
                //change the turn
                TurnChanger(turnCount);
                
                
                
            }
            return winner;
        }

        #endregion

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String GameWinner = labelP1Name.Text;
            int Player1Score = Player1Win;
            int Player2Score = Player2Win;
            mode = labelMode.Text;
            level = labelLevel.Text;
            int Score = Player1Win - Player2Win;


            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            try {
                cmd = new MySqlCommand("select min(score) from easy", connection);
                int existingScore = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (Score > existingScore)
                {
                    if (level == "easy")
                    {
                        try
                        {
                            cmd = connection.CreateCommand();
                            cmd.CommandText = "INSERT INTO easy(score,name) VALUES(@score,@name)";
                            cmd.Parameters.AddWithValue("@score", Score);
                            cmd.Parameters.AddWithValue("@name", GameWinner);


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
                                //LoadData();
                            }
                        }
                    }
                    else if (level == "hard")
                    {
                        try
                        {
                            cmd = connection.CreateCommand();
                            cmd.CommandText = "INSERT INTO hard(score,name) VALUES(@score,@name)";
                            cmd.Parameters.AddWithValue("@score", Score);
                            cmd.Parameters.AddWithValue("@name", GameWinner);


                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                    }
                    

                    
                }
            }
            finally {
                connection.Close();
    }



          }
            
        
    }
}
