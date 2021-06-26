using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeTicTac
{
    class myClass
    {
        public int count = 0;
        public string Turn = "";
        public bool win = false;

        public void Turns()
        {
            if (count % 2 == 0 && Turn.Equals(""))
            {
                Turn = "X";
                count++;

            }
            else if (count % 2 != 0 && Turn.Equals(""))
            {
                Turn = "O";
                count++;

            }
        }

    }
}
