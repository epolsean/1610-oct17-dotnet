/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

insert into PizzaStore.Size(SizeType, Active)
values ('Personal', 1), ('Small', 1), ('Medium', 1), ('Large', 1);
go

insert into PizzaStore.Crust(CrustType, Active)
values ('Hand Tossed', 1),  ('Pan', 1), ('Thin', 1), ('Stuffed Crust', 1), ('Deep Dish', 1), ('Brooklyn', 1);
go

insert into PizzaStore.Sauce(SauceType, Active)
values ('Marinara', 1), ('Tomato', 1), ('Alfredo', 1), ('Barbeque', 1), ('Buffalo', 1);
go

insert into PizzaStore.Cheese(CheeseType, Active)
values ('Mozzarella', 1), ('Chedder', 1), ('Parmesan', 1), ('Feta', 1), ('Provolone', 1), ('Colby Jack', 1), ('4 Cheese Blend', 1);
go

insert into PizzaStore.Meat(MeatType, Active)
values ('Pepperoni', 1), ('Italian Sausage', 1), ('Salami', 1), ('Meatball', 1), ('Canadian Bacon', 1), ('Bacon', 1), ('Grilled Chicken', 1), ('Beef', 1), ('Pork', 1), ('Philly Steak', 1), ('Anchovies', 1);
go

insert into PizzaStore.Vegetable(VegetableType, Active)
values ('Mushrooms', 1), ('Spinach', 1), ('Cherry Peppers', 1), ('Red Onions', 1), ('Black Olives', 1), ('Green Bell Peppers', 1), ('Red Bell Peppers', 1), ('Banana Peppers', 1), ('Pineapple', 1), ('Jalapeno Peppers', 1), ('Diced Tomatoes', 1);
go

insert into PizzaStore.Pizza(SizeID, CrustID, SauceID, CheeseID, Quantity, Active)
values (3, 1, 1, 1, 1, 1), (4, 5, 2, 7, 1, 1), (1, 3, 4, 5, 2, 1);
go 

insert into PizzaStore.CheeseToppings(PizzaID, CheeseID, Active)
values (1, 2, 1);
go

insert into PizzaStore.MeatToppings(PizzaID, MeatID, Active)
values (1, 1, 1), (1, 2, 1), (1, 5, 1), (1, 7, 1), (1, 8, 1), (1, 9, 1), (2, 1, 1), (2, 2, 1), (3, 7, 1);
go

insert into PizzaStore.VegetableToppings(PizzaID, VegetableID, Active)
values (2, 1, 1), (2, 4, 1), (2, 5, 1), (2, 6, 1), (2, 7, 1), (3, 2, 1), (3, 4, 1);
go

insert into PizzaStore.Name(FirstName, LastName, Active)
values ('Sam', 'Choo', 1), ('Alex', 'Roff', 1), ('Richard', 'Voelker', 1), ('Raymond', 'Konopka', 1), ('Fred', 'Belotte', 1), ('Erik', 'Polsean', 1);
go

insert into PizzaStore.Email(Email, Active)
values ('schoo@internet.com', 1), ('aroff@internet.com', 1), ('rvoelker@internet.com', 1), ('rkonopka@internet.com', 1), ('fbelotte@internet.com', 1), ('epolsean@internet.com', 1);
go

insert into PizzaStore.Phone(PhoneNumber, Active)
values ('5553452689', 1), ('5558450923', 1), ('5550892341', 1), ('5553234894', 1), ('5551059382', 1), ('5552038475', 1), ('5554443322', 1), ('5553249860', 1);
go

insert into PizzaStore.AddressDetails(Address1, Address2, CityName, StateName, Zipcode, Active)
values ('2320 Dulles Station Blvd.', 'Apt # 1432', 'Herndon', 'Virginia', 20171, 1), ('1337 Salt Road', null, 'Reston', 'Virginia', 20190, 1), ('533 Sharp Drive', 'Ste # 16', 'Fairfax', 'Virginia', 20151, 1), ('132 Italy Court', null, 'Herndon', 'Virginia', 20171, 1), ('745 Chicago Avenue', null, 'Fairfax', 'Virginia', 20151, 1);
go

insert into PizzaStore.Customer(NameID, AddressID, EmailID, PhoneID, Active)
values (1, 2, 1, 1, 1), (2, 2, 2, 2, 1), (3, 1, 3, 3, 1), (4, 1, 4, 4, 1), (5, 3, 5, 5, 1), (6, 1, 6, 6, 1);
go

insert into PizzaStore.CardPayment(CustomerID, CardNumber, CardHolderName, ExpirationDate, CVC, Active)
values (1, '0000111100001234', 'Sam Choo', 0719, 010, 1), (4, '1840221103351604', 'Raymond Konopka', 0517, 951, 1), (5, '2200541103671034', 'Fred Belotte', 1118, 462, 1);
go

insert into PizzaStore.PaymentType(PaymentType, Active)
values ('Cash', 1), ('Credit/Debit', 1);
go

insert into PizzaStore.StoreHours(StartTime, EndTime, Active)
values (11, 0, 1), (9, 3, 1);

insert into PizzaStore.Store(AddressID, PhoneID, HoursID, Active)
values (4, 7, 1, 1), (5, 8, 2, 1);
go

insert into PizzaStore.PizzaOrder(CustomerID, StoreID, PaymentTypeID, Active)
values (1, 1, 2, 1), (2, 1, 1, 1), (3, 1, 1, 1), (4, 1, 2, 1), (5, 2, 2, 1), (6, 1, 1, 1);
go

insert into PizzaStore.PizzaOrderDetails(PizzaID, OrderID, Active)
values (3, 1, 1), (1, 2, 1), (2, 3, 1), (3, 4, 1), (2, 5, 1), (1, 6, 1);
go
