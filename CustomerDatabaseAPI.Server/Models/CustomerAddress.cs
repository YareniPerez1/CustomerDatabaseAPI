namespace CustomerDatabaseAPI.Server.Models
{
    public class CustomerAddress
    {
        public int CustAddressId { get; set; }

        public int CustomerId { get; set; }

        public int AddressId { get; set; }

        public bool CurrentCustAddress { get; set; }


    }
}
