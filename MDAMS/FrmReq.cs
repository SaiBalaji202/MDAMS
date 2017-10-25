using MetroFramework;
using System;
using System.Windows.Forms;

namespace MDAMS
{
    public partial class FrmReq : MetroFramework.Forms.MetroForm
    {
        private readonly string _strUid;
        private readonly string _strGid;
        private readonly string _strPass;
        private readonly FrmSignup _frmSignUp;

        public FrmReq()
        {
            InitializeComponent();
            _frmSignUp = null;
        }

        public FrmReq(FrmSignup frm, string strUid, string strGid, string strPass)
        {
            InitializeComponent();
            _strUid = strUid;
            _strGid = strGid;
            _strPass = strPass;
            _frmSignUp = frm;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_frmSignUp != null)
            {
                if (!IsNull())
                {
                    LoginData loginData = new LoginData()
                    {
                        UserId = _strUid,
                        GmailId = _strGid,
                        Password = MySecurity.Md5HashPassword(_strPass),
                        Q1 = MySecurity.EncryptWithOffset(txtQ1.Text),
                        Q2 = MySecurity.EncryptWithOffset(txtQ2.Text),
                        Q3 = MySecurity.EncryptWithOffset(txtQ3.Text),
                        Ans1 = MySecurity.EncryptWithOffset(txtA1.Text),
                        Ans2 = MySecurity.EncryptWithOffset(txtA2.Text),
                        Ans3 = MySecurity.EncryptWithOffset(txtA3.Text)
                    };
                    if (LoginHelper.RegisterUser(loginData))
                    {
                        MetroMessageBox.Show(this, "Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _frmSignUp.Close();
                    }
                    else
                    {
                        var res = MetroMessageBox.Show(this, AppGlobalDatas.CurrentError + "\n\nDo you want to save the Error Message?", "Error", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error);

                        if (res == DialogResult.Yes)
                        {
                            if (!(Helper.WriteError(AppGlobalDatas.CurrentError,
                                AppGlobalDatas.CurrentErrorStackTrace.ToString())))
                            {
                                MetroMessageBox.Show(this, AppGlobalDatas.CurrentError + "\n\nTo Report this Error, Contact Admin through Contact Form", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    var res = MetroMessageBox.Show(this, AppGlobalDatas.CurrentError + "\n\nDo you want to save the Error Message?", "Error", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error);

                    if (res == DialogResult.Yes)
                    {
                        if (!(Helper.WriteError(AppGlobalDatas.CurrentError,
                            AppGlobalDatas.CurrentErrorStackTrace.ToString())))
                        {
                            MetroMessageBox.Show(this, AppGlobalDatas.CurrentError + "\n\nTo Report this Error, Contact Admin through Contact Form", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private bool IsNull()
        {
            bool flg = false;
            if (txtQ1.Text.Equals("") || txtQ2.Text.Equals("") || txtQ3.Text.Equals("") || txtA1.Text.Equals("") || txtA2.Text.Equals("") || txtA3.Text.Equals(""))
            {
                flg = true;
            }
            return flg;
        }
    }
}
