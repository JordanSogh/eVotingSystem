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
    public partial class AuditorControl : UserControl
    {
        private User user;

        public AuditorControl()
        {
            InitializeComponent();
        }
        public void GetUser(User userC)
        {
            user = userC;
        }
    }
}
