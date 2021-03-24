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
            dealer Dealer = new dealer();
            Dealer.deck = Dealer.buildDeck(1);

            StringBuilder show = new StringBuilder();
            foreach (card c in Dealer.deck)
            {
                show.AppendLine(c.face + " of " + c.suit + "value:" + c.value + " index:" + c.index);
            }
            label1.Text = show.ToString();
        }
    }
}
