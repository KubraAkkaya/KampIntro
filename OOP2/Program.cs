using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer musteri1 = new IndividualCustomer();
            musteri1.MusteriNo = "12222";
            musteri1.Name = "kübra";
            musteri1.LastName = "akkaya";
            musteri1.TcNo = "1255444";


            CoorporateCustomer musteri2 = new CoorporateCustomer();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1222";
            musteri2.CompanyName = "Kodlama.io";
            musteri2.VergiNo = "2522";


            Musteri musteri3 = new IndividualCustomer();
            Musteri musteri4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}
