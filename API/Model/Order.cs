using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required]
        public int UserId { get; set;}
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime RequireDate { get; set; }
        [Required]
        public DateTime ShippedDate { get; set; }

        public virtual ICollection<OrderDetail> Details { get; set; }
        public virtual User User { get; set; }
    }
}
