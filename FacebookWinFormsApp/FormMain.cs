using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }
        User m_LoggedInUser;
        LoginResult m_LoginResult;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            FacebookWrapper.LoginResult m_LoginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "1644533879244605", 
                    /// requested permissions:
					"email",
                    "public_profile"
                    /// add any relevant permissions
                    );

            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
		}

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void postFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<20;i++)
            {
                PostUC postUC = new PostUC();
                if (m_LoggedInUser.Posts[i].Message != null)
                {
                    postUC.SetLableText(m_LoggedInUser.Posts[i].Message);
                    this.postFlowLayoutPanel.Controls.Add(postUC);
                }

                //else if (post.Caption != null)
                //{
                //    listBoxPosts.Items.Add(post.Caption);
                //}
                //else
                //{
                //    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                //}
            }
            this.postFlowLayoutPanel.AutoScroll = true;

        }
    }
}
