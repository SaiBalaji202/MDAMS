using MetroFramework;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MDAMS
{
    public partial class FrmRecPass : MetroFramework.Forms.MetroForm
    {
        private string strAns1, strAns2, strAns3;
        public FrmRecPass()
        {
            InitializeComponent();
        }

        private void FrmRecPass_Load(object sender, EventArgs e)
        {
            btnValidateEmail.UseCustomBackColor = true;
            btnValidateEmail.BackColor = Color.FromArgb(102, 194, 168);
            btnValidateAnswer.UseCustomBackColor = true;
            btnValidateAnswer.BackColor = Color.FromArgb(102, 194, 168);
            pnlQues.Visible = false;
        }

        private void txtGmailID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MDAMS.Validate.IsValidEmail(txtGmailID.Text))
            {
                errp.SetError(txtGmailID, string.Empty);
            }
            else
            {
                errp.SetError(txtGmailID, @"Invalid Email Id");
                txtGmailID.Text = String.Empty;
            }
        }

        private void btnValidateAnswer_Click(object sender, EventArgs e)
        {
            if (strAns1.Equals(txtA1.Text) && strAns2.Equals(txtA2.Text) && strAns3.Equals(txtA3.Text))
            {
                MetroMessageBox.Show(this, "Correct Answers!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FrmSignup frmSignup = new FrmSignup();
                frmSignup.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong Answers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnValidateEmail_Click(object sender, EventArgs e)
        {
            string strOriginalGmail = LoginHelper.FetchGmailId();
            if (strOriginalGmail.Equals(txtGmailID.Text))
            {

                pnlQues.Visible = true;
                LoadQuestions();
                errp.SetError(txtGmailID, string.Empty);
            }
            else
            {
                pnlQues.Visible = false;
                txtGmailID.Text = string.Empty;
                MetroMessageBox.Show(this, "Invalid Email Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errp.SetError(txtGmailID, @"Invalid Email Id");
            }
        }

        private void LoadQuestions()
        {
            LoginQuestions loginQuestions = LoginHelper.FetchQuesAns();
            lblQ1.Text = MySecurity.DecryptWithOffset(loginQuestions.Ques1);
            lblQ2.Text = MySecurity.DecryptWithOffset(loginQuestions.Ques2);
            lblQ3.Text = MySecurity.DecryptWithOffset(loginQuestions.Ques3);
            strAns1 = MySecurity.DecryptWithOffset(loginQuestions.Ans1);
            strAns2 = MySecurity.DecryptWithOffset(loginQuestions.Ans2);
            strAns3 = MySecurity.DecryptWithOffset(loginQuestions.Ans3);
        }
    }
}
