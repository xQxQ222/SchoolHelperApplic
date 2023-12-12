using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class ImageRetriever
    {
        private readonly string _connectionString;

        public ImageRetriever(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Retrieve(PictureBox pictureBox, int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT image FROM myTable WHERE id = @id";
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var imageData = (byte[])reader["image"];
                        using (var memoryStream = new MemoryStream(imageData))
                        {
                            pictureBox.Image = Image.FromStream(memoryStream);
                        }
                    }
                }
            }
        }
    }
}
