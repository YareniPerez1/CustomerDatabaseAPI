namespace CustomerDatabaseAPI.Server.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<CustomerAddress> CustomerAddress { get; set; }
        public List<Phone> PhoneNumber { get; set; }
        public List<Email> CustEmail { get; set; }

        public List<CompanyCall> CompanyCalls { get; set;  }

      


    }
}
