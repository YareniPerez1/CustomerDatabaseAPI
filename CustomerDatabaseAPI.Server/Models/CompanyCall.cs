using System.ComponentModel.DataAnnotations;

namespace CustomerDatabaseAPI.Server.Models
{
    public class CompanyCall
    {
        //this keeps track of the calls made from the company
        //to a customer 

        //has fk to customer

        [Key] public int CallId { get; set; }

        public int CustomerId { get; set; }

        public bool CallAnswered { get; set; }

        List<CompanyCallDetails> CallDetail { get; set; }


    }
}
