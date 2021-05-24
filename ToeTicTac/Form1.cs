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
            foreach(Control click in panel1.Controls)
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
            }
            else if (count % 2 != 0 && turn.Text.Equals(""))
            {
                turn.Text = "O";
            }

            count++;
        }
    }
}
