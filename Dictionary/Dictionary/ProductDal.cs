using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class ProductDal
    {
        SqlConnection cnn = new SqlConnection(@"server = (localdb)\mssqllocaldb; initial catalog = Words; integrated security = true;");

        public void ConnectionControl()
        {
            if (cnn.State == System.Data.ConnectionState.Closed)
            {
                cnn.Open();
            }
        }

        public List<Words> GetAll()
        {
            ConnectionControl();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Words", cnn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Words> wordslist = new List<Words>();

            while (reader.Read())
            {
                Words word = new Words()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    WordTr = Convert.ToString(reader["WordTr"]),
                    WordEng = Convert.ToString(reader["WordEng"]),
                    WordTrAc = Convert.ToString(reader["WordTrAc"]),
                    WordEngAc = Convert.ToString(reader["WordEngAc"]),
                    ImgFileLocation = Convert.ToString(reader["ImgFileLocation"])
                };

                wordslist.Add(word);
            }

            reader.Close();
            cnn.Close();

            return wordslist;
        }

        public void Add(Words word)
        {
            ConnectionControl();

            SqlCommand cmd = new SqlCommand("INSERT INTO Words values(@WordTr, @WordEng, @WordTrAc, @WordEngAc, @FileLocation)", cnn);

            cmd.Parameters.AddWithValue("@WordTr", word.WordTr);
            cmd.Parameters.AddWithValue("@WordEng", word.WordEng);
            cmd.Parameters.AddWithValue("@WordTrAc", word.WordTrAc);
            cmd.Parameters.AddWithValue("@WordEngAc", word.WordEngAc);
            cmd.Parameters.AddWithValue("@FileLocation", word.ImgFileLocation);

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public void Update(Words word)
        {
            ConnectionControl();

            SqlCommand cmd = new SqlCommand("UPDATE Words SET WordTr = @WordTr, WordEng = @WordEng, WordTrAc = @WordTrAc, WordEngAc = @WordEngAc, ImgFileLocation = @FileLocation WHERE Id = @Id", cnn);

            cmd.Parameters.AddWithValue("@WordTr", word.WordTr);
            cmd.Parameters.AddWithValue("@WordEng", word.WordEng);
            cmd.Parameters.AddWithValue("@WordTrAc", word.WordTrAc);
            cmd.Parameters.AddWithValue("@WordEngAc", word.WordEngAc);
            cmd.Parameters.AddWithValue("@FileLocation", word.ImgFileLocation);
            cmd.Parameters.AddWithValue("@Id", word.Id);
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public void Delete(int Id)
        {
            ConnectionControl();

            SqlCommand cmd = new SqlCommand("DELETE FROM Words WHERE Id = @Id", cnn);

            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

    }

}
