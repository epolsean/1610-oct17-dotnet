using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;
using PizzaStoreData.DataClient.Mappers;

namespace PizzaStoreData.DataClient
{
    public class PizzaStoreService : IPizzaStoreService
    {
        private EFData data = new EFData();

        #region Change Functions
        public bool ChangeAddress(AddressDetailDAO address)
        {
            return data.ChangeAddressDetail(AddressDetailMapper.MapToAddressDetail(address));
        }

        public bool ChangeCardPayment(CardPaymentDAO cardPayment)
        {
            return data.ChangeCardPayment(CardPaymentMapper.MapToCardPayment(cardPayment));
        }

        public bool ChangeCheese(CheeseDAO cheese)
        {
            return data.ChangeCheese(CheeseMapper.MapToCheese(cheese));
        }

        public bool ChangeCheeseTopping(CheeseToppingDAO topping)
        {
            return data.ChangeCheeseTopping(CheeseToppingMapper.MapToCheeseTopping(topping));
        }

        public bool ChangeCrust(CrustDAO crust)
        {
            return data.ChangeCrust(CrustMapper.MapToCrust(crust));
        }

        public bool ChangeCustomer(CustomerDAO customer)
        {
            return data.ChangeCustomer(CustomerMapper.MapToCustomer(customer));
        }

        public bool ChangeEmail(EmailDAO email)
        {
            return data.ChangeEmail(EmailMapper.MapToEmail(email));
        }

        public bool ChangeMeat(MeatDAO meat)
        {
            return data.ChangeMeat(MeatMapper.MapToMeat(meat));
        }

        public bool ChangeMeatTopping(MeatToppingDAO topping)
        {
            return data.ChangeMeatTopping(MeatToppingMapper.MapToMeatTopping(topping));
        }

        public bool ChangeName(NameDAO name)
        {
            return data.ChangeName(NameMapper.MapToName(name));
        }

        public bool ChangePaymentType(PaymentTypeDAO paymentType)
        {
            return data.ChangePaymentType(PaymentTypeMapper.MapToPaymentType(paymentType));
        }

        public bool ChangePhone(PhoneDAO phone)
        {
            return data.ChangePhone(PhoneMapper.MapToPhone(phone));
        }

        public bool ChangePizza(PizzaDAO pizza)
        {
            return data.ChangePizza(PizzaMapper.MapToPizza(pizza));
        }

        public bool ChangePizzaOrder(PizzaOrderDAO order)
        {
            return data.ChangePizzaOrder(PizzaOrderMapper.MapToPizzaOrder(order));
        }

        public bool ChangePizzaOrderDetail(PizzaOrderDetailDAO orderDetails)
        {
            return data.ChangePizzaOrderDetail(PizzaOrderDetailMapper.MapToPizzaOrderDetail(orderDetails));
        }

        public bool ChangeSauce(SauceDAO sauce)
        {
            return data.ChangeSauce(SauceMapper.MapToSauce(sauce));
        }

        public bool ChangeSize(SizeDAO size)
        {
            return data.ChangeSize(SizeMapper.MapToSize(size));
        }

        public bool ChangeStore(StoreDAO store)
        {
            return data.ChangeStore(StoreMapper.MapToStore(store));
        }

        public bool ChangeStoreHour(StoreHourDAO hours)
        {
            return data.ChangeStoreHour(StoreHourMapper.MapToStoreHour(hours));
        }

        public bool ChangeVegetable(VegetableDAO vegetable)
        {
            return data.ChangeVegetable(VegetableMapper.MapToVegetable(vegetable));
        }

        public bool ChangeVegetableTopping(VegetableToppingDAO topping)
        {
            return data.ChangeVegetableTopping(VegetableToppingMapper.MapToVegetableTopping(topping));
        }
        #endregion

        #region Delete Functions
        public bool DeleteAddress(AddressDetailDAO address)
        {
            return data.DeleteAddressDetail(AddressDetailMapper.MapToAddressDetail(address));
        }

