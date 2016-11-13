create schema PizzaStore;
go

create table PizzaStore.Pizza
(
	PizzaID int not null identity(1,1)
	,SizeID int not null
	,CrustID int not null
	,SauceID int null
	,CheeseID int null
	,Quantity int not null
	,Active bit not null
);
go

create table PizzaStore.Size
(
	SizeID int not null identity(1,1)
	,SizeType nvarchar(250) not null
	,Active bit not null
);
go

create table PizzaStore.Crust
(
	CrustID int not null identity(1,1)
	,CrustType nvarchar(250) not null
	,Active bit not null
);
go

create table PizzaStore.Sauce
(
	SauceID int not null identity(1,1)
	,SauceType nvarchar(250) not null
	,Active bit not null
);
go

create table PizzaStore.Cheese
(
	CheeseID int not null identity(1,1)
	,CheeseType nvarchar(250) not null
	,Active bit not null
);
go

create table PizzaStore.Meat
(
	MeatID int not null identity(1,1)
	,MeatType nvarchar(250) not null
	,Active bit not null
);
go

create table PizzaStore.Vegetable
(
	VegetableID int not null identity(1,1)
	,VegetableType nvarchar(250) not null
	,Active bit not null
);
go

create table PizzaStore.CheeseToppings
(
	CheeseToppingID int not null identity(1,1)
	,PizzaID int not null
	,CheeseID int not null
	,Active bit not null
);
go

 create table PizzaStore.MeatToppings
(
	MeatToppingID int not null identity(1,1)
	,PizzaID int not null
	,MeatID int not null
	,Active bit not null
);
go

 create table PizzaStore.VegetableToppings
(
	VegetableToppingID int not null identity(1,1)
	,PizzaID int not null
	,VegetableID int not null
	,Active bit not null
);
go

create table PizzaStore.Customer
(
	CustomerID int not null identity(1,1)
	,NameID int not null
	,AddressID int not null
	,EmailID int not null
	,PhoneID int not null
	,Active bit not null
);
go

create table PizzaStore.Name
(
	NameID int not null identity(1,1)
	,FirstName nvarchar(250) not null
	,LastName nvarchar(250) not null
	,Active bit not null
);
go

create table PizzaStore.Email
(
	EmailID int not null identity(1,1)
	,Email nvarchar(250) not null
	,Active bit not null
);
go

create table PizzaStore.Phone
(
	PhoneID int not null identity(1,1)
	,PhoneNumber nvarchar(11) not null
	,Active bit not null
);
go

create table PizzaStore.AddressDetails
(
	AddressID int not null identity(1,1)
	,Address1 nvarchar(250) not null
	,Address2 nvarchar(250) null
	,CityName nvarchar(250) not null
	,StateName nvarchar(250) not null
	,Zipcode int not null
	,Active bit not null
);
go

create table PizzaStore.PizzaOrder
(
	OrderID int not null identity(1,1)
	,CustomerID int not null
	,StoreID int not null
	,PaymentTypeID int not null
	,Active bit not null
);
go

create table PizzaStore.PizzaOrderDetails
(
	PizzaOrderDetatilsID int not null identity(1,1)
	,PizzaID int not null
	,OrderID int not null
	,Active bit not null
);
go

create table PizzaStore.CardPayment
(
	CardPaymentID int not null identity(1,1)
	,CustomerID int not null
	,CardNumber nvarchar(16) not null
	,CardHolderName nvarchar(250) not null
	,ExpirationDate int not null
	,CVC int not null
	,Active bit not null
);
go

create table PizzaStore.PaymentType
(
	PaymentTypeID int not null identity(1,1)
	,PaymentType nvarchar(250) not null
	,Active bit not null
);
go

create table PizzaStore.Store
(
	StoreID int not null identity(1,1)
	,AddressID int not null
	,PhoneID int not null
	,HoursID int not null
	,Active bit not null
);
go

create table PizzaStore.StoreHours
(
	HoursID int not null identity(1,1)
	,StartTime int not null
	,EndTime int not null
	,Active bit not null
);
go

alter table PizzaStore.Pizza
	add constraint pk_pizza_pizzaid primary key clustered (PizzaID);
go

alter table PizzaStore.Size
	add constraint pk_size_sizeid primary key clustered (SizeID);
go

alter table PizzaStore.Crust
	add constraint pk_crust_crustid primary key clustered (CrustID);
go

alter table PizzaStore.Sauce
	add constraint pk_sauce_sauceid primary key clustered (SauceID);
go

alter table PizzaStore.Cheese
	add constraint pk_cheese_cheeseid primary key clustered (CheeseID);
go

alter table PizzaStore.Meat
	add constraint pk_meat_meatid primary key clustered (MeatID);
go

alter table PizzaStore.Vegetable
	add constraint pk_vegetable_vegetableid primary key clustered (VegetableID);
go

alter table PizzaStore.CheeseToppings
	add constraint pk_cheesetoppings_cheesetoppingid primary key clustered (CheeseToppingID);
go

alter table PizzaStore.MeatToppings
	add constraint pk_meattoppings_meattoppingid primary key clustered (MeatToppingID);
go

alter table PizzaStore.VegetableToppings
	add constraint pk_vegetabletoppings_vegetabletoppingid primary key clustered (VegetableToppingID);
