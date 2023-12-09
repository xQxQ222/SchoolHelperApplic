namespace WinFormsApp1
{
    internal class User
    {
        public static User Current { get; set; }

        public int _id;
        public string _login;
        public string _password;
        public string _name;
        public string _surename;
        public string _patronymic;
        public DateTime _Date;
        public string _email;
        public string _status;
    }
}
