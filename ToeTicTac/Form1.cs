using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToeTicTac
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            foreach (Control click in panel1.Controls)
            {
                if(click is Button)
                {
                    click.Click += new System.EventHandler(turn_Click);
                }
            }
        }

        int count = 0;

        public void turn_Click(object sender, EventArgs e)
        {
            Button turn = (Button)sender;
            if (count % 2 == 0 && turn.Text.Equals(""))
            {
                turn.Text = "X";
                checkwin();
            }
            else if (count % 2 != 0 && turn.Text.Equals(""))
            {
                turn.Text = "O";
                checkwin();
            }

            count++;
        }

        bool win = false;

        public void checkwin()
        {
            if (!button1.Text.Equals("") && button1.Text.Equals(button2.Text) && button1.Text.Equals(button3.Text))
            {
                winning(button1, button2, button3);
                DialogResult dialogResult = MessageBox.Show("Winner Winner Chicken Dinner! \nPlay again?", "You Win!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    count = 0;
                    Application.Restart();
                }
                if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
                win = true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button5.Text) && button1.Text.Equals(button9.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Winner Winner Chicken Dinner! \nPlay again?", "You Win!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    count = 0;
                    Application.Restart();
                }
                if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
                win = true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button4.Text) && button1.Text.Equals(button7.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Winner Winner Chicken Dinner! \nPlay again?", "You Win!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    count = 0;
                    Application.Restart();
                }
                if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
                win = true;
            }
            if (!button2.Text.Equals("") && button2.Text.Equals(button5.Text) && button2.Text.Equals(button8.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Winner Winner Chicken Dinner! \nPlay again?", "You Win!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    count = 0;
                    Application.Restart();
                }
                if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
                win = true;
            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button6.Text) && button3.Text.Equals(button9.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Winner Winner Chicken Dinner! \nPlay again?", "You Win!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    count = 0;
                    Application.Restart();
                }
                if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
                win = true;
            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button5.Text) && button3.Text.Equals(button7.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Winner Winner Chicken Dinner! \nPlay again?", "You Win!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    count = 0;
                    Application.Restart();
                }
                if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
                win = true;
            }
            if (!button4.Text.Equals("") && button4.Text.Equals(button5.Text) && button4.Text.Equals(button6.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Winner Winner Chicken Dinner! \nPlay again?", "You Win!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    count = 0;
                    Application.Restart();
                }
                if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
                win = true;
            }
            if (!button7.Text.Equals("") && button7.Text.Equals(button8.Text) && button7.Text.Equals(button9))
            {
                DialogResult dialogResult = MessageBox.Show("Winner Winner Chicken Dinner! \nPlay again?", "You Win!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    count = 0;
                    Application.Restart();
                }
                if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
                win = true;
            }
            if (NumOfTurns() == 9 && win == false)
            {
                DialogResult dialogResult = MessageBox.Show("Do it again and do it better! \nPlay again?", "It's a Draw!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    count = 0;
                    Application.Restart();
                }
                if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        public int NumOfTurns()
        {
            int NumberOfTurns = 0;
            foreach(Control click in panel1.Controls)
            {
                if(click is Button)
                {
                    NumberOfTurns += click.Text.Length;
                }
            }
            return NumberOfTurns;
        }

        public void winning(Button one, Button two, Button three)
        {
            one.BackColor = Color.Green;
            two.BackColor = Color.Green;
            three.BackColor = Color.Green;
        }

    }
}
