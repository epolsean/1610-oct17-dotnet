using PizzaStoreLogic.Logic;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.WebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreLogic.WebClient.Controllers
{
    public class CustomerController : Controller
    {
        public PartialViewResult Log(CustomerDTO customer, string returnUrl)
        {
            return PartialView(new CustomerModel
            {
                ReturnUrl = returnUrl,
                Customer = customer
            });
        }

        public ViewResult FullLog(CustomerDTO customer, string returnUrl)
        {
            return View(new CustomerModel
            {
                ReturnUrl = returnUrl,
                Customer = customer
            });
        }

        public ViewResult SignUp(CustomerDTO customer, string returnUrl)
        {
            return View(new CustomerModel
            {
                ReturnUrl = returnUrl,
                Customer = customer
            });
        }

        public ViewResult RegisterComplete(CustomerDTO customer, string returnUrl)
        {
            return View(new CustomerModel
            {
                ReturnUrl = returnUrl,
                Customer = customer
            });
        }

        public RedirectToRouteResult Register(CustomerDTO customer, string returnUrl, string firstName, string lastName, string email, string phone, string address1, string address2, string city, string state, string zipcode)
        {
            DataService Data = new DataService();
            NameDTO Name = new NameDTO { FirstName = firstName, LastName = lastName, Active = true };
            EmailDTO Email = new EmailDTO { Address = email, Active = true };
            PhoneDTO Phone = new PhoneDTO { Number = phone, Active = true };
            AddressDTO Address = new AddressDTO { Address1 = address1, Address2 = address2, City = city, State = state, Zipcode = int.Parse(zipcode), Active = true };
            if(Data.InsertAddress(Address) && Data.InsertEmail(Email) && Data.InsertName(Name) && Data.InsertPhone(Phone))
            {
                Name = Data.GetNames().Last();
                Email = Data.GetEmails().Last();
                Phone = Data.GetPhones().Last();
                Address = Data.GetAddresses().Last();

                CustomerDTO Customer = new CustomerDTO { Address = Address, Phone = Phone, Email = Email, Name = Name, Active = true };

                if(Data.InsertCustomer(Customer))
                {
                    customer = Data.GetCustomers().Last();
                    Session["Customer"] = customer;

                    return RedirectToAction("RegisterComplete");
                }
            }

            return RedirectToAction("SignUp");
        }

        public RedirectToRouteResult LogOut(CustomerDTO customer)
        {
            customer = new CustomerDTO();
            customer.Id = 0;
            Session["Customer"] = customer;
            OrderDTO order = new OrderDTO();
            order.Id = 0;
            Session["Order"] = order;
            return RedirectToAction("Home", "Pizza");
        }

        public RedirectToRouteResult CompleteLog(CustomerDTO customer, int selectedLog)
        {
            DataService data = new DataService();
            if (selectedLog != 0)
            {
                Session["Customer"] = data.GetCustomer(selectedLog);
                return RedirectToAction("Home", "Pizza");
            }
            return RedirectToAction("FullLog");
        }

        private CustomerDTO GetCustomer()
        {
            CustomerDTO customer = (CustomerDTO)Session["Customer"];
            if (customer == null)
            {
                customer = new CustomerDTO();
                Session["Order"] = customer;
            }
            return customer;
        }
    }
}