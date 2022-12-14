
/// *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-
/// Author: Juan Quezada
/// Project of BYU
/// EXERCISE 2
/// *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-
using System;
namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> productName = new List<string>() { "Paper", "Computer", "Water", "Pizza", "Bread", "Keyboard", "Smartphone" };
            List<string> Names = new List<string>() { "Miguel", "Bia", "Julia", "Jose", "Quezada", "Pedro", "Juan", "Manuel" };
            List<string> Street = new List<string>() { "Abbeville", "Birchbrook", "Candlebrook", "Chamberlain", "Dearborn" };
            List<string> City = new List<string>() { "Lehi", "West mort", "Hios", "Conect", "Salt lake" };
            List<string> State = new List<string>() { "Utah", "New york", "Illinois", "Las vegas", "Toronto" };
            List<string> Country = new List<string>() { "USA", "Brazil", "Bolivia", "Costa Rica", "Colombia", "Paraguay" };
            List<int> prices = new List<int>() { 15, 20, 25, 35, 50, 55, 60, 70 };

            Customer customer_1 = get_customer(Names);
            Order order = get_order();
            int firstPrice = get_totalPrice_items(order.Productlist_prices[0], order.Productlist_prices[1], order.Productlist_prices[2]);
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
            order.totalPrice = get_shipping(firstPrice, customer_1.customerAddress);
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
            display(customer_1, order);


            void display(Customer customer, Order order)
            {
                Console.WriteLine($" Nome: {customer.customerName}");
                Console.WriteLine($" Order:    ID - Product   = $  x  Quantity");
                Console.WriteLine($"           " + order.Productlist_iD[0] + " - " + order.Productlist_names[0] + " = " + order.Productlist_prices[0] + "$ x  1 ");
                Console.WriteLine($"           " + order.Productlist_iD[1] + " - " + order.Productlist_names[1] + " = " + order.Productlist_prices[1] + "$ x  1 ");
                Console.WriteLine($"           " + order.Productlist_iD[2] + " - " + order.Productlist_names[2] + " = " + order.Productlist_prices[2] + "$ x  1 ");
                Console.WriteLine("");
                Console.WriteLine($" Total: {order.totalPrice} $");
                Console.WriteLine("----------------------------------------");
                display_address(customer.customerAddress);
            }

            void display_address(Address address)
            {
                Console.WriteLine($"ADDRESS: ");
                Console.WriteLine($"   Country: {address.country}");
                Console.WriteLine($"   City: {address.city}");
                Console.WriteLine($"   State: {address.state_province}");
                Console.WriteLine($"   Street: {address.street}");
            }



            Product get_product(List<string> Names, List<int> prices)
            {
                Product product = new Product();
                product.pruductName = get_random(Names);
                product.idProduct = get_random_number();
                product.price = get_random_price(prices);
                return product;
            }
            Address get_Address(List<string> Street, List<string> City, List<string> State, List<string> Country)
            {
                Address address = new Address();
                address.country = get_random(Country);
                address.street = get_random(Street);
                address.state_province = get_random(State);
                address.city = get_random(City);
                return address;
            }
            Customer get_customer(List<string> Names)
            {
                Customer customer = new Customer();
                customer.customerName = get_random(Names);
                customer.customerAddress = get_Address(Street, City, State, Country);
                return customer;
            }
            string get_random(List<string> array)
            {
                var random = new Random();
                int randIndex = random.Next(array.Count);
                return array[randIndex];
            }

            int get_random_number()
            {
                var random = new Random();
                return random.Next(1000);
            }

            int get_random_price(List<int> array)
            {
                var random = new Random();
                int randIndex = random.Next(array.Count);
                return array[randIndex];

            }
            Order get_order()
            {
                Order order = new Order();
                for (int i = 0; i < 3; i++)
                {
                    Product producto = get_product(productName, prices);
                    order.Productlist_names.Add(producto.pruductName);
                    order.Productlist_prices.Add(producto.price);
                    order.Productlist_iD.Add(producto.idProduct);
                }
                return order;
            }
            int get_totalPrice_items(int x, int y, int z)
            {
                int totalPrice = x + y + z;
                return totalPrice;
            }
            int get_shipping(int x, Address address)
            {
                int shipping = 0;
                if (address.country == "USA")
                {
                    shipping = 5;
                    Console.WriteLine("Lives in USA, the cost of the shipping is: 5$\n");
                }
                else
                {
                    shipping = 35;
                    Console.WriteLine("Lives out of USA, the cost of the shipping is: 35$\n");

                }
                int totalPrice = x + shipping;
                return totalPrice;
            }
        }
        class Order
        {
            public List<string> Productlist_names = new List<string>();
            public List<int> Productlist_prices = new List<int>();
            public List<int> Productlist_iD = new List<int>();


            public int totalPrice;
            public Address address = new Address();
        }
        class Product
        {
            public string pruductName = "";
            public int idProduct = 0;
            public int price = 0;
            public int quantity = 0;
        }
        class Address
        {
            public string street = "";
            public string city = "";
            public string state_province = "";
            public string country = "";
        }
        class Customer
        {
            public string customerName = "";
            public Address customerAddress = new Address();
        }
    }
}