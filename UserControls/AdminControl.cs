using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eVotingSystem.UserControls
{
    public partial class AdminControl : UserControl
    {
        private User user;
        public AdminControl()
        {
            InitializeComponent();
        }

        public void GetUser(User userC)
        {
            user = userC;
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {

        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void DeleteCampaign_Click(object sender, EventArgs e)
        {

        }

        private void CreateCampaign_Click(object sender, EventArgs e)
        {

        }

        private void CreateUser_Click(object sender, EventArgs e)
        {

        }
    }
}
