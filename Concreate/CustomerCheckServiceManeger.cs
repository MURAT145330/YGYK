using GercekHayattaApstractInterface.Apstract;
using GercekHayattaApstractInterface.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekHayattaApstractInterface.Concreate
{
    public class CustomerCheckServiceManeger : IPersonCheckService
    {
        public bool ChekcCustomer(Customer customer)
        {
            return true;
        }
    }
}
