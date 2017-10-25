using System;
using System.Drawing;

namespace MDAMS
{
    public partial class FrmSignup : MetroFramework.Forms.MetroForm
    {
        public FrmSignup()
        {
            InitializeComponent();
        }

        private void FrmSignup_Load(object sender, System.EventArgs e)
        {
            btnRegister.UseCustomBackColor = true;
            btnRegister.BackColor = Color.FromArgb(102, 194, 168);
            btnCancel.UseCustomBackColor = true;
            btnCancel.BackColor = Color.FromArgb(244, 136, 141);
        }

        #region Click Event Handlers

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            if (!IsNull())
            {
                var req = new FrmReq(this, txtUserID.Text, txtGmailID.Text, txtPass.Text);
                req.Show();
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Validating Events

        private void txtUserID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!MDAMS.Validate.IsValidName(txtUserID.Text))
            {
                errp.SetError(txtUserID, "Invalid User ID");
            }
            else
            {
                errp.SetError(txtUserID, String.Empty);
                errpc.SetError(txtUserID, "Valid User ID");
            }
        }

        private void txtGmailID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!MDAMS.Validate.IsValidEmail(txtGmailID.Text))
            {
                errp.SetError(txtGmailID, "Invalid Email ID");
            }
            else
            {
                errp.SetError(txtGmailID, String.Empty);
                errpc.SetError(txtGmailID, "Valid Email ID");
            }
        }

        private void txtPass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!MDAMS.Validate.IsValidPassword(txtPass.Text))
            {
                errp.SetError(txtPass, "Invalid Password.  Your Password should have Minimum 8 characters.");
            }
            else
            {
                errp.SetError(txtPass, String.Empty);
                errpc.SetError(txtPass, "Valid Password");
            }
        }

        private void txtRePass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!MDAMS.Validate.ComparePasswords(txtPass.Text, txtRePass.Text))
            {
                errp.SetError(txtRePass, "Password didn't match");
            }
            else
            {
                errp.SetError(txtRePass, String.Empty);
                errpc.SetError(txtRePass, "Password Match");
            }
        }

        #endregion        

        private bool IsNull()
        {
            bool flg = false;
            if (txtGmailID.Text.Equals("") || txtPass.Text.Equals("") || txtRePass.Text.Equals("") || txtUserID.Text.Equals(""))
            {
                flg = true;
            }
            return flg;
        }
    }
}
