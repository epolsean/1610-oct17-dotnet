using PizzaStoreMVC.Client.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace PizzaStoreMVC.Client.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            var model = new PizzaModel();
            return View(model);
        }

        [HttpPost]
        public string Index(PizzaModel model)
        {
            return model.Sauce;
        }

        public async void Customer()
        {
            var client = new HttpClient();
            var message = await client.GetAsync(@"http://http://ec2-54-165-173-64.compute-1.amazonaws.com/pizzaapi/controller");
            var result = await message.Content.ReadAsStreamAsync();

            var serializer = new XmlSerializer(typeof(List<Customer>));
            var customers = new List<Customer>();

            var output = serializer.Deserialize(result) as List<Customer>;
            customers = output;
        }
    }
}