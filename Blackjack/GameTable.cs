using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class GameTable : Form
    {
        public GameTable()
        {
            InitializeComponent();
            dealer Dealer = new dealer(1);

            int[] index = Dealer.shuffle();

            StringBuilder show = new StringBuilder();
            //foreach (card c in Dealer.deck)
            //{
            //    show.AppendLine(c.face + " of " + c.suit + " value:" + c.value + " index:" + c.index);
            //}
            foreach (int i in index)
            {
                show.AppendLine(index[i].ToString());
            }

            label1.Text = show.ToString();
        }
    }
}
