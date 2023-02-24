using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EG_Mart.dtos
{
    public class ProductDto
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public int pRate { get; set; }
        public string pDescription { set; get; }
    }
}
