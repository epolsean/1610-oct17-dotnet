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
    public class OrderController : Controller
    {
        private DataService data = new DataService();

        public ViewResult Order(OrderDTO order, string returnUrl)
        {
            return View(new OrderIndexViewModel
            {
                ReturnUrl = returnUrl,
                Order = order
            });
        }

        public ViewResult StartOrder(OrderDTO order, string returnUrl)
        {
            return View(new OrderIndexViewModel
            {
                ReturnUrl = returnUrl,
                Order = order
            });
        }

        public ViewResult CheckOut(OrderDTO order, string returnUrl)
        {
            return View(new OrderIndexViewModel
            {
                ReturnUrl = returnUrl,
                Order = order
            });
        }

        public ViewResult Confirm(OrderDTO order, string returnUrl)
        {
            order = new OrderDTO();
            Session["Order"] = order;
            return View(new OrderIndexViewModel
            {
                ReturnUrl = returnUrl,
                Order = order
            });
        }

        public ViewResult PastOrders(OrderDTO order, string returnUrl)
        {
            return View(new OrderIndexViewModel
            {
                ReturnUrl = returnUrl,
                Order = order
            });
        }

        public RedirectToRouteResult CreateOrder(OrderDTO order, string returnUrl, int store, int paymentOption)
        {
            if (store != 0 && paymentOption != 0)
            {
                StoreDTO Store = data.GetStore(store);
                PaymentTypeDTO Payment = data.GetPaymentType(paymentOption);
                order.Customer = (CustomerDTO)Session["Customer"];
                order.Store = Store;
                order.Payment = Payment;

                if (data.InsertOrder(order))
                {
                    order = data.GetOrders().Last();
                    Session["Order"] = order;
                    return RedirectToAction("Order");
                }
            }
            return RedirectToAction("StartOrder");
        }

        public RedirectToRouteResult AddToOrder(OrderDTO order, string returnUrl, int size, int crust, int sauce, int cheese, int[] cheeses, int[] meats, int[] veggies, string quantity)
        {
            if (size != 0 && crust != 0 && sauce != 0 && cheese != 0 && quantity != null)
            {
                SizeDTO Size = data.GetSize(size);
                CrustDTO Crust = data.GetCrust(crust);
                SauceDTO Sauce = data.GetSauce(sauce);
                CheeseDTO Cheese = data.GetCheese(cheese);
                List<CheeseDTO> Cheeses = new List<CheeseDTO>(); ;
                List<MeatDTO> Meats = new List<MeatDTO>();
                List<VegetableDTO> Veggies = new List<VegetableDTO>();
                int Quantity = int.Parse(quantity);
                
                if (cheeses != null)
                {
                    for(int i = 0; i< cheeses.Length; i++)
                    {
                        Cheeses.Add(data.GetCheese(cheeses[i]));
                    }
                }
                else
                {
                    Cheeses = null;
                }

                if (meats != null)
                {
                    for (int i = 0; i < meats.Length; i++)
                    {
                        Meats.Add(data.GetMeat(meats[i]));
                    }
                }
                else
                {
                    Meats = null;
                }

                if (veggies != null)
                {
                    for (int i = 0; i < veggies.Length; i++)
                    {
                        Veggies.Add(data.GetVegetable(veggies[i]));
                    }
                }
                else
                {
                    Veggies = null;
                }

                if (data.CreatePizza(Size, Crust, Sauce, Cheese, Cheeses, Meats, Veggies, Quantity))
                {
                    PizzaDTO pizza = data.GetPizzas().Last();
                    OrderDetailsDTO orderDetail = new OrderDetailsDTO { Pizza = pizza, Order = order };
                    if (data.InsertOrderDetail(orderDetail))
                    {
                        return RedirectToAction("Order", new { returnUrl });
                    }
                }
            }
            return RedirectToAction("Order", new { returnUrl });
        }

        private OrderDTO GetOrder()
        {
            OrderDTO order = (OrderDTO)Session["Order"];
            if (order == null)
            {
                order = new OrderDTO();
                Session["Order"] = order;
            }
            return order;
        }
    }
}