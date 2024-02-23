using System.ComponentModel.DataAnnotations;

namespace CustomerDatabaseAPI.Server.Models
{
    public class Email
    {

       [Key] public int EmailId { get; set; }

        public int CustomerId { get; set; }

        public string CustEmail { get; set; }




    }
}
