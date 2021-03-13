 class CustomerManager
    {
        public void Add(Customer customer)  
        {

            Console.WriteLine( "Musterý Eklendi  : " + customer.CustomerName + "  " + customer.CustomerSurname );
        }
        public void Delete(Customer customer)  
        {
            Console.WriteLine("Musterý Sýlýndý : " + customer.CustomerName + "  " + customer.CustomerSurname);
        }
        public void Lýstýng( Customer customer)  
        {
            Console.WriteLine(" Musterý Lýstelendý : " + customer.CustomerName + "  " + customer.CustomerSurname);
        }
    }
}