go

alter table PizzaStore.Customer
	add constraint pk_customer_customerid primary key clustered (CustomerID);
go

alter table PizzaStore.Name
	add constraint pk_name_nameid primary key clustered (NameID);
go

alter table PizzaStore.Email
	add constraint pk_email_emailid primary key clustered (EmailID);
go

alter table PizzaStore.Phone
	add constraint pk_phone_phoneid primary key clustered (PhoneID);
go

alter table PizzaStore.AddressDetails
	add constraint pk_addressdetails_addressid primary key clustered (AddressID);
go

alter table PizzaStore.PizzaOrder
	add constraint pk_pizzaorder_orderid primary key clustered (OrderID);
go

alter table PizzaStore.PizzaOrderDetails
	add constraint pk_pizzaorderdetails_pizzaorderdetailsid primary key clustered (PizzaOrderDetatilsID);
go

alter table PizzaStore.CardPayment
	add constraint pk_cardpayment_cardpaymentid primary key clustered (CardPaymentID);
go

alter table PizzaStore.PaymentType
	add constraint pk_paymenttype_paymenttypeid primary key clustered (PaymentTypeID);
go

alter table PizzaStore.Store
	add constraint pk_store_storeid primary key clustered (StoreID);
go

alter table PizzaStore.StoreHours
	add constraint pk_storehours_hoursid primary key clustered (HoursID);
go

alter table PizzaStore.Pizza
	add constraint fk_pizza_sizeid foreign key (SizeID) references PizzaStore.Size (SizeID);
go

alter table PizzaStore.Pizza
	add constraint fk_pizza_crustid foreign key (CrustID) references PizzaStore.Crust (CrustID);
go

alter table PizzaStore.Pizza
	add constraint fk_pizza_sauceid foreign key (SauceID) references PizzaStore.Sauce (SauceID);
go

alter table PizzaStore.Pizza
	add constraint fk_pizza_cheeseid foreign key (CheeseID) references PizzaStore.Cheese (CheeseID);
go

alter table PizzaStore.CheeseToppings
	add constraint fk_cheesetopping_pizzaid foreign key (PizzaID) references PizzaStore.Pizza (PizzaID);
go

alter table PizzaStore.CheeseToppings
	add constraint fk_cheesetopping_cheeseid foreign key (CheeseID) references PizzaStore.Cheese (CheeseID);
go

alter table PizzaStore.MeatToppings
	add constraint fk_meattopping_pizzaid foreign key (PizzaID) references PizzaStore.Pizza (PizzaID);
go

alter table PizzaStore.MeatToppings
	add constraint fk_meattopping_meatid foreign key (MeatID) references PizzaStore.Meat (MeatID);
go

alter table PizzaStore.VegetableToppings
	add constraint fk_vegetabletopping_pizzaid foreign key (PizzaID) references PizzaStore.Pizza (PizzaID);
go

alter table PizzaStore.VegetableToppings
	add constraint fk_vegetabletopping_vegetableid foreign key (VegetableID) references PizzaStore.Vegetable (VegetableID);
go

alter table PizzaStore.Customer
	add constraint fk_customer_nameid foreign key (NameID) references PizzaStore.Name (NameID);
go

alter table PizzaStore.Customer
	add constraint fk_customer_addressid foreign key (AddressID) references PizzaStore.AddressDetails (AddressID);
go

alter table PizzaStore.Customer
	add constraint fk_customer_emailid foreign key (EmailID) references PizzaStore.Email (EmailID);
go

alter table PizzaStore.Customer
	add constraint fk_customer_phoneid foreign key (PhoneID) references PizzaStore.Phone (PhoneID);
go

alter table PizzaStore.PizzaOrder
	add constraint fk_pizzaorder_customerid foreign key (CustomerID) references PizzaStore.Customer (CustomerID);
go

alter table PizzaStore.PizzaOrder
	add constraint fk_pizzaorder_storeid foreign key (StoreID) references PizzaStore.Store (StoreID);
go

alter table PizzaStore.PizzaOrder
	add constraint fk_pizzaorder_paymenttypeid foreign key (PaymentTypeID) references PizzaStore.PaymentType (PaymentTypeID);
go

alter table PizzaStore.PizzaOrderDetails
	add constraint fk_pizzaorderdetails_pizzaid foreign key (PizzaID) references PizzaStore.Pizza (PizzaID);
go

alter table PizzaStore.PizzaOrderDetails
	add constraint fk_pizzaorderdetails_orderid foreign key (OrderID) references PizzaStore.PizzaOrder (OrderID);
go

alter table PizzaStore.CardPayment
	add constraint fk_cardpayment_customerid foreign key (CustomerID) references PizzaStore.Customer (CustomerID);
go

alter table PizzaStore.Store
	add constraint fk_store_addressid foreign key (AddressID) references PizzaStore.AddressDetails (AddressID);
go

alter table PizzaStore.Store
	add constraint fk_store_phoneid foreign key (PhoneID) references PizzaStore.Phone (PhoneID);
go

alter table PizzaStore.Store
	add constraint fk_store_hoursid foreign key (HoursID) references PizzaStore.StoreHours (HoursID);
go
