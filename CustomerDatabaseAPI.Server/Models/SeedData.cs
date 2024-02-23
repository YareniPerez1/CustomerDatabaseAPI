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

            //check if context is valid[context = data]


            if (context == null)
            {
                throw new NullReferenceException("No Context Available.");
            }


            //check if there is data in the database

            if (context.Customer.Any())
            {
                //if there is, abort. ( we don't need to seed)
                return;

            }
            else
            {

                Customer customer = new Customer
                {

                    FirstName = "John",
                    LastName = "Doe",
                    CustomerAddress = new List<CustomerAddress>
                    {
                        new CustomerAddress {  CurrentCustAddress = true }
                    },

                    PhoneNumber = new List<Phone>
                    {
                        new Phone {PhoneNumber = "1235558790"}
                    },

                    CustEmail = new List<Email>
                    {
                        new Email {CustEmail = "john.doe@gmail.com"}
                    },







                };
                //want to add data
                context.Customer.Add(customer);


                //context.Customer.Add(new Customer
                //{
                //    CustomerId = 2,
                //    FirstName = "Jem",
                //    LastName = "Jo",
                //    CustomerAddress = new List<CustomerAddress>
                //    {
                //        new CustomerAddress { AddressId = 2, CustomerId = 2, CurrentCustAddress = true, CustAddressId = 2 }
                //    },

                //    PhoneNumber = new List<Phone>
                //    {
                //        new Phone {PhoneId = 2, CustomerID = 2, PhoneNumber = "5059110125"}
                //    },

                //    CustEmail = new List<Email>
                //    {
                //        new Email { EmailId = 2, CustomerId = 2, CustEmail = "Jem.Jo01@gmail.com"}
                //    },


                //});

                //context.Customer.Add(new Customer
                //{
                //    CustomerId = 3,
                //    FirstName = "Albert",
                //    LastName = "Mox",
                //    CustomerAddress = new List<CustomerAddress>
                //    {
                //        new CustomerAddress { AddressId = 3, CustomerId = 3, CurrentCustAddress = true, CustAddressId = 3 }
                //    },

                //    PhoneNumber = new List<Phone>
                //    {
                //        new Phone {PhoneId = 3, CustomerID = 3, PhoneNumber = "8880217654"}
                //    },

                //    CustEmail = new List<Email>
                //    {
                //        new Email { EmailId = 3, CustomerId = 3, CustEmail = "Albert.M0xx@gmail.com"}
                //    },

                //});

                // context.Customer.AddRange(Customers);
                await context.SaveChangesAsync();


            }


                //if (context.Address.Any())
                //{
                //    return;
                //}
                //else
                //{
                //    context.Address.Add(new Address
                //    {
                //        AddressId = 1,
                //        AddressLine1 = "123 maple st",
                //        City = "Centralia",
                //        State = "WA",
                //        Zip = "98531",


                //    });


                //    context.Address.Add(new Address
                //    {
                //        AddressId = 2,
                //        AddressLine1 = "126 Liv RD",
                //        AddressLine2 = "APT J7",
                //        City = "Chehalis",
                //        State = "WA",
                //        Zip = "98532",


                //    });

                //    context.Address.Add(new Address
                //    {
                //        AddressId = 3,
                //        AddressLine1 = "345 Poke LN",
                //        City = "Olympia",
                //        State = "WA",
                //        Zip = "98512",

                //    });

                //    await context.SaveChangesAsync();

                //}

                //if (context.CustomerAddress.Any())
                //{
                //    return;
                //}
                //else
                //{
                //    context.CustomerAddress.Add(new CustomerAddress
                //    {
                //        CustomerId = 7,
                //        AddressId = 1,
                //        CurrentCustAddress = true,




                //    });

                //    context.CustomerAddress.Add(new CustomerAddress
                //    {
                //        CustomerId = 8,
                //        AddressId = 2,
                //        CurrentCustAddress = true,



                //    });

                //    context.CustomerAddress.Add(new CustomerAddress
                //    {
                //        CustomerId = 9,
                //        AddressId = 3,
                //        CurrentCustAddress = true,



                //    });
                //    await context.SaveChangesAsync();
                //}


                //if (context.CustEmail.Any())
                //{
                //    return;
                //}
                //else
                //{
                //    context.CustEmail.Add(new Email
                //    {
                //        CustomerId = 7,
                //        CustEmail = "John.Doe@gmail.com"



                //    });

                //    context.CustEmail.Add(new Email
                //    {
                //        CustomerId = 8,
                //        CustEmail = "Jem.joe1@gmail.com"



                //    });

                //    context.CustEmail.Add(new Email
                //    {
                //        CustomerId = 9,
                //        CustEmail = "albert.Mox0@gmail.com"



                //    });
                //    await context.SaveChangesAsync();


                //}

                //if (context.PhoneNumber.Any())
                //{
                //    return;
                //}
                //else
                //{
                //    context.PhoneNumber.Add(new Phone
                //    {

                //        CustomerID = 7,
                //        PhoneNumber = "3607880231",


                //    });

                //    context.PhoneNumber.Add(new Phone
                //    {

                //        CustomerID = 8,
                //        PhoneNumber = "3602223334",


                //    });

                //    context.PhoneNumber.Add(new Phone
                //    {

                //        CustomerID = 9,
                //        PhoneNumber = "365086767",


                //    });
                //    await context.SaveChangesAsync();

                //}

                //if (context.CompanyCalls.Any())
                //{
                //    return;
                //}
                //else
                //{
                //    context.CompanyCalls.Add(new CompanyCall
                //    {

                //        CustomerId = 8,
                //        CallAnswered = false,


                //    });

                //    await context.SaveChangesAsync();
                //}







                //if there is not any data



                //start populating the database with data



            }

        
    }
}
