using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class DropdownYearly
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Bhagyastorage> bhagyastorages { get; set; }
    }
}
