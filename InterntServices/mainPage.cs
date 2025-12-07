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
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            overBundies overBundiesIns = new overBundies();
            overBundiesIns.Show();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            //هنا اوامر التي بتحدث البيانات تلقئيا
        }

        private void btMainPage_Click(object sender, EventArgs e)
        { 

            mainPage mainPageIns = new mainPage();
            
            mainPageIns.Show();
           
            
        }

        private void btBundies_Click(object sender, EventArgs e)
        {
            bundies bundiesIns = new bundies();
            bundiesIns.Show();

        }

        private void btTransifier_Click(object sender, EventArgs e)
        {
            transfire trasfiresIns = new transfire();
            trasfiresIns.Show();
        }
    }
}
