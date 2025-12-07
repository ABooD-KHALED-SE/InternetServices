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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }



        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {  
             
             loginForm loginFormIns = new loginForm();
             loginFormIns.Close();
             mainPage mainPageIns = new mainPage();
             mainPageIns.Show();
            //to hide loginForm form

        }
    }
}
