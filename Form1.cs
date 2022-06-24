using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE_GAME
{
    public partial class TICTACTOE : Form
    {
        public TICTACTOE()
        {
            InitializeComponent();
        }

        public int player = 2; // even = X turn; odd = O turn;
        public int turns; // counting turns;

        private void Button_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (B.Text == "")
            {
                if (player % 2 == 0)
                {
                    B.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    B.Text = "O";
                    player++;
                    turns++;
                }

      
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void NewGame()
        {
            player = 2;
            turns = 0;
            Button1.Text = Button2.Text = Button3.Text = Button4.Text = Button5.Text = Button6.Text = Button7.Text = Button8.Text = Button9.Text = "";

        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}




