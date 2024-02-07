namespace CustomerDatabaseAPI.Server.Models
{
    public class CompanyCallDetails
    {
        //This would hold all details assuming customer answers
        //from a call that  the company made to a customer.
        public int CallDetailsId { get; set; }

        public int CallId { get; set; }

        public DateOnly Date { get; set; }

        public TimeOnly CallMade { get; set; }

        public TimeOnly CallEnded { get; set; }

        public string Notes { get; set; }

    }
}
