using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace eVotingSystem
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private Object userRole;
        
        public MainForm(Object userRoleC)
        {
            InitializeComponent();
            userRole = userRoleC;  
        }

        public void getDetails() { }


        private void LoginForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
