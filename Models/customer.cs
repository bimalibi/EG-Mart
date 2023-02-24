using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EG_Mart.Models
{
    public class customer
    {
        public int cId { get; set; }
        public string cFirstName { get; set; }
        public string cLastName { get; set; }
        public string cAddress { get; set; }
        public string cAge { get; set; }
        public string username { get; set; }

    }
}
