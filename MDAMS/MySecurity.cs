using System;
using System.Security.Cryptography;
using System.Text;

namespace MDAMS
{
    class MySecurity
    {
        /// <summary>
        /// Compute MD5 Hash for Password you pass
        /// </summary>
        /// <param name="strPassword"></param>
        /// <returns></returns>
        public static string Md5HashPassword(string strPassword)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();

            string strHash = string.Empty;

            try
            {
                var bytesHash = md5Hasher.ComputeHash(encoder.GetBytes(strPassword));
                strHash = Convert.ToBase64String(bytesHash);
            }
            catch (Exception ex)
            {
                AppGlobalDatas.CurrentError = ex.Message;
                AppGlobalDatas.CurrentErrorStackTrace = ex;
            }
            return strHash;
        }

        /// <summary>
        ///     Compare Two Password
        /// </summary>
        /// <param name="strOriginalPass">Original Hashed Password</param>
        /// <param name="strPassToCompare">Hashed Password Entered by the User</param>
        /// <returns></returns>
        public static bool ComparePasswords(string strOriginalPass, string strPassToCompare)
        {
            return strPassToCompare.Equals(strOriginalPass);
        }

        /// <summary>
        /// Encrypt Using Offset Cipher
        /// </summary>
        /// <param name="strTextToEnc"></param>
        /// <returns></returns>
        public static string EncryptWithOffset(string strTextToEnc)
        {
            string strEnc = String.Empty;
            try
            {
                byte[] bytes = Encoding.Unicode.GetBytes(strTextToEnc);

                int count = 0;
                foreach (byte b in bytes)
                {
                    bytes[count++] = (byte)(b + AppGlobalDatas.Offset);
                }
                strEnc = Encoding.Unicode.GetString(bytes);
            }
            catch (Exception exception)
            {
                AppGlobalDatas.CurrentError = exception.Message;
                AppGlobalDatas.CurrentErrorStackTrace = exception;
            }
            return strEnc;
        }

        /// <summary>
        /// Decrypt Using Offset Cipher
        /// </summary>
        /// <param name="strTextToDec"></param>
        /// <returns></returns>
        public static string DecryptWithOffset(string strTextToDec)
        {
            string strDec = String.Empty;
            try
            {
                byte[] bytes = Encoding.Unicode.GetBytes(strTextToDec);

                int count = 0;
                foreach (byte b in bytes)
                {
                    bytes[count++] = (byte)(b - AppGlobalDatas.Offset);
                }
                strDec = Encoding.Unicode.GetString(bytes);
            }
            catch (Exception exception)
            {
                AppGlobalDatas.CurrentError = exception.Message;
                AppGlobalDatas.CurrentErrorStackTrace = exception;
            }
            return strDec;
        }

    }
}