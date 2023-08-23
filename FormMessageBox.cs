using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace EvaNew
{
    public enum ButtonDetail
    {
        AcceptOnly,
        DeclineOnly,
        BothAcceptAndDecline,
    }

    public partial class FormMessageBox : MetroForm
    {
        public FormMessageBox()
        {
            InitializeComponent();
            SetLanguage();
        }

        public void SetLanguage()
        {
            Text = "Info";
            mBtnYes.Text = "Yes";
            mBtnNo.Text = "No";
        }

        private void mBtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void mBtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void FormMessageBox_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (DialogResult.Yes != DialogResult && DialogResult.No != DialogResult) DialogResult = DialogResult.Cancel;
        }

        public DialogResult ShowBox(string headTxt, string msgTxt)
        {
            mLblMsg.Text = msgTxt;
            Text = headTxt;
            Style = MetroColorStyle.Red;
            return ShowDialog();
        }

        private void FormMessageBox_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}
