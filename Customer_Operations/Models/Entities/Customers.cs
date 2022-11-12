using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Customer_Operations.Models.Entities
{
    public class Customers
    {
        [Key]
        [DisplayName("Customer #")]
        public int CustomerID { get; set; }

        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }

        [DisplayName("Customer Number")]
        public int CustomerNumber { get; set; }

        [DisplayName("Customer Address")]
        public string CustomerAddress { get; set; }

        [DisplayName("Customer Mobile Number")]
        public string CustomerMobileNumber { get; set; }

    }
}