        public bool DeleteCardPayment(CardPaymentDAO cardPayment)
        {
            return data.DeleteCardPayment(CardPaymentMapper.MapToCardPayment(cardPayment));
        }

        public bool DeleteCheese(CheeseDAO cheese)
        {
            return data.DeleteCheese(CheeseMapper.MapToCheese(cheese));
        }

        public bool DeleteCheeseTopping(CheeseToppingDAO topping)
        {
            return data.DeleteCheeseTopping(CheeseToppingMapper.MapToCheeseTopping(topping));
        }

        public bool DeleteCrust(CrustDAO crust)
        {
            return data.DeleteCrust(CrustMapper.MapToCrust(crust));
        }

        public bool DeleteCustomer(CustomerDAO customer)
        {
            return data.DeleteCustomer(CustomerMapper.MapToCustomer(customer));
        }

        public bool DeleteEmail(EmailDAO email)
        {
            return data.DeleteEmail(EmailMapper.MapToEmail(email));
        }

        public bool DeleteMeat(MeatDAO meat)
        {
            return data.DeleteMeat(MeatMapper.MapToMeat(meat));
        }

        public bool DeleteMeatTopping(MeatToppingDAO topping)
        {
            return data.DeleteMeatTopping(MeatToppingMapper.MapToMeatTopping(topping));
        }

        public bool DeleteName(NameDAO name)
        {
            return data.DeleteName(NameMapper.MapToName(name));
        }

        public bool DeletePaymentType(PaymentTypeDAO paymentType)
        {
            return data.DeletePaymentType(PaymentTypeMapper.MapToPaymentType(paymentType));
        }

        public bool DeletePhone(PhoneDAO phone)
        {
            return data.DeletePhone(PhoneMapper.MapToPhone(phone));
        }

        public bool DeletePizza(PizzaDAO pizza)
        {
            return data.DeletePizza(PizzaMapper.MapToPizza(pizza));
        }

        public bool DeletePizzaOrder(PizzaOrderDAO order)
        {
            return data.DeletePizzaOrder(PizzaOrderMapper.MapToPizzaOrder(order));
        }

        public bool DeletePizzaOrderDetail(PizzaOrderDetailDAO orderDetails)
        {
            return data.DeletePizzaOrderDetail(PizzaOrderDetailMapper.MapToPizzaOrderDetail(orderDetails));
        }

        public bool DeleteSauce(SauceDAO sauce)
        {
            return data.DeleteSauce(SauceMapper.MapToSauce(sauce));
        }

        public bool DeleteSize(SizeDAO size)
        {
            return data.DeleteSize(SizeMapper.MapToSize(size));
        }

        public bool DeleteStore(StoreDAO store)
        {
            return data.DeleteStore(StoreMapper.MapToStore(store));
        }

        public bool DeleteStoreHour(StoreHourDAO hours)
        {
            return data.DeleteStoreHour(StoreHourMapper.MapToStoreHour(hours));
        }

        public bool DeleteVegetable(VegetableDAO vegetable)
        {
            return data.DeleteVegetable(VegetableMapper.MapToVegetable(vegetable));
        }

        public bool DeleteVegetableTopping(VegetableToppingDAO topping)
        {
            return data.DeleteVegetableTopping(VegetableToppingMapper.MapToVegetableTopping(topping));
        }
        #endregion

        #region Get Functions
        public AddressDetailDAO GetAddress(int id)
        {
            return AddressDetailMapper.MapToAddressDetailDAO(data.GetAddressDetail(id));
        }

        public List<AddressDetailDAO> GetAddresses()
        {
            var returnList = new List<AddressDetailDAO>();

            foreach (var item in data.GetAddressDetails())
            {
                returnList.Add(AddressDetailMapper.MapToAddressDetailDAO(item));
            }

            return returnList;
        }

        public CardPaymentDAO GetCardPayment(int id)
        {
            return CardPaymentMapper.MapToCardPaymentDAO(data.GetCardPayment(id));
        }

