using PizzaStoreData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PizzaStoreData.DataClient
{
    [ServiceContract]
    public interface IPizzaStoreService
    {
        #region Get Lists
        [OperationContract]
        List<AddressDetailDAO> GetAddresses();

        [OperationContract]
        List<CardPaymentDAO> GetCardPayments();

        [OperationContract]
        List<CheeseDAO> GetCheeses();

        [OperationContract]
        List<CheeseToppingDAO> GetCheeseToppings();

        [OperationContract]
        List<CrustDAO> GetCrusts();

        [OperationContract]
        List<CustomerDAO> GetCustomers();

        [OperationContract]
        List<EmailDAO> GetEmails();

        [OperationContract]
        List<MeatDAO> GetMeats();

        [OperationContract]
        List<MeatToppingDAO> GetMeatToppings();

        [OperationContract]
        List<NameDAO> GetNames();

        [OperationContract]
        List<PaymentTypeDAO> GetPaymentTypes();

        [OperationContract]
        List<PhoneDAO> GetPhones();

        [OperationContract]
        List<PizzaDAO> GetPizzas();

        [OperationContract]
        List<PizzaOrderDAO> GetPizzaOrders();

        [OperationContract]
        List<PizzaOrderDetailDAO> GetPizzaOrderDetails();

        [OperationContract]
        List<SauceDAO> GetSauces();

        [OperationContract]
        List<SizeDAO> GetSizes();

        [OperationContract]
        List<StoreDAO> GetStores();

        [OperationContract]
        List<StoreHourDAO> GetStoreHours();

        [OperationContract]
        List<VegetableDAO> GetVegetables();

        [OperationContract]
        List<VegetableToppingDAO> GetVegetableToppings();
        #endregion

        #region Get Items
        [OperationContract]
        AddressDetailDAO GetAddress(int id);

        [OperationContract]
        CardPaymentDAO GetCardPayment(int id);

        [OperationContract]
        CheeseDAO GetCheese(int id);

        [OperationContract]
        CheeseToppingDAO GetCheeseTopping(int id);

        [OperationContract]
        CrustDAO GetCrust(int id);

        [OperationContract]
        CustomerDAO GetCustomer(int id);

        [OperationContract]
        EmailDAO GetEmail(int id);

        [OperationContract]
        MeatDAO GetMeat(int id);

        [OperationContract]
        MeatToppingDAO GetMeatTopping(int id);

        [OperationContract]
        NameDAO GetName(int id);

        [OperationContract]
        PaymentTypeDAO GetPaymentType(int id);

        [OperationContract]
        PhoneDAO GetPhone(int id);

        [OperationContract]
        PizzaDAO GetPizza(int id);

        [OperationContract]
        PizzaOrderDAO GetPizzaOrder(int id);

        [OperationContract]
        PizzaOrderDetailDAO GetPizzaOrderDetail(int id);

        [OperationContract]
        SauceDAO GetSauce(int id);

        [OperationContract]
        SizeDAO GetSize(int id);

        [OperationContract]
        StoreDAO GetStore(int id);

        [OperationContract]
        StoreHourDAO GetStoreHour(int id);

        [OperationContract]
        VegetableDAO GetVegetable(int id);
    
        [OperationContract]
        VegetableToppingDAO GetVegetableTopping(int id);
        #endregion

        #region Insert Items
        [OperationContract]
        bool InsertAddress(AddressDetailDAO address);

        [OperationContract]
        bool InsertCardPayment(CardPaymentDAO cardPayment);

        [OperationContract]
        bool InsertCheese(CheeseDAO cheese);

        [OperationContract]
        bool InsertCheeseTopping(CheeseToppingDAO topping);

        [OperationContract]
        bool InsertCrust(CrustDAO crust);

        [OperationContract]
        bool InsertCustomer(CustomerDAO customer);

        [OperationContract]
        bool InsertEmail(EmailDAO email);

        [OperationContract]
        bool InsertMeat(MeatDAO meat);

        [OperationContract]
        bool InsertMeatTopping(MeatToppingDAO topping);

        [OperationContract]
        bool InsertName(NameDAO name);

        [OperationContract]
        bool InsertPaymentType(PaymentTypeDAO paymentType);

        [OperationContract]
        bool InsertPhone(PhoneDAO phone);

        [OperationContract]
        bool InsertPizza(PizzaDAO pizza);

        [OperationContract]
        bool InsertPizzaOrder(PizzaOrderDAO order);

        [OperationContract]
        bool InsertPizzaOrderDetail(PizzaOrderDetailDAO orderDetails);

        [OperationContract]
        bool InsertSauce(SauceDAO sauce);

        [OperationContract]
        bool InsertSize(SizeDAO size);

        [OperationContract]
        bool InsertStore(StoreDAO store);

        [OperationContract]
        bool InsertStoreHour(StoreHourDAO hours);

        [OperationContract]
        bool InsertVegetable(VegetableDAO vegetable);

        [OperationContract]
        bool InsertVegetableTopping(VegetableToppingDAO topping);
        #endregion

        #region Change Items
        [OperationContract]
        bool ChangeAddress(AddressDetailDAO address);

        [OperationContract]
        bool ChangeCardPayment(CardPaymentDAO cardPayment);

        [OperationContract]
        bool ChangeCheese(CheeseDAO cheese);

        [OperationContract]
        bool ChangeCheeseTopping(CheeseToppingDAO topping);

        [OperationContract]
        bool ChangeCrust(CrustDAO crust);

        [OperationContract]
        bool ChangeCustomer(CustomerDAO customer);

        [OperationContract]
        bool ChangeEmail(EmailDAO email);

        [OperationContract]
        bool ChangeMeat(MeatDAO meat);

        [OperationContract]
        bool ChangeMeatTopping(MeatToppingDAO topping);

        [OperationContract]
        bool ChangeName(NameDAO name);

        [OperationContract]
        bool ChangePaymentType(PaymentTypeDAO paymentType);

        [OperationContract]
        bool ChangePhone(PhoneDAO phone);

        [OperationContract]
        bool ChangePizza(PizzaDAO pizza);

        [OperationContract]
        bool ChangePizzaOrder(PizzaOrderDAO order);

        [OperationContract]
        bool ChangePizzaOrderDetail(PizzaOrderDetailDAO orderDetails);

        [OperationContract]
        bool ChangeSauce(SauceDAO sauce);

        [OperationContract]
        bool ChangeSize(SizeDAO size);

        [OperationContract]
        bool ChangeStore(StoreDAO store);

        [OperationContract]
        bool ChangeStoreHour(StoreHourDAO hours);

        [OperationContract]
        bool ChangeVegetable(VegetableDAO vegetable);

        [OperationContract]
        bool ChangeVegetableTopping(VegetableToppingDAO topping);
        #endregion

        #region Delete Items
        [OperationContract]
        bool DeleteAddress(AddressDetailDAO address);

        [OperationContract]
        bool DeleteCardPayment(CardPaymentDAO cardPayment);

        [OperationContract]
        bool DeleteCheese(CheeseDAO cheese);

        [OperationContract]
        bool DeleteCheeseTopping(CheeseToppingDAO topping);

        [OperationContract]
        bool DeleteCrust(CrustDAO crust);

        [OperationContract]
        bool DeleteCustomer(CustomerDAO customer);

        [OperationContract]
        bool DeleteEmail(EmailDAO email);

        [OperationContract]
        bool DeleteMeat(MeatDAO meat);

        [OperationContract]
        bool DeleteMeatTopping(MeatToppingDAO topping);

        [OperationContract]
        bool DeleteName(NameDAO name);

        [OperationContract]
        bool DeletePaymentType(PaymentTypeDAO paymentType);

        [OperationContract]
        bool DeletePhone(PhoneDAO phone);

        [OperationContract]
        bool DeletePizza(PizzaDAO pizza);

        [OperationContract]
        bool DeletePizzaOrder(PizzaOrderDAO order);

        [OperationContract]
        bool DeletePizzaOrderDetail(PizzaOrderDetailDAO orderDetails);

        [OperationContract]
        bool DeleteSauce(SauceDAO sauce);

        [OperationContract]
        bool DeleteSize(SizeDAO size);

        [OperationContract]
        bool DeleteStore(StoreDAO store);

        [OperationContract]
        bool DeleteStoreHour(StoreHourDAO hours);

        [OperationContract]
        bool DeleteVegetable(VegetableDAO vegetable);

        [OperationContract]
        bool DeleteVegetableTopping(VegetableToppingDAO topping);
        #endregion
    }
}
