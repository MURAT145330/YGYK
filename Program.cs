using GercekHayattaApstractInterface.Apstract;
using GercekHayattaApstractInterface.Concreate;
using GercekHayattaApstractInterface.Entites;

internal class Program
{
    private static void Main(string[] args)
    {
        //  Console.WriteLine("Hello, World!");

        BaseCustomerManeger baseCustomerManeger = new NeroCustomerManeger();


        Customer customerr1 = new Customer
        { Id=1, FirstName= "MURAT", LastName=  "DEMİR",
            DataOfBirth=new DateTime(1980,03,18) , Nationaly="tc"};


        baseCustomerManeger.Save(customerr1);

    }
}