        public List<CardPaymentDAO> GetCardPayments()
        {
            var returnList = new List<CardPaymentDAO>();

            foreach (var item in data.GetCardPayments())
            {
                returnList.Add(CardPaymentMapper.MapToCardPaymentDAO(item));
            }

            return returnList;
        }

        public CheeseDAO GetCheese(int id)
        {
            return CheeseMapper.MapToCheeseDAO(data.GetCheese(id));
        }

        public List<CheeseDAO> GetCheeses()
        {
            var returnList = new List<CheeseDAO>();

            foreach (var item in data.GetCheeses())
            {
                returnList.Add(CheeseMapper.MapToCheeseDAO(item));
            }

            return returnList;
        }

        public CheeseToppingDAO GetCheeseTopping(int id)
        {
            return CheeseToppingMapper.MapToCheeseToppingDAO(data.GetCheeseTopping(id));
        }

        public List<CheeseToppingDAO> GetCheeseToppings()
        {
            var returnList = new List<CheeseToppingDAO>();

            foreach (var item in data.GetCheeseToppings())
            {
                returnList.Add(CheeseToppingMapper.MapToCheeseToppingDAO(item));
            }

            return returnList;
        }

        public CrustDAO GetCrust(int id)
        {
            return CrustMapper.MapToCrustDAO(data.GetCrust(id));
        }

        public List<CrustDAO> GetCrusts()
        {
            var returnList = new List<CrustDAO>();

            foreach (var item in data.GetCrusts())
            {
                returnList.Add(CrustMapper.MapToCrustDAO(item));
            }

            return returnList;
        }

        public CustomerDAO GetCustomer(int id)
        {
            return CustomerMapper.MapToCustomerDAO(data.GetCustomer(id));
        }

        public List<CustomerDAO> GetCustomers()
        {
            var returnList = new List<CustomerDAO>();

            foreach (var item in data.GetCustomers())
            {
                returnList.Add(CustomerMapper.MapToCustomerDAO(item));
            }

            return returnList;
        }

        public EmailDAO GetEmail(int id)
        {
            return EmailMapper.MapToEmailDAO(data.GetEmail(id));
        }

        public List<EmailDAO> GetEmails()
        {
            var returnList = new List<EmailDAO>();

            foreach (var item in data.GetEmails())
            {
                returnList.Add(EmailMapper.MapToEmailDAO(item));
            }

            return returnList;
        }

        public MeatDAO GetMeat(int id)
        {
            return MeatMapper.MapToMeatDAO(data.GetMeat(id));
        }

        public List<MeatDAO> GetMeats()
        {
            var returnList = new List<MeatDAO>();

            foreach (var item in data.GetMeats())
            {
                returnList.Add(MeatMapper.MapToMeatDAO(item));
            }

            return returnList;
        }

        public MeatToppingDAO GetMeatTopping(int id)
        {
            return MeatToppingMapper.MapToMeatToppingDAO(data.GetMeatTopping(id));
        }

        public List<MeatToppingDAO> GetMeatToppings()
        {
            var returnList = new List<MeatToppingDAO>();

            foreach (var item in data.GetMeatToppings())
            {
                returnList.Add(MeatToppingMapper.MapToMeatToppingDAO(item));
            }

            return returnList;
        }

        public NameDAO GetName(int id)
        {
            return NameMapper.MapToNameDAO(data.GetName(id));
        }

        public List<NameDAO> GetNames()
        {
            var returnList = new List<NameDAO>();

            foreach (var item in data.GetNames())
            {
                returnList.Add(NameMapper.MapToNameDAO(item));
            }

            return returnList;
        }

        public PaymentTypeDAO GetPaymentType(int id)
        {
            return PaymentTypeMapper.MapToPaymentTypeDAO(data.GetPaymentType(id));
        }

        public List<PaymentTypeDAO> GetPaymentTypes()
        {
            var returnList = new List<PaymentTypeDAO>();

            foreach (var item in data.GetPaymentTypes())
            {
                returnList.Add(PaymentTypeMapper.MapToPaymentTypeDAO(item));
            }

            return returnList;
        }

