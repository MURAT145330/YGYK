using GercekHayattaApstractInterface.Apstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekHayattaApstractInterface.Entites
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DataOfBirth { get; set; }
        public string Nationaly { get; set; }


    }
}
