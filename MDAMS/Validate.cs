using System.Text.RegularExpressions;

namespace MDAMS
{
    public class Validate
    {
        public static bool IsValidName(string strName)
        {
            bool isValid = false;
            var exp = new Regex(@"^[a-zA-Z]+[a-zA-Z ]*$");
            var m = exp.Match(strName);
            if (m.Success)
            {
                isValid = true;
            }
            return isValid;
        }

        public static bool IsValidEmail(string strEmail)
        {
            bool isValid = false;
            var exp = new Regex(@"^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$");
            var m = exp.Match(strEmail);
            if (m.Success)
            {
                isValid = true;
            }
            return isValid;
        }

        public static bool IsValidMobileNo(string strMobileNo)
        {
            bool isValid = false;
            var exp = new Regex(@"^(\d{10})$");
            var m = exp.Match(strMobileNo);
            if (m.Success)
            {
                isValid = true;
            }
            return isValid;
        }

        public static bool IsValidPassword(string strPassword)
        {
            bool isValid = strPassword.Length >= 8;
            return isValid;
        }

        public static bool ComparePasswords(string strSrcPass, string strDestPass)
        {
            bool isValid = strSrcPass.Equals(strDestPass);
            return isValid;
        }
    }
}