        public PhoneDAO GetPhone(int id)
        {
            return PhoneMapper.MapToPhoneDAO(data.GetPhone(id));
        }

        public List<PhoneDAO> GetPhones()
        {
            var returnList = new List<PhoneDAO>();

            foreach (var item in data.GetPhones())
            {
                returnList.Add(PhoneMapper.MapToPhoneDAO(item));
            }

            return returnList;
        }

        public PizzaDAO GetPizza(int id)
        {
            return PizzaMapper.MapToPizzaDAO(data.GetPizza(id));
        }

        public PizzaOrderDAO GetPizzaOrder(int id)
        {
            return PizzaOrderMapper.MapToPizzaOrderDAO(data.GetPizzaOrder(id));
        }

        public PizzaOrderDetailDAO GetPizzaOrderDetail(int id)
        {
            return PizzaOrderDetailMapper.MapToPizzaOrderDetailDAO(data.GetPizzaOrderDetail(id));
        }

        public List<PizzaOrderDetailDAO> GetPizzaOrderDetails()
        {
            var returnList = new List<PizzaOrderDetailDAO>();

            foreach (var item in data.GetPizzaOrderDetails())
            {
                returnList.Add(PizzaOrderDetailMapper.MapToPizzaOrderDetailDAO(item));
            }

            return returnList;
        }

        public List<PizzaOrderDAO> GetPizzaOrders()
        {
            var returnList = new List<PizzaOrderDAO>();

            foreach (var item in data.GetPizzaOrders())
            {
                returnList.Add(PizzaOrderMapper.MapToPizzaOrderDAO(item));
            }

            return returnList;
        }

        public List<PizzaDAO> GetPizzas()
        {
            var returnList = new List<PizzaDAO>();

            foreach (var item in data.GetPizzas())
            {
                returnList.Add(PizzaMapper.MapToPizzaDAO(item));
            }

            return returnList;
        }

        public SauceDAO GetSauce(int id)
        {
            return SauceMapper.MapToSauceDAO(data.GetSauce(id));
        }

        public List<SauceDAO> GetSauces()
        {
            var returnList = new List<SauceDAO>();

            foreach (var item in data.GetSauces())
            {
                returnList.Add(SauceMapper.MapToSauceDAO(item));
            }

            return returnList;
        }

        public SizeDAO GetSize(int id)
        {
            return SizeMapper.MapToSizeDAO(data.GetSize(id));
        }

        public List<SizeDAO> GetSizes()
        {
            var returnList = new List<SizeDAO>();

            foreach (var item in data.GetSizes())
            {
                returnList.Add(SizeMapper.MapToSizeDAO(item));
            }

            return returnList;
        }

        public StoreDAO GetStore(int id)
        {
            return StoreMapper.MapToStoreDAO(data.GetStore(id));
        }

        public StoreHourDAO GetStoreHour(int id)
        {
            return StoreHourMapper.MapToStoreHourDAO(data.GetStoreHour(id));
        }

        public List<StoreHourDAO> GetStoreHours()
        {
            var returnList = new List<StoreHourDAO>();

            foreach (var item in data.GetStoreHours())
            {
                returnList.Add(StoreHourMapper.MapToStoreHourDAO(item));
            }

            return returnList;
        }

        public List<StoreDAO> GetStores()
        {
            var returnList = new List<StoreDAO>();

            foreach (var item in data.GetStores())
            {
                returnList.Add(StoreMapper.MapToStoreDAO(item));
            }

            return returnList;
        }

        public VegetableDAO GetVegetable(int id)
        {
            return VegetableMapper.MapToVegetableDAO(data.GetVegetable(id));
        }

        public List<VegetableDAO> GetVegetables()
        {
            var returnList = new List<VegetableDAO>();

            foreach (var item in data.GetVegetables())
            {
                returnList.Add(VegetableMapper.MapToVegetableDAO(item));
            }

            return returnList;
        }

