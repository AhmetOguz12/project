 class CustomerManager
    {
        public void Add(Customer customer)  
        {

            Console.WriteLine( "Muster� Eklendi  : " + customer.CustomerName + "  " + customer.CustomerSurname );
        }
        public void Delete(Customer customer)  
        {
            Console.WriteLine("Muster� S�l�nd� : " + customer.CustomerName + "  " + customer.CustomerSurname);
        }
        public void L�st�ng( Customer customer)  
        {
            Console.WriteLine(" Muster� L�stelend� : " + customer.CustomerName + "  " + customer.CustomerSurname);
        }
    }
}
