using System.ComponentModel.DataAnnotations;

namespace CustomerDatabaseAPI.Server.Models
{
    public class Address
    {
       [Key] public int AddressId { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public List<CustomerAddress> CustAddress { get; set; }
    }
}
