using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameEngine;

namespace GameForm
{
    public partial class Form1 : Form
    {
        GameEngine.GameEngine gameEngine;

        public Form1()
        {
            InitializeComponent();

            this.gameEngine = new GameEngine.GameEngine();
            this.NewGame();
        }

        private void NewGame()
        {
            this.gameEngine.NewGame();

            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;

            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";

            this.label1.Text = this.gameEngine.GetCurrentPlayer().GetName();
            this.label2.Text = "";
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NewGame();
        }

        private void MakeAStep(int x, int y, Button button)
        {
            Player player = this.gameEngine.GetCurrentPlayer();
            if (!this.gameEngine.MakeAStep(x, y))
            {
                throw new Exception("Error MakeAStep");
            }
            button.Text = player.GetToken();
            button.Enabled = false;

            if (this.gameEngine.IsWin())
            {
                player = this.gameEngine.GetWinPlayer();
                this.label2.Text = player.GetName();
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }

            player = this.gameEngine.GetCurrentPlayer();
            this.label1.Text = player.GetName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MakeAStep(0, 0, this.button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MakeAStep(0, 1, this.button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.MakeAStep(0, 2, this.button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.MakeAStep(1, 0, this.button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.MakeAStep(1, 1, this.button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.MakeAStep(1, 2, this.button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.MakeAStep(2, 0, this.button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.MakeAStep(2, 1, this.button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.MakeAStep(2, 2, this.button9);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
