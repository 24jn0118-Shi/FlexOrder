using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexOrderLibrary
{
    public class LanguageTable
    {
        public List<Language> GetAllLanguage()
        {
            DataTable table = new DataTable();
            List<Language> languagelist = new List<Language>();

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT language_no, language_name FROM Language ORDER BY language_no ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    Language language = new Language();

                    language.language_no = int.Parse(row["language_no"].ToString());
                    language.language_name = row["language_name"].ToString();

                    languagelist.Add(language);
                }
            }
            return languagelist;
        }


    }
}
