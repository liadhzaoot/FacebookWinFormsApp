using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class PostUC : UserControl
    {
         
        public PostUC()
        {
            InitializeComponent();
        }

        private void PostUC_Load(object sender, EventArgs e)
        {

        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        private void postLable_Click(object sender, EventArgs e)
        {

        }
        public void SetLableText(string i_Text)
        {
            this.postLable.Text = i_Text;
        }

    }
}
