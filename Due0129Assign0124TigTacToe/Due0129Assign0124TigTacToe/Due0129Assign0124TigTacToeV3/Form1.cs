using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Due0129Assign0124TigTacToeV3
{
    public partial class Form1 : Form
    {
        private int[] cardInt = new int[9];
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 9; i++)
            {
                this.cardInt[i] = 4;
            }
        }

        private void btns(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int index = (int)(b.Name[6]);
            if (cardInt[index - 1 - 48] == 4)
            {
                count++;
                if (count % 2 == 1)
                {
                    b.Text = "X";
                    cardInt[index - 1 - 48] = 1;
                    if (((cardInt[0] + cardInt[1] + cardInt[2]) == 3) || ((cardInt[3] + cardInt[4] + cardInt[5]) == 3) || ((cardInt[6] + cardInt[7] + cardInt[8]) == 3) || ((cardInt[0] + cardInt[3] + cardInt[6]) == 3) || ((cardInt[1] + cardInt[4] + cardInt[7]) == 3) || ((cardInt[2] + cardInt[5] + cardInt[8]) == 3) || ((cardInt[0] + cardInt[4] + cardInt[8]) == 3) || ((cardInt[2] + cardInt[4] + cardInt[6]) == 3))
                    { label1.Text = "Player1 Win"; }
                }
                else
                {
                    b.Text = "O";
                    cardInt[index - 1 - 48] = 0;
                    if (((cardInt[0] + cardInt[1] + cardInt[2]) == 0) || ((cardInt[3] + cardInt[4] + cardInt[5]) == 0) || ((cardInt[6] + cardInt[7] + cardInt[8]) == 0) || ((cardInt[0] + cardInt[3] + cardInt[6]) == 0) || ((cardInt[1] + cardInt[4] + cardInt[7]) == 0) || ((cardInt[2] + cardInt[5] + cardInt[8]) == 0) || ((cardInt[0] + cardInt[4] + cardInt[8]) == 0) || ((cardInt[2] + cardInt[4] + cardInt[6]) == 0))
                    { label1.Text = "Player2 Win"; }
                }
                if (count == 9 && label1.Text == "") label1.Text = "None Win";

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            count = 0;
            for (int i = 0; i < 9; i++)
            {
                cardInt[i] = 4;
                
            }
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
    }
}
