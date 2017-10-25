namespace MDAMS
{
    class LoginData
    {
        public string UserId { get; set; }
        public string GmailId { get; set; }
        public string Password { get; set; }
        public string Q1 { get; set; }
        public string Ans1 { get; set; }
        public string Q2 { get; set; }
        public string Ans2 { get; set; }
        public string Q3 { get; set; }
        public string Ans3 { get; set; }

        public bool IsNull()
        {
            bool flg = false;
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(GmailId) || string.IsNullOrEmpty(Password) ||
                string.IsNullOrEmpty(Q1) || string.IsNullOrEmpty(Ans1) ||
                string.IsNullOrEmpty(Q2) || string.IsNullOrEmpty(Ans2) ||
                string.IsNullOrEmpty(Q3) || string.IsNullOrEmpty(Ans3))
            {
                flg = true;
            }
            return flg;
        }
    }
}