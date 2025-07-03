using Microsoft.EntityFrameworkCore;

namespace OrderViewer.Models
{
    public class Order
    {
        public int Id { get; set; }
        public required string Customer { get; set; }

        public string Status { get; set; } = "Pending";
        public DateTime CreatedDate { get; set; }

        [Precision(18, 2)]
        public decimal Total { get; set; }  

        public bool Paid { get; set; } = false;
    }
}
