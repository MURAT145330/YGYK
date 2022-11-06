using GercekHayattaApstractInterface.Apstract;
using GercekHayattaApstractInterface.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekHayattaApstractInterface.Concreate
{
    public class StarbucksCustomerManeger:BaseCustomerManeger
    {
        private IPersonCheckService  _personCheckService;
        public StarbucksCustomerManeger(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_personCheckService.ChekcCustomer(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("kontol olumsuz kimlik numarasını tekrar giriniz");
            }
        }
      
    }
}
