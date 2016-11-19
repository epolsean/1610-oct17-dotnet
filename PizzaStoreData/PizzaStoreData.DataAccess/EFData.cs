using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreData.DataAccess
{
    public class EFData
    {
        private PizzaStoreDBEntities db = new PizzaStoreDBEntities();

        #region Get List Functions
        public List<AddressDetail> GetAddressDetails()
        {
            return db.AddressDetails.ToList();
        }

        public List<CardPayment> GetCardPayments()
        {
            return db.CardPayments.ToList();
        }

        public List<Cheese> GetCheeses()
        {
            return db.Cheese.ToList();
        }

        public List<CheeseTopping> GetCheeseToppings()
        {
            return db.CheeseToppings.ToList();
        }

        public List<Crust> GetCrusts()
        {
            return db.Crusts.ToList();
        }

        public List<Customer> GetCustomers()
        {
            return db.Customers.ToList();
        }

        public List<Email> GetEmails()
        {
            return db.Emails.ToList();
        }

        public List<Meat> GetMeats()
        {
            return db.Meats.ToList();
        }

        public List<MeatTopping> GetMeatToppings()
        {
            return db.MeatToppings.ToList();
        }

        public List<Name> GetNames()
        {
            return db.Names.ToList();
        }

        public List<PaymentType> GetPaymentTypes()
        {
            return db.PaymentTypes.ToList();
        }

        public List<Phone> GetPhones()
        {
            return db.Phones.ToList();
        }

        public List<Pizza> GetPizzas()
        {
            return db.Pizzas.ToList();
        }

        public List<PizzaOrder> GetPizzaOrders()
        {
            return db.PizzaOrders.ToList();
        }

        public List<PizzaOrderDetail> GetPizzaOrderDetails()
        {
            return db.PizzaOrderDetails.ToList();
        }

        public List<Sauce> GetSauces()
        {
            return db.Sauces.ToList();
        }

        public List<Size> GetSizes()
        {
            return db.Sizes.ToList();
        }

        public List<Store> GetStores()
        {
            return db.Stores.ToList();
        }

        public List<StoreHour> GetStoreHours()
        {
            return db.StoreHours.ToList();
        }

        public List<Vegetable> GetVegetables()
        {
            return db.Vegetables.ToList();
        }

        public List<VegetableTopping> GetVegetableToppings()
        {
            return db.VegetableToppings.ToList();
        }
        #endregion

        #region Get Item Functions
        public AddressDetail GetAddressDetail(int id)
        {
            return db.AddressDetails.Where(ad => ad.AddressID == id).Single();
        }

        public CardPayment GetCardPayment(int id)
        {
            return db.CardPayments.Where(cp => cp.CardPaymentID == id).Single();
        }

        public Cheese GetCheese(int id)
        {
            return db.Cheese.Where(c => c.CheeseID == id).Single();
        }

        public CheeseTopping GetCheeseTopping(int id)
        {
            return db.CheeseToppings.Where(ct => ct.CheeseToppingID == id).Single();
        }

        public Crust GetCrust(int id)
        {
            return db.Crusts.Where(c => c.CrustID == id).Single();
        }

        public Customer GetCustomer(int id)
        {
            return db.Customers.Where(c => c.CustomerID == id).Single();
        }

        public Email GetEmail(int id)
        {
            return db.Emails.Where(e => e.EmailID == id).Single();
        }

        public Meat GetMeat(int id)
        {
            return db.Meats.Where(m => m.MeatID == id).Single();
        }

        public MeatTopping GetMeatTopping(int id)
        {
            return db.MeatToppings.Where(mt => mt.MeatToppingID == id).Single();
        }

        public Name GetName(int id)
        {
            return db.Names.Where(n => n.NameID == id).Single();
        }

        public PaymentType GetPaymentType(int id)
        {
            return db.PaymentTypes.Where(pt => pt.PaymentTypeID == id).Single();
        }

        public Phone GetPhone(int id)
        {
            return db.Phones.Where(p => p.PhoneID == id).Single();
        }

        public Pizza GetPizza(int id)
        {
            return db.Pizzas.Where(p => p.PizzaID == id).Single();
        }

        public PizzaOrder GetPizzaOrder(int id)
        {
            return db.PizzaOrders.Where(po => po.OrderID == id).Single();
        }

        public PizzaOrderDetail GetPizzaOrderDetail(int id)
        {
            return db.PizzaOrderDetails.Where(pod => pod.PizzaOrderDetatilsID == id).Single();
        }

        public Sauce GetSauce(int id)
        {
            return db.Sauces.Where(s => s.SauceID == id).Single();
        }

        public Size GetSize(int id)
        {
            return db.Sizes.Where(s => s.SizeID == id).Single();
        }

        public Store GetStore(int id)
        {
            return db.Stores.Where(s => s.StoreID == id).Single();
        }

        public StoreHour GetStoreHour(int id)
        {
            return db.StoreHours.Where(sh => sh.HoursID == id).Single();
        }

        public Vegetable GetVegetable(int id)
        {
            return db.Vegetables.Where(v => v.VegetableID == id).Single();
        }

        public VegetableTopping GetVegetableTopping(int id)
        {
            return db.VegetableToppings.Where(vt => vt.VegetableToppingID == id).Single();
        }
        #endregion

        #region Search Functions

        #endregion

        #region Insert Functions
        public bool InsertAddressDetail(AddressDetail newAddress)
        {
            db.AddressDetails.Add(newAddress);

            return db.SaveChanges() > 0;
        }

        public bool InsertCardPayment(CardPayment newCardPayment)
        {
            db.CardPayments.Add(newCardPayment);

            return db.SaveChanges() > 0;
        }

        public bool InsertCheese(Cheese newCheese)
        {
            db.Cheese.Add(newCheese);

            return db.SaveChanges() > 0;
        }

        public bool InsertCheeseTopping(CheeseTopping newCheeseTopping)
        {
            db.CheeseToppings.Add(newCheeseTopping);

            return db.SaveChanges() > 0;
        }

        public bool InsertCrust(Crust newCrust)
        {
            db.Crusts.Add(newCrust);

            return db.SaveChanges() > 0;
        }

        public bool InsertCustomer(Customer newCustomer)
        {
            db.Customers.Add(newCustomer);

            return db.SaveChanges() > 0;
        }

        public bool InsertEmail(Email newEmail)
        {
            db.Emails.Add(newEmail);

            return db.SaveChanges() > 0;
        }

        public bool InsertMeat(Meat newMeat)
        {
            db.Meats.Add(newMeat);

            return db.SaveChanges() > 0;
        }

        public bool InsertMeatTopping(MeatTopping newMeatTopping)
        {
            db.MeatToppings.Add(newMeatTopping);

            return db.SaveChanges() > 0;
        }

        public bool InsertName(Name newName)
        {
            db.Names.Add(newName);

            return db.SaveChanges() > 0;
        }

        public bool InsertPaymentType(PaymentType newPaymentType)
        {
            db.PaymentTypes.Add(newPaymentType);

            return db.SaveChanges() > 0;
        }

        public bool InsertPhone(Phone newPhone)
        {
            db.Phones.Add(newPhone);

            return db.SaveChanges() > 0;
        }

        public bool InsertPizza(Pizza newPizza)
        {
            db.Pizzas.Add(newPizza);

            return db.SaveChanges() > 0;
        }

        public bool InsertPizzaOrder(PizzaOrder newPizzaOrder)
        {
            db.PizzaOrders.Add(newPizzaOrder);

            return db.SaveChanges() > 0;
        }

        public bool InsertPizzaOrderDetail(PizzaOrderDetail newPizzaOrderDetail)
        {
            db.PizzaOrderDetails.Add(newPizzaOrderDetail);

            return db.SaveChanges() > 0;
        }

        public bool InsertSauce(Sauce newSauce)
        {
            db.Sauces.Add(newSauce);

            return db.SaveChanges() > 0;
        }

        public bool InsertSize(Size newSize)
        {
            db.Sizes.Add(newSize);

            return db.SaveChanges() > 0;
        }

        public bool InsertStore(Store newStore)
        {
            db.Stores.Add(newStore);

            return db.SaveChanges() > 0;
        }

        public bool InsertStoreHour(StoreHour newStoreHour)
        {
            db.StoreHours.Add(newStoreHour);

            return db.SaveChanges() > 0;
        }

        public bool InsertVegetable(Vegetable newVegetable)
        {
            db.Vegetables.Add(newVegetable);

            return db.SaveChanges() > 0;
        }

        public bool InsertVegetableTopping(VegetableTopping newVegetableTopping)
        {
            db.VegetableToppings.Add(newVegetableTopping);

            return db.SaveChanges() > 0;
        }
        #endregion

        #region Modified Functions
        public bool ChangeAddressDetail(AddressDetail addressDetail)
        {
            if (db.AddressDetails.Where(ad => ad.AddressID == addressDetail.AddressID).Count() != 0)
            {
                var entry = db.Entry<AddressDetail>(addressDetail);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeCardPayment(CardPayment cardPayment)
        {
            if (db.CardPayments.Where(cp => cp.CardPaymentID == cardPayment.CardPaymentID).Count() != 0)
            {
                var entry = db.Entry<CardPayment>(cardPayment);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeCheese(Cheese cheese)
        {
            if (db.Cheese.Where(c => c.CheeseID == cheese.CheeseID).Count() != 0)
            {
                var entry = db.Entry<Cheese>(cheese);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeCheeseTopping(CheeseTopping cheeseTopping)
        {
            if (db.CheeseToppings.Where(ct => ct.CheeseToppingID == cheeseTopping.CheeseToppingID).Count() != 0)
            {
                var entry = db.Entry<CheeseTopping>(cheeseTopping);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeCrust(Crust crust)
        {
            if (db.Crusts.Where(c => c.CrustID == crust.CrustID).Count() != 0)
            {
                var entry = db.Entry<Crust>(crust);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeCustomer(Customer customer)
        {
            if (db.Customers.Where(c => c.CustomerID == customer.CustomerID).Count() != 0)
            {
                var entry = db.Entry<Customer>(customer);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeEmail(Email email)
        {
            if (db.Emails.Where(e => e.EmailID == email.EmailID).Count() != 0)
            {
                var entry = db.Entry<Email>(email);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeMeat(Meat meat)
        {
            if (db.Meats.Where(m => m.MeatID == meat.MeatID).Count() != 0)
            {
                var entry = db.Entry<Meat>(meat);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeMeatTopping(MeatTopping meatTopping)
        {
            if (db.MeatToppings.Where(mt => mt.MeatToppingID == meatTopping.MeatToppingID).Count() != 0)
            {
                var entry = db.Entry<MeatTopping>(meatTopping);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeName(Name name)
        {
            if (db.Names.Where(n => n.NameID == name.NameID).Count() != 0)
            {
                var entry = db.Entry<Name>(name);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangePaymentType(PaymentType paymentType)
        {
            if (db.PaymentTypes.Where(pt => pt.PaymentTypeID == paymentType.PaymentTypeID).Count() != 0)
            {
                var entry = db.Entry<PaymentType>(paymentType);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangePhone(Phone phone)
        {
            if (db.Phones.Where(p => p.PhoneID == phone.PhoneID).Count() != 0)
            {
                var entry = db.Entry<Phone>(phone);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangePizza(Pizza pizza)
        {
            if (db.Pizzas.Where(p => p.PizzaID == pizza.PizzaID).Count() != 0)
            {
                var entry = db.Entry<Pizza>(pizza);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangePizzaOrder(PizzaOrder pizzaOrder)
        {
            if (db.PizzaOrders.Where(po => po.OrderID == pizzaOrder.OrderID).Count() != 0)
            {
                var entry = db.Entry<PizzaOrder>(pizzaOrder);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangePizzaOrderDetail(PizzaOrderDetail pizzaOrderDetail)
        {
            if (db.PizzaOrderDetails.Where(pod => pod.PizzaOrderDetatilsID == pizzaOrderDetail.PizzaOrderDetatilsID).Count() != 0)
            {
                var entry = db.Entry<PizzaOrderDetail>(pizzaOrderDetail);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeSauce(Sauce sauce)
        {
            if (db.Sauces.Where(s => s.SauceID == sauce.SauceID).Count() != 0)
            {
                var entry = db.Entry<Sauce>(sauce);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeSize(Size size)
        {
            if (db.Sizes.Where(s => s.SizeID == size.SizeID).Count() != 0)
            {
                var entry = db.Entry<Size>(size);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeStore(Store store)
        {
            if (db.Stores.Where(s => s.StoreID == store.StoreID).Count() != 0)
            {
                var entry = db.Entry<Store>(store);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeStoreHour(StoreHour storeHour)
        {
            if (db.StoreHours.Where(sh => sh.HoursID == storeHour.HoursID).Count() != 0)
            {
                var entry = db.Entry<StoreHour>(storeHour);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeVegetable(Vegetable vegetable)
        {
            if (db.Vegetables.Where(v => v.VegetableID == vegetable.VegetableID).Count() != 0)
            {
                var entry = db.Entry<Vegetable>(vegetable);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }

        public bool ChangeVegetableTopping(VegetableTopping vegetableTopping)
        {
            if (db.VegetableToppings.Where(vt => vt.VegetableToppingID == vegetableTopping.VegetableToppingID).Count() != 0)
            {
                var entry = db.Entry<VegetableTopping>(vegetableTopping);

                entry.State = EntityState.Modified;
            }

            return db.SaveChanges() > 0;
        }
        #endregion

        #region Delete Function
        public bool DeleteAddressDetail(AddressDetail addressDetail)
        {
            if (db.AddressDetails.Where(ad => ad == addressDetail).Count() != 0)
            {
                var entry = db.Entry<AddressDetail>(addressDetail);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteCardPayment(CardPayment cardPayment)
        {
            if (db.CardPayments.Where(cp => cp == cardPayment).Count() != 0)
            {
                var entry = db.Entry<CardPayment>(cardPayment);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteCheese(Cheese cheese)
        {
            if (db.Cheese.Where(c => c == cheese).Count() != 0)
            {
                var entry = db.Entry<Cheese>(cheese);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteCheeseTopping(CheeseTopping cheeseTopping)
        {
            if (db.CheeseToppings.Where(ct => ct == cheeseTopping).Count() != 0)
            {
                var entry = db.Entry<CheeseTopping>(cheeseTopping);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteCrust(Crust crust)
        {
            if (db.Crusts.Where(c => c == crust).Count() != 0)
            {
                var entry = db.Entry<Crust>(crust);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteCustomer(Customer customer)
        {
            if (db.Customers.Where(c => c == customer).Count() != 0)
            {
                var entry = db.Entry<Customer>(customer);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteEmail(Email email)
        {
            if (db.Emails.Where(e => e == email).Count() != 0)
            {
                var entry = db.Entry<Email>(email);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteMeat(Meat meat)
        {
            if (db.Meats.Where(m => m == meat).Count() != 0)
            {
                var entry = db.Entry<Meat>(meat);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteMeatTopping(MeatTopping meatTopping)
        {
            if (db.MeatToppings.Where(mt => mt == meatTopping).Count() != 0)
            {
                var entry = db.Entry<MeatTopping>(meatTopping);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteName(Name name)
        {
            if (db.Names.Where(n => n == name).Count() != 0)
            {
                var entry = db.Entry<Name>(name);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeletePaymentType(PaymentType paymentType)
        {
            if (db.PaymentTypes.Where(pt => pt == paymentType).Count() != 0)
            {
                var entry = db.Entry<PaymentType>(paymentType);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeletePhone(Phone phone)
        {
            if (db.Phones.Where(p => p == phone).Count() != 0)
            {
                var entry = db.Entry<Phone>(phone);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeletePizza(Pizza pizza)
        {
            if (db.Pizzas.Where(p => p == pizza).Count() != 0)
            {
                var entry = db.Entry<Pizza>(pizza);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeletePizzaOrder(PizzaOrder pizzaOrder)
        {
            if (db.PizzaOrders.Where(po => po == pizzaOrder).Count() != 0)
            {
                var entry = db.Entry<PizzaOrder>(pizzaOrder);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeletePizzaOrderDetail(PizzaOrderDetail pizzaOrderDetail)
        {
            if (db.PizzaOrderDetails.Where(pod => pod == pizzaOrderDetail).Count() != 0)
            {
                var entry = db.Entry<PizzaOrderDetail>(pizzaOrderDetail);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteSauce(Sauce sauce)
        {
            if (db.Sauces.Where(s => s == sauce).Count() != 0)
            {
                var entry = db.Entry<Sauce>(sauce);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteSize(Size size)
        {
            if (db.Sizes.Where(s => s == size).Count() != 0)
            {
                var entry = db.Entry<Size>(size);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteStore(Store store)
        {
            if (db.Stores.Where(s => s == store).Count() != 0)
            {
                var entry = db.Entry<Store>(store);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteStoreHour(StoreHour storeHour)
        {
            if (db.StoreHours.Where(sh => sh == storeHour).Count() != 0)
            {
                var entry = db.Entry<StoreHour>(storeHour);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteVegetable(Vegetable vegetable)
        {
            if (db.Vegetables.Where(v => v == vegetable).Count() != 0)
            {
                var entry = db.Entry<Vegetable>(vegetable);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }

        public bool DeleteVegetableTopping(VegetableTopping vegetableTopping)
        {
            if (db.VegetableToppings.Where(vt => vt == vegetableTopping).Count() != 0)
            {
                var entry = db.Entry<VegetableTopping>(vegetableTopping);

                entry.State = EntityState.Deleted;
            }

            return db.SaveChanges() > 0;
        }
        #endregion
    }
}
