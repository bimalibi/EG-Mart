using EG_Mart.Models;
using MySql.Data.MySqlClient;
using System;
using System.Dynamic;
using Mysqlx.Crud;
using EG_Mart.dtos;
using EG_Mart.Controllers;

class program
{

    public static void Main(string[] args)
    {

       // DeleteCustomer();
     // UpdateCustomer();
       /*CustomerEntry customerEntry=new CustomerEntry();*/


    }
    //Insert Customer
    public void CustomerEntry()
    {
        CustomerDto customerDto= new CustomerDto();
        
        
        Console.WriteLine("Customer Entry Form");

        Console.WriteLine("Enter username : ");
        var uname = Console.ReadLine();

        Console.WriteLine("Enter your First Name : ");
        var fName = Console.ReadLine();

        Console.WriteLine("Enter our Last Name : ");
        var lName = Console.ReadLine();

        Console.WriteLine("Enter your Age : ");
        var age = Console.ReadLine();

        Console.WriteLine("Enter your Address : ");
        var address = Console.ReadLine();

       
        customerDto.cFirstName = fName;
        customerDto.cLastName = lName;
        customerDto.cAddress = address;
        customerDto.cAge = age;
        customerDto.username = uname;

        CustomerController customerController = new CustomerController();
        customerController.CreateCustomer(customerDto);
        
        

    }

    //update Customer address
    static void UpdateCustomer()
    {
        Console.WriteLine("Udate Customer Details");
        Console.WriteLine("Enter your username :");
        string username = Console.ReadLine();

        Console.WriteLine("Enter udated address :");
        var address= Console.ReadLine();

        CustomerDto customerDto = new CustomerDto();    
        customerDto.username=username;
        customerDto.cAddress=address ;

        CustomerController customerController = new CustomerController();
        customerController.UpdateCustomerAddress(customerDto);
    }
    static void DeleteCustomer()
    {
        Console.WriteLine("Delete Customer ");
        Console.WriteLine("Enter username");
        var adminUser=Console.ReadLine();

        UserDto userDto = new UserDto();
        userDto.username = adminUser;
        UserController userController=new UserController();
        userController.CheckAdmin(userDto);

    }
    /* static void PlaceOrder()
     {
         string conStr = "server=localhost;user=root;database=eg_mart;port=3306;password=root";

         Console.WriteLine("Enter your username: ");
         var uname=Console.ReadLine();

         using (MySqlConnection conn = new MySqlConnection(conStr))
         {
             conn.Open();
             var custId=0;
             bool customerValue= false;
             string findCustomer = "SELECT * FROM customer WHERE username= '"+uname+"'";


             using (MySqlCommand cmd = new MySqlCommand(findCustomer, conn))
             {
                 MySqlDataReader reader = cmd.ExecuteReader();
                 customerValue = reader.Read();
                 if (customerValue == false)
                 {
                     Console.WriteLine("No users found");
                     Console.ReadLine();
                     return;
                     //string orderDetails = "SELECT customer.cId, customer.cFirstName, orders.oId, orders.quantity, product.pRate FROM customer JOIN orders 

                 }
                 custId = int.Parse(reader["cId"].ToString());
                 reader.Close();
             }


                    Console.WriteLine("Enter the order : ");
                     var productName = Console.ReadLine();

                     Console.WriteLine("Enter order Quantity : ");
                     var qty = Console.ReadLine();

                     string findproduct = "SELECT * FROM product WHERE pName='"+productName+"'";
                     MySqlCommand cmd1 = new MySqlCommand(findproduct, conn);

                         MySqlDataReader reader1 = cmd1.ExecuteReader();
                         reader1.Read();
                         var prdtId = reader1["pId"];
                         reader1.Close();
                         string insertOrder = "INSERT INTO orders(quantity, customerId, productId) VALUES (@qty, @customerId, @productId)";
                         using (MySqlCommand cmd2 = new MySqlCommand(insertOrder, conn))
                         {
                             cmd2.Parameters.AddWithValue("@qty", qty);
                             cmd2.Parameters.AddWithValue("@customerId", custId);
                             cmd2.Parameters.AddWithValue("@productId", prdtId);

                             cmd2.ExecuteNonQuery();

                             Console.WriteLine("Your order is placed");

                         }
             string orderDetails = "SELECT customer.cId, customer.cFirstName,orders.oId, customer.cLastName, product.pName, orders.quantity, product.pRate, orders.quantity*product.pRate total FROM orders JOIN customer ON orders.customerId= customer.cId JOIN product ON orders.productId=product.pId WHERE customer.cId='"+custId+"' AND product.pId='"+prdtId+ "' ORDER BY orders.oId DESC LIMIT 0, 1";
             MySqlCommand cmd3= new MySqlCommand(orderDetails, conn);
             MySqlDataReader r1= cmd3.ExecuteReader();
             r1.Read();
             Console.WriteLine("Customer ID : " + r1["cId"]+" Customer Name : " + r1["cFirstName"]+" "+r1["cLastName"]+" Order ID : " + r1["oId"]+" Order Quantity : " +r1["quantity"]+" " +" Product Rate : " + r1["pRate"]+" Total : " + r1["total"]);
             Console.WriteLine("Thank you for visiting EG-Mart");
             Console.ReadLine();
             r1.Close();

         }



     }*/

}