using System.ComponentModel.DataAnnotations;

namespace CustomerDatabaseAPI.Server.Models
{
    public class Phone
    {

        [Key]  public int PhoneId { get; set; }

        public int CustomerID { get; set; }

        public string PhoneNumber { get; set; }

    }
}
