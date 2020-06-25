using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PhoneBook.Models
{
    public class SourceManager
    {
        List<PersonModel> PersonList = new List<PersonModel>();
        public List<PersonModel> Get()
        {
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
        public void GetById(int Id)
        {

        }
        public List<PersonModel> Add(int Id, string FirstName, string LastName, int Phone, string Email, DateTime CreationDate, DateTime UpdateDate)
        {
            List<PersonModel> PersonList = new List<PersonModel>();

            SqlConnection connection;
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PhoneBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection.Open();
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand = new SqlCommand();
            {
                sqlCommand.CommandText = $"insert into People (FirstName,[LastName],[Phone],[Email],[CreationDate],[UpdateDate] )values('{FirstName}','{LastName}',{Phone},'{Email}',{CreationDate},{UpdateDate})";
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
        public List<PersonModel> Remove()
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
        public List<PersonModel> Update(int Id,string FirstName, string LastName,int Phone,string Email,DateTime CreationDate, DateTime UpdateDate)
        {
            SqlConnection connection;
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PhoneBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection.Open();
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand = new SqlCommand();
            {
                sqlCommand.CommandText = $"Upadate People set FirstName='{FirstName}',LastName='{LastName}',Phone='{Phone}',Email='{Email}',CreationDate={CreationDate}, UpdateDate={UpdateDate} Where Id={Id}";
                sqlCommand.Connection = connection;
                sqlDataReader = sqlCommand.ExecuteReader();                    
            }
            return PersonList;
        }
    }
}
