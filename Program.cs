using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CésarLanches
    {
        internal class Program
        {
        
                 // var for clients 

            static int clientCode;
            static string clientName;
            static string clientSnack;
            static int CustomPrice;

            //list for requests

            static List<snackOrders> orders = new List<snackOrders>();
            private static readonly int Price;

            //menu Enum

            enum menu { orders = 1, confectionOrder = 2 }

            // yes or not Enum

            enum YesNot {  Yes = 1, Not = 2 }

            // Order Enum

            enum order { SaveOrder =1, ShowOrder =2}

            //struct

            struct snackOrders
            {
                public int id;
                public string name;
                public string description;
                public order order;

                //construct of struct

                public snackOrders ( int code, string clientName, string Snack, int price)
                {
                    code = code;
                    name = clientName;
                    description = Snack;
                    order = order;


                }

            }
                //main

            static void main(string[] args)
            {
                try 
                { 

                start();
            

                catch (Exception);
            
                    Console.WriteLine ("oh, an error occurred, check the values ​​entered");
                   
                }

                Console.ReadKey();

                static void ClientOrder()
                {
                    Console.WriteLine("Order Code:");
                     ClientOrder = int.Parse(Console.ReadLine());

                    Console.WriteLine("Client Name:");
                        clientName = Console.ReadLine();

                    Console.WriteLine("Client Snack");
                        clientSnack = Console.ReadLine ();

                    Console.WriteLine(Client Price);
                        CustomPrice = int.Parse(Console.ReadLine());

                    order.SaveOrder (new snackOrders(clientCode, clientName, clientSnack, CustomPrice));

                    foreach (snackOrders snack in order)
                    {
                        Console.WriteLine("Code: {clientCode}, Client:{clientName}, snack: {clientsnack}, Price: {CustomPrice}");
                        Console.WriteLine();

                    }
                


                }

                static void start()
                {
                    Console.WriteLine("Hello customer, welcome! come in, place your order now!");
                    Console.WriteLine ("what would you like to eat today?");

                    menu option = (menu) int.Parse(Console.ReadLine());


                }

                switch (ini)
                {
                    case menu.orders:
                        ClientOrder();
                        break;
                    case menu.confectionOrder();
                        break;
                }

                    static void confectionOrder()
                    {
                    foreach (snackOrders 1 in order)
                        {
                    Console.WriteLine("Code: {clientCode}, Client:{clientName}, snack: {clientsnack}, Price: {CustomPrice}"); ")

                        }

            }




























            static void Main(string[] args)
            {
            }
        }
}
        }
