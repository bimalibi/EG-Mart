using EG_Mart.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EG_Mart.Models;
using MySql.Data.MySqlClient;

namespace EG_Mart.Controllers
{

    public class UserController
    {
        private readonly string conStr = "server=localhost;user=root;database=eg_mart;port=3306;password=root";

        public UserController()
        {

        }
        public void CheckAdmin(UserDto _user)
        {
            using (MySqlConnection conn=new MySqlConnection(conStr))
            {
                string uname = _user.username;
                conn.Open();
                string query = "SELECT * FROM user WHERE username="+"'"+uname+"'";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataReader reader= cmd.ExecuteReader();
                    reader.Read();
                    var isAdmin =Convert.ToBoolean(reader["isAdmin"]);
                    Console.WriteLine(isAdmin);
                    reader.Close();
                    if (isAdmin==true) 
                    {
                        Console.WriteLine("Enter the username of customer you would like to delete :");
                        var customerName=Console.ReadLine();
                        string query1 = "DELETE FROM customer WHERE username="+"'"+customerName+"'";
                        using (MySqlCommand cmd1=new MySqlCommand(query1, conn))
                        {
                            cmd1.ExecuteNonQuery();
                            Console.WriteLine("Delete Successfull");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You are not authorized to delete customer");
                        Console.ReadLine();
                    }
                   
                }
            }
        }
    }
}
