using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiseDue0125__6
{
    public partial class Form1 : Form
    {
        private string[] states;
        private string[] results;
        int playerChoice;
        int computerChoice;
        Random rd;
        

        public Form1()
        {
            InitializeComponent();
            states = new string[3] { "剪刀", "石头", "布" };
            results = new string[3] { "平手", "电脑赢", "玩家赢" };
         }

        private void button1_Click(object sender, EventArgs e)
        {
            playerChoice = 0;
            play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerChoice = 1;
            play();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerChoice = 2;
            play();
        }
        private void play()
        {
            player.Text = states[playerChoice];
            rd = new Random();
            computerChoice = rd.Next() % 3;
            computer .Text = states[computerChoice];
            compare.Text = results[(computerChoice - playerChoice+3) % 3];
        }
    }
}
