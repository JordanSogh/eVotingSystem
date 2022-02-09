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
        private static Voter voter = new Voter();
        private Campaign campaign = voter.getCurrentCampaign();

        public VoterControl()
        {
            InitializeComponent();
        }
        private void VoterControl_Load(object sender, EventArgs e)
        {
            PopulateCampaign();
            RenderDynamicOptions();

        }
        public void GetUser(User userC)
        {
            user = userC;
        }

        private void VoteButton_Click(object sender, EventArgs e)
        {

        }


        private void choice1Check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void choice2Check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void choice4Check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void choice3Check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void choiceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void choiceListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
           
        }

        private void RenderDynamicOptions()
        {
           
            List<string> voteOptionslist = campaign.GetCampaignVoteOptionsCampaign();

            CheckBox optionCheckbox;
            int innitialpoint = 100;
            
            int yDistanceOffset = 30;

            for (int i = 0; i < voteOptionslist.Count; i++)
            {
                optionCheckbox = new CheckBox();
                optionCheckbox.AutoSize = true;
                innitialpoint += yDistanceOffset;
                optionCheckbox.Location = new Point(670, innitialpoint);
                this.Controls.Add(optionCheckbox);
            }
            innitialpoint = 100;
            Label optionLabel;

            for (int i = 0; i < voteOptionslist.Count; i++)
            {
                optionLabel = new Label();
                optionLabel.Text = voteOptionslist[i].ToString();
                optionLabel.AutoSize = true;
                innitialpoint += yDistanceOffset;
                optionLabel.Location = new Point(690, innitialpoint);
                this.Controls.Add(optionLabel);
            }



        }

        private void PopulateCampaign()
        {
            if(campaign != null)
            {
                campaignLabel.Text = campaign.Name;


            }
            else
            {
                campaignLabel.Text = "No Current Campaign";
            }







        }

    }
    }

