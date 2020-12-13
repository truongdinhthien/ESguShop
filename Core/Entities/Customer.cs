using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        //Id from ApplicationUser
        //Unique
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
