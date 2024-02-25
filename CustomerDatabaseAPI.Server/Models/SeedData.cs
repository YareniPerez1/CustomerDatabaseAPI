using CustomerDatabaseAPI.Server.Data;
using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;

namespace CustomerDatabaseAPI.Server.Models
{
    public class SeedData
    {


        public static async Task EnsurePopulated(IServiceProvider services)
        {
            //awaits for something to happen
            //get a handle to the context

            CustomerDatabaseAPIServerContext context = services.GetService<CustomerDatabaseAPIServerContext>();

            ////check if context is valid[context = data]


            if (context == null)
            {
                throw new NullReferenceException("No Context Available.");
            }


            ////check if there is data in the database

            if (context.Customer.Any())
            {
                //if there is, abort. ( we don't need to seed)
                return;

            }
            else
            {
                Address address = new Address
                {
                    AddressLine1 = "213 main st",
                    AddressLine2 = "",
                    City = "Centralia",
                    State = "WA",
                    Zip = "98531"

                };
                context.Address.Add(address);
                await context.SaveChangesAsync();

                Customer customer = new Customer
                {

                    FirstName = "John",
                    LastName = "Doe",
                    CustomerAddress = new List<CustomerAddress>
                    {
                        new CustomerAddress { CurrentCustAddress = true, AddressId = address.AddressId }
                    },

                    PhoneNumber = new List<Phone>
                    {
                        new Phone { PhoneNumber = "1235558790" }
                    },

                    CustEmail = new List<Email>
                    {
                        new Email { CustEmail = "john.doe@gmail.com" }
                    }
                };

                context.Customer.Add(customer);
                await context.SaveChangesAsync();



                address = new Address
                {
                    AddressLine1 = "678 Berry LN",
                    AddressLine2 = "",
                    City = "Chehalis",
                    State = "WA",
                    Zip = "98532"

                };
                context.Address.Add(address);
                await context.SaveChangesAsync();

                customer = new Customer
                {
                    FirstName = "Jem",
                    LastName = "Jo",
                    CustomerAddress = new List<CustomerAddress>
                    {
                         new CustomerAddress { CurrentCustAddress = true, AddressId = address.AddressId }
                    },

                    PhoneNumber = new List<Phone>
                    {
                        new Phone { PhoneNumber = "5059110125" }
                    },

                    CustEmail = new List<Email>
                    {
                        new Email { CustEmail = "Jem.Jo01@gmail.com" }
                    },

                };
                
                context.Customer.Add(customer);
                await context.SaveChangesAsync();


            }
        }     

        
    }
}
