using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class Bhagyastorage
    {
        public int Id { get; set; }
        public string Itemname { get; set; }
        public int TotalQuantity { get; set; }
        public int amount { get; set; }
        public double Tamount { get; set; }
        public int dm { get; set; }
        public int ym { get; set; }
        [NotMapped]
        public string month { get; set; }
        [NotMapped]
        public string year { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public dropdownMonthly dropdownMonthly { get; set; }
        public DropdownYearly DropdownYearly { get; set; }
    }
}
