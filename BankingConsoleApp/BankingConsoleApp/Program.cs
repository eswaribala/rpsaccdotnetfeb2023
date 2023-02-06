// See https://aka.ms/new-console-template for more information

     //top level statements
            Console.WriteLine("Rocking with c#");
            //create customer object
            //global using scope
            Customer customer = new Customer
            {
                CustomerId = new Random().Next(10000),
                Name = "Parameswari",
                DOB = new DateTime(1970, 12, 2)
            };
            //immutable
            //customer.CustomerId = 3876573;
            Console.WriteLine("CustomerId={0},Customer Name={1},DOB={2}",
                customer.CustomerId,customer.Name,customer.DOB);
           //Nullability test
            string? value = null;
            //int length = value.Length;
            //Console.WriteLine("Value Lenght {0}", length);
            Console.ReadKey();
        