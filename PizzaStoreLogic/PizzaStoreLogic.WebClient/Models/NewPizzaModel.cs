using PizzaStoreLogic.Logic;
using PizzaStoreLogic.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreLogic.WebClient.Models
{
    public class NewPizzaModel
    {
        private DataService _Data = new DataService();
        private List<SizeDTO> _Sizes = new DataService().GetSizes();
        private List<CrustDTO> _Crusts = new DataService().GetCrusts();
        private List<SauceDTO> _Sauces = new DataService().GetSauces();
        private List<CheeseDTO> _Cheeses = new DataService().GetCheeses();
        private List<MeatDTO> _Meats = new DataService().GetMeats();
        private List<VegetableDTO> _Vegetables = new DataService().GetVegetables();

        public List<SizeDTO> Sizes { get { return _Sizes; } set { _Sizes = _Data.GetSizes(); } }
        public List<CrustDTO> Crusts { get { return _Crusts; } set { _Crusts = _Data.GetCrusts(); } }
        public List<SauceDTO> Sauces { get { return _Sauces; } set { _Sauces = _Data.GetSauces();} }
        public List<CheeseDTO> Cheeses { get { return _Cheeses; } set { _Cheeses = _Data.GetCheeses(); } }
        public List<MeatDTO> Meats { get { return _Meats; } set { _Meats = _Data.GetMeats(); } }
        public List<VegetableDTO> Vegetables { get { return _Vegetables; } set { _Vegetables = _Data.GetVegetables(); } }
        public int Quantity { get; set; }
    }
}