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
    public partial class VoterControl : UserControl
    {
        private User user;

        public VoterControl()
        {
            InitializeComponent();
        }

        public void GetUser(User userC)
        {
            user = userC;
        }

        private void VoteButton_Click(object sender, EventArgs e)
        {
   
        }
    }
}
