using PizzaStoreLogic.Logic.Mappers;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic
{
    public class DataService
    {
        private PizzaStoreServiceClient pssc = new PizzaStoreServiceClient();

        #region Get Lists
        public List<AddressDTO> GetAddresses()
        {
            var returnList = new List<AddressDTO>();

            foreach(var item in pssc.GetAddresses())
            {
                returnList.Add(AddressMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<CardPaymentDTO> GetCardPayments()
        {
            var returnList = new List<CardPaymentDTO>();

            foreach (var item in pssc.GetCardPayments())
            {
                returnList.Add(CardPaymentMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<CheeseDTO> GetCheeses()
        {
            var returnList = new List<CheeseDTO>();

            foreach (var item in pssc.GetCheeses())
            {
                returnList.Add(CheeseMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<CheeseToppingDTO> GetCheeseToppings()
        {
            var returnList = new List<CheeseToppingDTO>();

            foreach (var item in pssc.GetCheeseToppings())
            {
                returnList.Add(CheeseToppingMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<CrustDTO> GetCrusts()
        {
            var returnList = new List<CrustDTO>();

            foreach (var item in pssc.GetCrusts())
            {
                returnList.Add(CrustMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<CustomerDTO> GetCustomers()
        {
            var returnList = new List<CustomerDTO>();

            foreach (var item in pssc.GetCustomers())
            {
                returnList.Add(CustomerMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<EmailDTO> GetEmails()
        {
            var returnList = new List<EmailDTO>();

            foreach (var item in pssc.GetEmails())
            {
                returnList.Add(EmailMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<HoursDTO> GetHours()
        {
            var returnList = new List<HoursDTO>();

            foreach (var item in pssc.GetStoreHours())
            {
                returnList.Add(HoursMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<MeatDTO> GetMeats()
        {
            var returnList = new List<MeatDTO>();

            foreach (var item in pssc.GetMeats())
            {
                returnList.Add(MeatMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<MeatToppingDTO> GetMeatToppings()
        {
            var returnList = new List<MeatToppingDTO>();

            foreach (var item in pssc.GetMeatToppings())
            {
                returnList.Add(MeatToppingMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<NameDTO> GetNames()
        {
            var returnList = new List<NameDTO>();

            foreach (var item in pssc.GetNames())
            {
                returnList.Add(NameMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<OrderDetailsDTO> GetOrderDetails()
        {
            var returnList = new List<OrderDetailsDTO>();

            foreach (var item in pssc.GetPizzaOrderDetails())
            {
                returnList.Add(OrderDetailMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<OrderDTO> GetOrders()
        {
            var returnList = new List<OrderDTO>();

            foreach (var item in pssc.GetPizzaOrders())
            {
                returnList.Add(OrderMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<PaymentTypeDTO> GetPaymentTypes()
        {
            var returnList = new List<PaymentTypeDTO>();

            foreach (var item in pssc.GetPaymentTypes())
            {
                returnList.Add(PaymentTypeMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<PhoneDTO> GetPhones()
        {
            var returnList = new List<PhoneDTO>();

            foreach (var item in pssc.GetPhones())
            {
                returnList.Add(PhoneMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<PizzaDTO> GetPizzas()
        {
            var returnList = new List<PizzaDTO>();

            foreach (var item in pssc.GetPizzas())
            {
                returnList.Add(PizzaMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<SauceDTO> GetSauces()
        {
            var returnList = new List<SauceDTO>();

            foreach (var item in pssc.GetSauces())
            {
                returnList.Add(SauceMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<SizeDTO> GetSizes()
        {
            var returnList = new List<SizeDTO>();

            foreach (var item in pssc.GetSizes())
            {
                returnList.Add(SizeMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<StoreDTO> GetStores()
        {
            var returnList = new List<StoreDTO>();

            foreach (var item in pssc.GetStores())
            {
                returnList.Add(StoreMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<VegetableDTO> GetVegetables()
        {
            var returnList = new List<VegetableDTO>();

            foreach (var item in pssc.GetVegetables())
            {
                returnList.Add(VegetableMapper.MapToDTO(item));
            }

            return returnList;
        }

        public List<VegetableToppingDTO> GetVegetableToppings()
        {
            var returnList = new List<VegetableToppingDTO>();

            foreach (var item in pssc.GetVegetableToppings())
            {
                returnList.Add(VegetableToppingMapper.MapToDTO(item));
            }

            return returnList;
        }
        #endregion

        #region Get Items
        public AddressDTO GetAddress(int id)
        {
            return AddressMapper.MapToDTO(pssc.GetAddress(id));
        }

        public CardPaymentDTO GetCardPayment(int id)
        {
            return CardPaymentMapper.MapToDTO(pssc.GetCardPayment(id));
        }

        public CheeseDTO GetCheese(int id)
        {
            return CheeseMapper.MapToDTO(pssc.GetCheese(id));
        }

        public CheeseToppingDTO GetCheeseTopping(int id)
        {
            return CheeseToppingMapper.MapToDTO(pssc.GetCheeseTopping(id));
        }

        public CrustDTO GetCrust(int id)
        {
            return CrustMapper.MapToDTO(pssc.GetCrust(id));
        }

        public CustomerDTO GetCustomer(int id)
        {
            return CustomerMapper.MapToDTO(pssc.GetCustomer(id));
        }

        public EmailDTO GetEmail(int id)
        {
            return EmailMapper.MapToDTO(pssc.GetEmail(id));
        }

        public HoursDTO GetHour(int id)
        {
            return HoursMapper.MapToDTO(pssc.GetStoreHour(id));
        }

        public MeatDTO GetMeat(int id)
        {
            return MeatMapper.MapToDTO(pssc.GetMeat(id));
        }

        public MeatToppingDTO GetMeatTopping(int id)
        {
            return MeatToppingMapper.MapToDTO(pssc.GetMeatTopping(id));
        }

        public NameDTO GetName(int id)
        {
            return NameMapper.MapToDTO(pssc.GetName(id));
        }

        public OrderDetailsDTO GetOrderDetail(int id)
        {
            return OrderDetailMapper.MapToDTO(pssc.GetPizzaOrderDetail(id));
        }

        public OrderDTO GetOrder(int id)
        {
            return OrderMapper.MapToDTO(pssc.GetPizzaOrder(id));
        }

        public PaymentTypeDTO GetPaymentType(int id)
        {
            return PaymentTypeMapper.MapToDTO(pssc.GetPaymentType(id));
        }

        public PhoneDTO GetPhone(int id)
        {
            return PhoneMapper.MapToDTO(pssc.GetPhone(id));
        }

        public PizzaDTO GetPizza(int id)
        {
            return PizzaMapper.MapToDTO(pssc.GetPizza(id));
        }

        public SauceDTO GetSauce(int id)
        {
            return SauceMapper.MapToDTO(pssc.GetSauce(id));
        }

        public SizeDTO GetSize(int id)
        {
            return SizeMapper.MapToDTO(pssc.GetSize(id));
        }

        public StoreDTO GetStore(int id)
        {
            return StoreMapper.MapToDTO(pssc.GetStore(id));
        }

        public VegetableDTO GetVegetable(int id)
        {
            return VegetableMapper.MapToDTO(pssc.GetVegetable(id));
        }

        public VegetableToppingDTO GetVegetableTopping(int id)
        {
            return VegetableToppingMapper.MapToDTO(pssc.GetVegetableTopping(id));
        }
        #endregion

        #region Change Items
        public bool ChangeAddress(AddressDTO item)
        {
            return pssc.ChangeAddress(AddressMapper.MapToDAO(item));
        }

        public bool ChangeCardPayment(CardPaymentDTO item)
        {
            return pssc.ChangeCardPayment(CardPaymentMapper.MapToDAO(item));
        }

        public bool ChangeCheese(CheeseDTO item)
        {
            return pssc.ChangeCheese(CheeseMapper.MapToDAO(item));
        }

        public bool ChangeCheeseTopping(CheeseToppingDTO item)
        {
            return pssc.ChangeCheeseTopping(CheeseToppingMapper.MapToDAO(item));
        }

        public bool ChangeCrust(CrustDTO item)
        {
            return pssc.ChangeCrust(CrustMapper.MapToDAO(item));
        }

        public bool ChangeCustomer(CustomerDTO item)
        {
            return pssc.ChangeCustomer(CustomerMapper.MapToDAO(item));
        }

        public bool ChangeEmail(EmailDTO item)
        {
            return pssc.ChangeEmail(EmailMapper.MapToDAO(item));
        }

        public bool ChangeHour(HoursDTO item)
        {
            return pssc.ChangeStoreHour(HoursMapper.MapToDAO(item));
        }

        public bool ChangeMeat(MeatDTO item)
        {
            return pssc.ChangeMeat(MeatMapper.MapToDAO(item));
        }

        public bool ChangeMeatTopping(MeatToppingDTO item)
        {
            return pssc.ChangeMeatTopping(MeatToppingMapper.MapToDAO(item));
        }

        public bool ChangeName(NameDTO item)
        {
            return pssc.ChangeName(NameMapper.MapToDAO(item));
        }

        public bool ChangeOrderDetail(OrderDetailsDTO item)
        {
            return pssc.ChangePizzaOrderDetail(OrderDetailMapper.MapToDAO(item));
        }

        public bool ChangeOrder(OrderDTO item)
        {
            return pssc.ChangePizzaOrder(OrderMapper.MapToDAO(item));
        }

        public bool ChangePaymentType(PaymentTypeDTO item)
        {
            return pssc.ChangePaymentType(PaymentTypeMapper.MapToDAO(item));
        }

        public bool ChangePhone(PhoneDTO item)
        {
            return pssc.ChangePhone(PhoneMapper.MapToDAO(item));
        }

        public bool ChangePizza(PizzaDTO item)
        {
            return pssc.ChangePizza(PizzaMapper.MapToDAO(item));
        }

        public bool ChangeSauce(SauceDTO item)
        {
            return pssc.ChangeSauce(SauceMapper.MapToDAO(item));
        }

        public bool ChangeSize(SizeDTO item)
        {
            return pssc.ChangeSize(SizeMapper.MapToDAO(item));
        }

        public bool ChangeStore(StoreDTO item)
        {
            return pssc.ChangeStore(StoreMapper.MapToDAO(item));
        }

        public bool ChangeVeChangeable(VegetableDTO item)
        {
            return pssc.ChangeVegetable(VegetableMapper.MapToDAO(item));
        }

        public bool ChangeVeChangeableTopping(VegetableToppingDTO item)
        {
            return pssc.ChangeVegetableTopping(VegetableToppingMapper.MapToDAO(item));
        }
        #endregion

        #region Delete Items
        public bool DeleteAddress(AddressDTO item)
        {
            return pssc.DeleteAddress(AddressMapper.MapToDAO(item));
        }

        public bool DeleteCardPayment(CardPaymentDTO item)
        {
            return pssc.DeleteCardPayment(CardPaymentMapper.MapToDAO(item));
        }

        public bool DeleteCheese(CheeseDTO item)
        {
            return pssc.DeleteCheese(CheeseMapper.MapToDAO(item));
        }

        public bool DeleteCheeseTopping(CheeseToppingDTO item)
        {
            return pssc.DeleteCheeseTopping(CheeseToppingMapper.MapToDAO(item));
        }

        public bool DeleteCrust(CrustDTO item)
        {
            return pssc.DeleteCrust(CrustMapper.MapToDAO(item));
        }

        public bool DeleteCustomer(CustomerDTO item)
        {
            return pssc.DeleteCustomer(CustomerMapper.MapToDAO(item));
        }

        public bool DeleteEmail(EmailDTO item)
        {
            return pssc.DeleteEmail(EmailMapper.MapToDAO(item));
        }

        public bool DeleteHour(HoursDTO item)
        {
            return pssc.DeleteStoreHour(HoursMapper.MapToDAO(item));
        }

        public bool DeleteMeat(MeatDTO item)
        {
            return pssc.DeleteMeat(MeatMapper.MapToDAO(item));
        }

        public bool DeleteMeatTopping(MeatToppingDTO item)
        {
            return pssc.DeleteMeatTopping(MeatToppingMapper.MapToDAO(item));
        }

        public bool DeleteName(NameDTO item)
        {
            return pssc.DeleteName(NameMapper.MapToDAO(item));
        }

        public bool DeleteOrderDetail(OrderDetailsDTO item)
        {
            return pssc.DeletePizzaOrderDetail(OrderDetailMapper.MapToDAO(item));
        }

        public bool DeleteOrder(OrderDTO item)
        {
            return pssc.DeletePizzaOrder(OrderMapper.MapToDAO(item));
        }

        public bool DeletePaymentType(PaymentTypeDTO item)
        {
            return pssc.DeletePaymentType(PaymentTypeMapper.MapToDAO(item));
        }

        public bool DeletePhone(PhoneDTO item)
        {
            return pssc.DeletePhone(PhoneMapper.MapToDAO(item));
        }

        public bool DeletePizza(PizzaDTO item)
        {
            return pssc.DeletePizza(PizzaMapper.MapToDAO(item));
        }

        public bool DeleteSauce(SauceDTO item)
        {
            return pssc.DeleteSauce(SauceMapper.MapToDAO(item));
        }

        public bool DeleteSize(SizeDTO item)
        {
            return pssc.DeleteSize(SizeMapper.MapToDAO(item));
        }

        public bool DeleteStore(StoreDTO item)
        {
            return pssc.DeleteStore(StoreMapper.MapToDAO(item));
        }

        public bool DeleteVeDeleteable(VegetableDTO item)
        {
            return pssc.DeleteVegetable(VegetableMapper.MapToDAO(item));
        }

        public bool DeleteVeDeleteableTopping(VegetableToppingDTO item)
        {
            return pssc.DeleteVegetableTopping(VegetableToppingMapper.MapToDAO(item));
        }
        #endregion

        #region Insert Items
        public bool InsertAddress(AddressDTO item)
        {
            return pssc.InsertAddress(AddressMapper.MapToDAO(item));
        }

        public bool InsertCardPayment(CardPaymentDTO item)
        {
            return pssc.InsertCardPayment(CardPaymentMapper.MapToDAO(item));
        }

        public bool InsertCheese(CheeseDTO item)
        {
            return pssc.InsertCheese(CheeseMapper.MapToDAO(item));
        }

        public bool InsertCheeseTopping(CheeseToppingDTO item)
        {
            return pssc.InsertCheeseTopping(CheeseToppingMapper.MapToDAO(item));
        }

        public bool InsertCrust(CrustDTO item)
        {
            return pssc.InsertCrust(CrustMapper.MapToDAO(item));
        }

        public bool InsertCustomer(CustomerDTO item)
        {
            return pssc.InsertCustomer(CustomerMapper.MapToDAO(item));
        }

        public bool InsertEmail(EmailDTO item)
        {
            return pssc.InsertEmail(EmailMapper.MapToDAO(item));
        }

        public bool InsertHour(HoursDTO item)
        {
            return pssc.InsertStoreHour(HoursMapper.MapToDAO(item));
        }

        public bool InsertMeat(MeatDTO item)
        {
            return pssc.InsertMeat(MeatMapper.MapToDAO(item));
        }

        public bool InsertMeatTopping(MeatToppingDTO item)
        {
            return pssc.InsertMeatTopping(MeatToppingMapper.MapToDAO(item));
        }

        public bool InsertName(NameDTO item)
        {
            return pssc.InsertName(NameMapper.MapToDAO(item));
        }

        public bool InsertOrderDetail(OrderDetailsDTO item)
        {
            return pssc.InsertPizzaOrderDetail(OrderDetailMapper.MapToDAO(item));
        }

        public bool InsertOrder(OrderDTO item)
        {
            return pssc.InsertPizzaOrder(OrderMapper.MapToDAO(item));
        }

        public bool InsertPaymentType(PaymentTypeDTO item)
        {
            return pssc.InsertPaymentType(PaymentTypeMapper.MapToDAO(item));
        }

        public bool InsertPhone(PhoneDTO item)
        {
            return pssc.InsertPhone(PhoneMapper.MapToDAO(item));
        }

        public bool InsertPizza(PizzaDTO item)
        {
            return pssc.InsertPizza(PizzaMapper.MapToDAO(item));
        }

        public bool InsertSauce(SauceDTO item)
        {
            return pssc.InsertSauce(SauceMapper.MapToDAO(item));
        }

        public bool InsertSize(SizeDTO item)
        {
            return pssc.InsertSize(SizeMapper.MapToDAO(item));
        }

        public bool InsertStore(StoreDTO item)
        {
            return pssc.InsertStore(StoreMapper.MapToDAO(item));
        }

        public bool InsertVegetable(VegetableDTO item)
        {
            return pssc.InsertVegetable(VegetableMapper.MapToDAO(item));
        }

        public bool InsertVegetableTopping(VegetableToppingDTO item)
        {
            return pssc.InsertVegetableTopping(VegetableToppingMapper.MapToDAO(item));
        }
        #endregion

        #region Extra Functions
        public Decimal GetPrice(SizeDTO size)
        {
            if (size.Name.ToLower() == "personal")
            {
                return 4.00m;
            }
            else if (size.Name.ToLower() == "small")
            {
                return 6.00m;
            }
            else if (size.Name.ToLower() == "medium")
            {
                return 8.00m;
            }
            else if (size.Name.ToLower() == "large")
            {
                return 10.00m;
            }

            return 0m;
        }

        public Decimal GetTotal(OrderDTO order)
        {
            Decimal currentTotal = 0.00m;

            foreach (var item in GetOrderDetails())
            {
                if(item.Order.Id == order.Id)
                {
                    currentTotal += GetPrice(item.Pizza.Size) * item.Pizza.Quantity;
                }
            }

            return currentTotal;
        }

        public bool CreatePizza(SizeDTO size, CrustDTO crust, SauceDTO sauce, CheeseDTO cheese, List<CheeseDTO> cheeses, List<MeatDTO> meats, List<VegetableDTO> vegetables, int quantity)
        {
            PizzaDTO pizza = new PizzaDTO { Size = size, Crust = crust, Sauce = sauce, Cheese = cheese, Quantity = quantity, Active = true };

            if (InsertPizza(pizza))
            {
                pizza = GetPizzas().Last();
                if (cheeses != null)
                {
                    foreach (var item in cheeses)
                    {
                        CheeseToppingDTO ct = new CheeseToppingDTO { Cheese = item, Pizza = pizza };
                        if (InsertCheeseTopping(ct))
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (meats != null)
                {
                    foreach (var item in meats)
                    {
                        MeatToppingDTO mt = new MeatToppingDTO { Meat = item, Pizza = pizza };
                        if (InsertMeatTopping(mt))
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (vegetables != null)
                {
                    foreach (var item in vegetables)
                    {
                        VegetableToppingDTO vt = new VegetableToppingDTO { Vegetable = item, Pizza = pizza };
                        if (InsertVegetableTopping(vt))
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
        #endregion
    }
}
