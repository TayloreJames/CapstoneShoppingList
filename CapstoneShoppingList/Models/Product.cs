using System;
using System.Collections.Generic;

namespace CapstoneShoppingList.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
