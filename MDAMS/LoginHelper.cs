using System;
using System.Linq;
using System.Xml.Linq;

namespace MDAMS
{
    class LoginHelper
    {
        public static bool RegisterUser(LoginData loginData)
        {
            bool flg = true;
            try
            {
                if (!loginData.IsNull())
                {
                    var doc = new XDocument(
                        new XElement("LoginData",
                            new XElement("login_information",
                                new XElement("user_name", loginData.UserId),
                                new XElement("gmail_id", loginData.GmailId),
                                new XElement("password", loginData.Password)
                            ),
                            new XElement("recovery_information",
                                new XElement("q1", loginData.Q1),
                                new XElement("a1", loginData.Ans1),
                                new XElement("q2", loginData.Q2),
                                new XElement("a2", loginData.Ans2),
                                new XElement("q3", loginData.Q3),
                                new XElement("a3", loginData.Ans3)
                            )
                        )
                    );
                    doc.Save(AppGlobalDatas.LoginFileName);
                }
                else
                {
                    AppGlobalDatas.CurrentError = @"Some Details are Missing.  Please Fill all fields beore clicking Submit Button.";
                    AppGlobalDatas.CurrentErrorStackTrace = null;
                    flg = false;
                }

            }
            catch (Exception ex)
            {
                AppGlobalDatas.CurrentError = ex.Message;
                AppGlobalDatas.CurrentErrorStackTrace = ex;
                flg = false;
            }
            return flg;
        }

        public static bool IsAuthenticated(string strUid, string strPassword)
        {
            bool flg = true;
            try
            {
                var text = System.IO.File.ReadAllText(AppGlobalDatas.LoginFileName);
                var xmlText = XElement.Parse(text);
                var res = from login_information in xmlText.Elements("login_information")
                          select new
                          {
                              user_name = login_information.Element("user_name").Value,
                              password = login_information.Element("password").Value
                          };
                foreach (var r in res)
                {
                    if (!r.user_name.Equals(strUid) || !r.password.Equals(MySecurity.Md5HashPassword(strPassword)))
                    {
                        flg = false;
                    }
                    break;
                }
            }
            catch (Exception ex)
            {
                AppGlobalDatas.CurrentError = ex.Message;
                AppGlobalDatas.CurrentErrorStackTrace = ex;
                flg = false;
            }
            return flg;
        }

        public static string FetchGmailId()
        {
            string strGmail = string.Empty;
            try
            {
                var text = System.IO.File.ReadAllText(AppGlobalDatas.LoginFileName);
                var xmlText = XElement.Parse(text);
                var res = from login_information in xmlText.Elements("login_information")
                          select new
                          {
                              gmail_id = login_information.Element("gmail_id")?.Value
                          };
                foreach (var r in res)
                {
                    strGmail = r.gmail_id;
                    break;
                }
            }
            catch (Exception ex)
            {
                AppGlobalDatas.CurrentError = ex.Message;
                AppGlobalDatas.CurrentErrorStackTrace = ex;
            }
            return strGmail;
        }

        public static LoginQuestions FetchQuesAns()
        {
            LoginQuestions _loginQuestions = new LoginQuestions();
            try
            {
                var text = System.IO.File.ReadAllText(AppGlobalDatas.LoginFileName);
                var xmlText = XElement.Parse(text);
                var res = from recoveryInformation in xmlText.Elements("recovery_information")
                          select new
                          {
                              q1 = recoveryInformation.Element("q1")?.Value,
                              a1 = recoveryInformation.Element("a1")?.Value,
                              q2 = recoveryInformation.Element("q2")?.Value,
                              a2 = recoveryInformation.Element("a2")?.Value,
                              q3 = recoveryInformation.Element("q3")?.Value,
                              a3 = recoveryInformation.Element("a3")?.Value
                          };
                foreach (var r in res)
                {
                    _loginQuestions.Ques1 = r.q1;
                    _loginQuestions.Ques2 = r.q2;
                    _loginQuestions.Ques3 = r.q3;
                    _loginQuestions.Ans1 = r.a1;
                    _loginQuestions.Ans2 = r.a2;
                    _loginQuestions.Ans3 = r.a3;

                    break;
                }
            }
            catch (Exception ex)
            {
                AppGlobalDatas.CurrentError = ex.Message;
                AppGlobalDatas.CurrentErrorStackTrace = ex;
            }
            return _loginQuestions;
        }
    }
}
