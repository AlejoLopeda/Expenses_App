using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Account: BaseEntity
    {
        public String AccountName { get; set; }
        public double amount { get; set; }



    }
}
