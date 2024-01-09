using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class VetsRepository
    {

        public string conString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RestaurantDB;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public List<Vet> GetAllVets()
        {
            var vetList = new List<Vet>();

            using (SqlConnection sql = new SqlConnection(conString))
            {
                sql.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;

                cmd.CommandText = "SELECT * FROM Vets";

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Vet vet = new Vet();
                    vet.Id = reader.GetInt32(0);
                    vet.FullName = reader.GetString(1);
                    vet.Speciality = reader.GetString(2);
                    vet.YearsEperience = reader.GetInt32(3);

                    vetList.Add(vet);
                }
            }
            return vetList;
        }

        public int InsertVet(Vet vet)
        {
            using (SqlConnection sql = new SqlConnection(conString))
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = string.Format("INSERT INTO Vets VALUES" +
                    "('{0}', '{1}', '{2}')", vet.FullName, vet.Speciality, vet.YearsEperience);
                
                return cmd.ExecuteNonQuery();

            }
        }
    }
}
