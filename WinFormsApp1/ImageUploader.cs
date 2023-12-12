using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    class ImageUploader
    {
        private readonly string _connectionString;

        public ImageUploader(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Upload(PictureBox pictureBox)
        {
            var db = new DB();
            using (var command = new MySqlCommand())
            {
                command.CommandText = "INSERT INTO myTable (image) VALUES (@image)";

                var image = new Bitmap(pictureBox.Image);
                using (var memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, ImageFormat.Jpeg);
                    memoryStream.Position = 0;

                    var sqlParameter = new MySqlParameter("@image", MySqlDbType.Binary, (int)memoryStream.Length)
                    {
                        Value = memoryStream.ToArray()
                    };
                    command.Parameters.Add(sqlParameter);
                }
                db.openConnection();
                command.ExecuteNonQuery();
            }
        }
    }
}
