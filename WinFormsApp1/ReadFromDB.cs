using MySqlConnector;
using System.Data;

namespace WinFormsApp1
{
    internal class ReadFromDB
    {
        public static DB db = new DB(); // не уверена, что лучше тут инициализировать из-за статика

        public static bool ReadCurrentUser(string login, string password)
        {
            bool userIsLoggedInSuccessfully;

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL AND `password`=@uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(dt);
            db.openConnection();
            if (dt.Rows.Count > 0)
            {
                userIsLoggedInSuccessfully = true;

                var read = command.ExecuteReader();
                read.Read();

                var withoutTime = read.GetString(6).Split(' ')[0];
                var day = int.Parse(withoutTime.Split('.')[0]);
                var month = int.Parse(withoutTime.Split('.')[1]);
                var year = int.Parse(withoutTime.Split(".")[2]);
                var date = new DateTime(year, month, day);
                currentUser._id = int.Parse(read.GetString(0));
                currentUser._login = read.GetString(1);
                currentUser._password = read.GetString(2);
                currentUser._name = read.GetString(3);
                currentUser._surename = read.GetString(4);
                currentUser._patronymic = read.GetString(5);
                currentUser._Date = date;
                currentUser._status = read.GetString(7);
                currentUser._email = read.GetString(8);
            }
            else
                userIsLoggedInSuccessfully = false;

            db.closeConnection();
            return userIsLoggedInSuccessfully;
        }

        public static List<string> GetAdministrators()
        {
            List<string> list = new List<string>();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `status` LIKE 'Администратор'", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.openConnection();
            list.Add("");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var read = command.ExecuteReader();
                    read.Read();
                    var name = read.GetString(3);
                    var surname = read.GetString(4);
                    var patronymic = read.GetString(5);
                    var fullName = $"{surname} {name.Substring(0, 1)}. {patronymic.Substring(0, 1)}.";
                    string teacher = fullName;
                    list.Add(teacher);
                }
            }
            db.closeConnection();
            return list;
        }

        public static bool CheckIfEmailInBD(string email) // тут точно строковый тип???
        {
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email`=@uE", db.getConnection());
            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = email;

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt.Rows.Count > 0;
        }

        public static bool CheckIfNameOfUserInBD(string nameOfUser)
        {
            DB db = new DB();
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = nameOfUser;

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt.Rows.Count > 0;
        }

        public static Tuple<List<string>, Dictionary<string, string>> GetRecipients()
        {
            var list = new List<string>();
            var dic = new Dictionary<string, string>();
            DB db = new DB();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = null;
            if (currentUser._status == "Ученик")
                command = new MySqlCommand("SELECT * FROM `users` WHERE `status` LIKE 'Учитель'", db.getConnection());
            else if (currentUser._status == "Учитель")
                command = new MySqlCommand("SELECT * FROM `users` WHERE 'status' LIKE 'Учитель' OR 'Ученик'", db.getConnection());
            else
            {
                command = new MySqlCommand("SELECT * FROM `users`", db.getConnection());
            }
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            db.openConnection();
            list.Add("");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var read = command.ExecuteReader();
                    read.Read();
                    var login = read.GetString(1);
                    var name = read.GetString(3);
                    var surname = read.GetString(4);
                    var patronymic = read.GetString(5);
                    var fullName = $"{surname} {name.Substring(0, 1)}. {patronymic.Substring(0, 1)}.";
                    string teacher = fullName;
                    dic[fullName] = login;
                    list.Add(teacher);
                }
            }
            db.closeConnection();
            var tuple = new Tuple<List<string>, Dictionary<string, string>>(list, dic);
            return tuple;
        }

    }
}