        public VegetableToppingDAO GetVegetableTopping(int id)
        {
            return VegetableToppingMapper.MapToVegetableToppingDAO(data.GetVegetableTopping(id));
        }

        public List<VegetableToppingDAO> GetVegetableToppings()
        {
            var returnList = new List<VegetableToppingDAO>();

            foreach (var item in data.GetVegetableToppings())
            {
                returnList.Add(VegetableToppingMapper.MapToVegetableToppingDAO(item));
            }

            return returnList;
        }
        #endregion

        #region Insert Functions
        public bool InsertAddress(AddressDetailDAO address)
        {
            return data.InsertAddressDetail(AddressDetailMapper.MapToAddressDetail(address));
        }

        public bool InsertCardPayment(CardPaymentDAO cardPayment)
        {
            return data.InsertCardPayment(CardPaymentMapper.MapToCardPayment(cardPayment));
        }

        public bool InsertCheese(CheeseDAO cheese)
        {
            return data.InsertCheese(CheeseMapper.MapToCheese(cheese));
        }

        public bool InsertCheeseTopping(CheeseToppingDAO topping)
        {
            return data.InsertCheeseTopping(CheeseToppingMapper.MapToCheeseTopping(topping));
        }

        public bool InsertCrust(CrustDAO crust)
        {
            return data.InsertCrust(CrustMapper.MapToCrust(crust));
        }

        public bool InsertCustomer(CustomerDAO customer)
        {
            return data.InsertCustomer(CustomerMapper.MapToCustomer(customer));
        }

        public bool InsertEmail(EmailDAO email)
        {
            return data.InsertEmail(EmailMapper.MapToEmail(email));
        }

        public bool InsertMeat(MeatDAO meat)
        {
            return data.InsertMeat(MeatMapper.MapToMeat(meat));
        }

        public bool InsertMeatTopping(MeatToppingDAO topping)
        {
            return data.InsertMeatTopping(MeatToppingMapper.MapToMeatTopping(topping));
        }

        public bool InsertName(NameDAO name)
        {
            return data.InsertName(NameMapper.MapToName(name));
        }

        public bool InsertPaymentType(PaymentTypeDAO paymentType)
        {
            return data.InsertPaymentType(PaymentTypeMapper.MapToPaymentType(paymentType));
        }

        public bool InsertPhone(PhoneDAO phone)
        {
            return data.InsertPhone(PhoneMapper.MapToPhone(phone));
        }

        public bool InsertPizza(PizzaDAO pizza)
        {
            return data.InsertPizza(PizzaMapper.MapToPizza(pizza));
        }

        public bool InsertPizzaOrder(PizzaOrderDAO order)
        {
            return data.InsertPizzaOrder(PizzaOrderMapper.MapToPizzaOrder(order));
        }

        public bool InsertPizzaOrderDetail(PizzaOrderDetailDAO orderDetails)
        {
            return data.InsertPizzaOrderDetail(PizzaOrderDetailMapper.MapToPizzaOrderDetail(orderDetails));
        }

        public bool InsertSauce(SauceDAO sauce)
        {
            return data.InsertSauce(SauceMapper.MapToSauce(sauce));
        }

        public bool InsertSize(SizeDAO size)
        {
            return data.InsertSize(SizeMapper.MapToSize(size));
        }

        public bool InsertStore(StoreDAO store)
        {
            return data.InsertStore(StoreMapper.MapToStore(store));
        }

        public bool InsertStoreHour(StoreHourDAO hours)
        {
            return data.InsertStoreHour(StoreHourMapper.MapToStoreHour(hours));
        }

        public bool InsertVegetable(VegetableDAO vegetable)
        {
            return data.InsertVegetable(VegetableMapper.MapToVegetable(vegetable));
        }

        public bool InsertVegetableTopping(VegetableToppingDAO topping)
        {
            return data.InsertVegetableTopping(VegetableToppingMapper.MapToVegetableTopping(topping));
        }
#endregion
    }
}
