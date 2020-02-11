using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models
{
   public class Client
    {
        private string _adress;

        public int ClientId{ get; set; }
        public string Company_Name { get; set; }
        
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        public string Adress
        {
            get { return _adress; }
            set { _adress = Street + " " + ZipCode + " " + City; }
        }


        public string Email { get; set; }
        public string Number { get; set; }
        public string Language { get; set; }

    }
}
