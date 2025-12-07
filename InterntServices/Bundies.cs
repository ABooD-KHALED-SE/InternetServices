using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterntServices
{
    public partial class bundies : Form
    {
        public bundies()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            meesageAndCallsBundies meesageAndCallsBundiesIns = new meesageAndCallsBundies();
            meesageAndCallsBundiesIns.Show();
        }

        private void Bundies_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            mainPage mainPageIns = new mainPage();
            mainPageIns.Show();
        }

        private void btIntrnetBundies_Click(object sender, EventArgs e)
        {
            internetBundies internetBundiesIns = new internetBundies();
            internetBundiesIns.Show();
        }

        private void btMaxBundies_Click(object sender, EventArgs e)
        {
            maxBundies maxBundiesIns = new maxBundies();
            maxBundiesIns.Show();
        }

        private void btSoaBundies_Click(object sender, EventArgs e)
        {
            soaBundies soaBundiesIns = new soaBundies();
            soaBundiesIns.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            overBundies overBundiesIns = new overBundies();
            overBundiesIns.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            transfire trasfiresIns = new transfire();
            trasfiresIns.Show();
        }
    }
}
