using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;

namespace PhoneBook.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public List<PersonModel> GetPersonList()
        {
            List<PersonModel> PersonList = new List<PersonModel>();

                SqlConnection connection;
                connection = new SqlConnection();
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PhoneBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connection.Open();
                SqlDataReader sqlDataReader;
                SqlCommand sqlCommand = new SqlCommand();
                {
                    sqlCommand.CommandText = $"select Id,FirstName,LastName,Phone,Email,CreationDate,UpdateDate from People";
                    sqlCommand.Connection = connection;
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                    PersonModel personModel = new PersonModel()
                    {
                        Id = (int)sqlDataReader["Id"],
                        FirstName = (string)sqlDataReader["FirstName"],
                        LastName = (string)sqlDataReader["LastName"],
                        Phone = (int)sqlDataReader["Phone"],
                        Email = (string)sqlDataReader["Email"],
                        CreationDate = (DateTime)sqlDataReader["CreationDate"],
                        UpdateDate = (DateTime)sqlDataReader["UpdateDate"]
                    };
                    PersonList.Add(personModel);
                    }
                }



            return PersonList;
        }
    }
}
