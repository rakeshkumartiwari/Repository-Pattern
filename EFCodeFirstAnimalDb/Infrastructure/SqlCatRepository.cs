using System.Collections.Generic;
using EFCodeFirstAnimalDb.Domain;
using EFCodeFirstAnimalDb.Interface;
using System.Data;
using System.Data.SqlClient;

namespace EFCodeFirstAnimalDb.Infrastructure
{
    public class SqlCatRepository : ICatRepository
    {
        const string ConnectionString = @"Data Source=DESKTOP-I6O9RHK\SQLEXPRESS;Initial Catalog=EFCodeFirstAnimalDb.AnimalDB;integrated Security=true";
        public void Add(Cat cat)
        {

            using (var objConnection = new SqlConnection(ConnectionString))
            {
                objConnection.Open();
                var objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                objCommand.Parameters.Add(new SqlParameter("@Id", cat.Id));
                objCommand.Parameters.Add(new SqlParameter("@Name", cat.Name));
                objCommand.Parameters.Add(new SqlParameter("@Color", cat.Color));
                objCommand.CommandText = "Insert into Cats values(@Id,@Name,@Color)";
                objCommand.ExecuteNonQuery();

            }
        }

        public DataSet GetCatById(string id)
        {
            using (var objConnection = new SqlConnection(ConnectionString))
            {
                var objCommand = new SqlCommand("select * from Cats where Id ='" + id + "'", objConnection);
                var objDataset = new DataSet();
                var objAdapter = new SqlDataAdapter(objCommand);
                objAdapter.Fill(objDataset);
                return objDataset;
            }
        }
        public DataSet GetCatByName(string name)
        {
            using (var objConnection = new SqlConnection(ConnectionString))
            {
                var objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                objCommand.CommandText = "select * from Cats where Name ='" + name + "'";
                var objDataset = new DataSet();
                var objAdapter = new SqlDataAdapter(objCommand);
                objAdapter.Fill(objDataset);
                return objDataset;
            }
        }
        public DataSet GetCats()
        {

            using (var objConnection = new SqlConnection(ConnectionString))
            {
                var objCommand = new SqlCommand("select * from Cats", objConnection);
                var objDataset = new DataSet();
                var objAdapter = new SqlDataAdapter(objCommand);
                objAdapter.Fill(objDataset);
                return objDataset;
            }

        }

        public void Update(Cat cat)
        {
            using (var objConnection = new SqlConnection(ConnectionString))
            {
                objConnection.Open();
                var objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                objCommand.CommandText = "Update Cats set Name='" + cat.Name + "'," +
                                         "Color='" + cat.Color + "'" +
                                         " where Id='" +
                                         cat.Id + "'";
                objCommand.ExecuteNonQuery();
            }

        }

        public void Delete(string id)
        {
            using (var objConnection = new SqlConnection(ConnectionString))
            {
                objConnection.Open();
                var objCommand = new SqlCommand("Delete from Cats where Id='" + id + "'",objConnection);
                objCommand.ExecuteNonQuery();
            }
        }
    }
}