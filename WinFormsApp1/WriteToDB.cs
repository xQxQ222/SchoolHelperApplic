using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WinFormsApp1
{
    internal class WriteToDB
    {
        public static bool RegisterANewUser(User userToReg) 
        {
            bool userSuccessfullyregistered;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `last name`,`otchestvo`, `birthdate`, `status`,`email`) VALUES (@log,@pass,@name,@surename,@otch,@birthDate,@status,@email);", db.getConnection());

            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = userToReg._login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = userToReg._password;
            command.Parameters.Add("@name", MySqlDbType.Text).Value  = userToReg._name;
            command.Parameters.Add("@surename", MySqlDbType.Text).Value = userToReg._surename;
            command.Parameters.Add("@otch", MySqlDbType.VarChar).Value  = userToReg._patronymic;
            command.Parameters.Add("@birthDate", MySqlDbType.Date).Value = userToReg._Date;
            command.Parameters.Add("@status", MySqlDbType.Text).Value = userToReg._status;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userToReg._email;

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

        public static void ChangePass(string email, string newPass)
        {
            DB db = new DB();
            DataTable dt = new DataTable();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `password` = @uP WHERE `users`.`email` LIKE @email", db.getConnection());
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email; 
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = newPass; 
            db.openConnection();
            MessageBox.Show("Пароль успешно изменен");
            command.ExecuteNonQuery();
            db.closeConnection();
        }

        public static void AddNewMessage(Tuple<List<string>, Dictionary<string, string>> recip, string comboBox1, string richTextBox1)
        {
            DB dB = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `messages` (`sender`, `recipient`, `message`, `messageDate`) VALUES (@sender, @recipient, @message, @messageDate)", dB.getConnection());
            cmd.Parameters.Add("@sender", MySqlDbType.VarChar).Value = User.Current._login;
            cmd.Parameters.Add("@recipient", MySqlDbType.VarChar).Value = recip.Item2[comboBox1];
            cmd.Parameters.Add("@message", MySqlDbType.Text).Value = richTextBox1;
            cmd.Parameters.Add("@messageDate", MySqlDbType.Date).Value = DateTime.Now;
            dB.openConnection();
            cmd.ExecuteNonQuery();
            dB.closeConnection();
        }
    }
}
