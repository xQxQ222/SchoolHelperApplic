using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    class User
    {
        public int? _id;
        public string _login;
        public string _password;
        public string _name;
        public string _surename;
        public string _patronymic;
        public DateTime _Date;
        public string _email;
        public string _status;
        public static readonly User Current=new User();
        public User(int id,string login,string pass,string name,string surename,string patronymic,DateTime date,string status,string email)
        {
            Current._id = id;
            Current._login = login;
            Current._password = pass;
            Current._name = name;
            Current._surename = surename;
            Current._patronymic = patronymic;
            Current._Date = date;
            Current._status = status;
            Current._email = email;
        }
        public User() 
        {
        }
    }
}
