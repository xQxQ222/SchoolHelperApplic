using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Policy;

namespace WinFormsApp1
{
    internal class WriteToDB
    {
        //мб эти все поля вынести в отдельный класс? Их очень много и передавать все поля как аргументы в метод - странно
        public static bool RegisterANewUser(string login, string password, string name, string surname, string otchestvo, DateTime birthDate,  string status, string email) 
        {
            bool userSuccessfullyregistered;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `last name`,`otchestvo`, `birthdate`, `status`,`email`) VALUES (@log,@pass,@name,@surename,@otch,@birthDate,@status,@email);", db.getConnection());

            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@name", MySqlDbType.Text).Value  = name;
            command.Parameters.Add("@surename", MySqlDbType.Text).Value = surname;
            command.Parameters.Add("@otch", MySqlDbType.VarChar).Value  = otchestvo;
            command.Parameters.Add("@birthDate", MySqlDbType.Date).Value = birthDate;
            command.Parameters.Add("@status", MySqlDbType.Text).Value = status;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                userSuccessfullyregistered = true;
            else
            {
                userSuccessfullyregistered = false;
            }
            db.closeConnection();
            return userSuccessfullyregistered;
        }



    }
}
