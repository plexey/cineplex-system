using CineplexSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace CineplexSystem
{
    public class CustomerModel
    {
        public static IEnumerable<Customer30028452> GetAllRecords()
        {
            var result = from eachCustomer in BasePage.dbeCineplex.Customer30028452 select eachCustomer;

            return result.ToList();
        }

        public static void UpdateRecord(Customer30028452 newCustomer)
        {
            // Find the original supplier record to update
            Customer30028452 oldCustomer = BasePage.dbeCineplex.Customer30028452.Find(newCustomer.CustomerId);

            // save to found supplier record
            oldCustomer.Name = newCustomer.Name;
            oldCustomer.Phone = newCustomer.Phone;
            oldCustomer.CType = newCustomer.CType;
            oldCustomer.CardNo = newCustomer.CardNo;
            oldCustomer.Email = newCustomer.Email;
            oldCustomer.ExpDate = newCustomer.ExpDate;
            BasePage.dbeCineplex.SaveChangesAsync();
        }

        public static void AddRecord(Customer30028452 newCustomer)
        {
            BasePage.dbeCineplex.Customer30028452.Add(newCustomer);

            BasePage.dbeCineplex.SaveChangesAsync();
        }

        //Delete record
        public static void DeleteRecord(Customer30028452 thisCustomer)
        {
            // this method deletes the related records in Order_Products it then deletes the Orders records and finally deletes the customer.

            // filter orders by customer id
            Orders30028452 order = BasePage.dbeCineplex.Orders30028452.Find(thisCustomer.CustomerId);

            // filter orders and products by order id
            var orderAndMovies = from eachOP in BasePage.dbeCineplex.MovieOrders30028452
                                   select eachOP;

            // delete each order and products link
            foreach (var theOrder in orderAndMovies)
            {
                if (theOrder.OrderId == order.OrderId)
                {
                    BasePage.dbeCineplex.MovieOrders30028452.Remove(theOrder);
                }
            }

            // delete the order
            BasePage.dbeCineplex.Orders30028452.Remove(order);

            // filter the customers by customer id
            var result = from eachCustomer in BasePage.dbeCineplex.Customer30028452 where eachCustomer.CustomerId == thisCustomer.CustomerId select eachCustomer;

            // delete the customer thisCustomer
            BasePage.dbeCineplex.Customer30028452.Remove(result.FirstOrDefault());
            BasePage.dbeCineplex.SaveChanges();
        }
    }
}
