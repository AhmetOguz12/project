  class Program
    {
        static void Main(string[] args)
        {
            Customer Customer1 = new Customer();
            Customer1.CustomerName = "Ahmet";
            Customer1.CustomerSurname = "Bilgin";
            Customer1.CustomerId = 1213;
            Customer1.CustomerAmount = 12344;

            Customer Customer2 = new Customer();
            Customer2.CustomerName = "Engýn";
            Customer2.CustomerSurname = "Demýrog";
            Customer2.CustomerId = 1214;
            Customer2.CustomerAmount = 123343;

            Customer Customer3 = new Customer();
            Customer3.CustomerName = "Oguzhan";
            Customer3.CustomerSurname = "Býlgýn";
            Customer3.CustomerId = 1215;
            Customer3.CustomerAmount = 1232344;

            Customer[] Customers = new Customer[] { Customer1, Customer2, Customer3 };

            foreach (var Customer in Customers)
            {
                Console.WriteLine(Customer.CustomerName + "  " + Customer.CustomerSurname + "  " + Customer.CustomerId + "  " + Customer.CustomerAmount );
            }

             Console.WriteLine("Musterý Lýsteleme");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(Customer1);
            customerManager.Delete(Customer2);
            customerManager.Lýstýng(Customer3);


            


        }
    }
}