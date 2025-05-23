using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class User:IdentityUser <Guid>
    {
        public List<Transaction> transactions {  get; set; } = new List<Transaction>();
    }
}
