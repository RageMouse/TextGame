using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TextGame.DAL.ContextInterfaces;
using TextGame.Domain;

namespace TextGame.DAL.Context
{
    public class CharacterSqlContext:ICharacterContext
    {
        public List<String> GetAllPlayerNames()
        {
            List<string> PlayerNames = new List<string>();
            try
            {
                using (SqlConnection connection = Database.getConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("dbo.USPGetAllCharacterNames", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    PlayerNames.Add(reader.GetString((0)));
                                }
                            }
                        }
                    }
                }

                return PlayerNames;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public bool CreateCharacter()
        {
            throw new System.NotImplementedException();
        }
    }
}
    