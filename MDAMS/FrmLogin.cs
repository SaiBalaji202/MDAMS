using MetroFramework;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MDAMS
{
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        #region Constructors and Load Events

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, System.EventArgs e)
        {
            btnLogin.UseCustomBackColor = true;
            btnLogin.BackColor = Color.FromArgb(102, 194, 168);
            btnCancel.UseCustomBackColor = true;
            btnCancel.BackColor = Color.FromArgb(244, 136, 141);
        }

        #endregion


        #region Validators

        private void txtUserID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MDAMS.Validate.IsValidName(txtUserID.Text))
            {
                errp.SetError(txtUserID, String.Empty);
            }
            else
            {
                errp.SetError(txtUserID, @"Invalid User Id");
                txtUserID.Text = String.Empty;
            }
        }

        private void txtPass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MDAMS.Validate.IsValidPassword(txtPass.Text))
            {
                errp.SetError(txtPass, String.Empty);
            }
            else
            {
                errp.SetError(txtPass, @"Invalid Password");
                txtPass.Text = String.Empty;
            }
        }

        #endregion

        #region Click Handlers

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (!IsNull())
            {
                if (LoginHelper.IsAuthenticated(txtUserID.Text, txtPass.Text))
                {
                    MetroMessageBox.Show(this, "Login Successfully!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Hide();
                    FrmHome frmHome = new FrmHome();
                    frmHome.Show();
                }
                else
                {
                    MetroMessageBox.Show(this, "Login Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblLinkForgotPass_Click(object sender, EventArgs e)
        {
            FrmRecPass frmRecPass = new FrmRecPass();
            frmRecPass.Show();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region User-Defined Functions

        private bool IsNull()
        {
            return (txtUserID.Text.Equals("") || txtPass.Text.Equals(""));
        }

        #endregion


    }
}
