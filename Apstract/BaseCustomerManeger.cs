using GercekHayattaApstractInterface.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekHayattaApstractInterface.Apstract
{
    public abstract class BaseCustomerManeger :IPersonCheckService
    {
        public void ChekcCustomer(Customer customer)
        {
            Console.WriteLine("customer check service");
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("save to db");
        }
    }
}
