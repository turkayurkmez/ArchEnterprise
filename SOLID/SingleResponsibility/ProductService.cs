using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
   public class ProductService
    {
        public int AddProduct(string name, decimal price)
        {
            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=vakifDb;Integrated Security=True");
            //SqlCommand sqlCommand = new SqlCommand("Insert into Products (Name, Price) values (@name,@price)", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@name", name);
            //sqlCommand.Parameters.AddWithValue("@price", price);

            //sqlConnection.Open();
            //var affectedRows = sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();

            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=vakifDb;Integrated Security=True";
            string commandText = "Insert into Products(Name, Price) values(@name, @price)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);

            DbHelper dbHelper = new DbHelper(connectionString);
            var affectedRows = dbHelper.ExecuteNonQuery(commandText, parameters);

            return affectedRows;

           

        }

        public void UpdateProduct() { }
        public void DeleteProduct() { }
        public void GetProductByPrice() { }


    }
}
