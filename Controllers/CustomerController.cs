using EG_Mart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EG_Mart.dtos;
using MySql.Data.MySqlClient;

namespace EG_Mart.Controllers
{
    public class CustomerController
    {
        private readonly string conStr = "server=localhost;user=root;database=eg_mart;port=3306;password=root";

        public CustomerController()
        {
            
        }
        public void CreateCustomer(CustomerDto _customer)
        {
            using (MySqlConnection con = new MySqlConnection(conStr))
            {
                con.Open();

                //quer to insert
                string query = "INSERT INTO customer(cFirstName, cLastName, cAddress, cAge, username) VALUES (@fName, @lName, @address, @age, @uname)";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fName", _customer.cFirstName);
                    cmd.Parameters.AddWithValue("@lName", _customer.cLastName);
                    cmd.Parameters.AddWithValue("@address", _customer.cAddress);
                    cmd.Parameters.AddWithValue("@age", _customer.cAge);
                    cmd.Parameters.AddWithValue("@uname", _customer.username);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("Data added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Data could not be added.");
                    }
                }


            }
        }
        public void UpdateCustomerAddress(CustomerDto _customer)
        {
           using( MySqlConnection con=new MySqlConnection(conStr)){
                con.Open();
                string query = "UPDATE customer SET cAddress = @address WHERE username= @username";
                using (MySqlCommand cmd=new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@address", _customer.cAddress);
                    cmd.Parameters.AddWithValue("@username", _customer.username);

                    int result=cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Updated Successfully");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Address Update failed");
                        Console.ReadLine();
                    }
                }
            }


        }

    }
}
