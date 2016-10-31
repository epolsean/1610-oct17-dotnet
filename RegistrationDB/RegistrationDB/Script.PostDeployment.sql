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

insert into Registration.PersonType(PersonType, Active)
values ('Student', 1), ('Professor', 1);
go

insert into Registration.Person(FirstName, LastName, PersonType, Active)
values ('Sam', 'Choo', 1, 1), ('Richard', 'Voelker', 1, 1), ('Alexavier', 'Roff', 2, 1), ('Raymond', 'Konopka', 1, 1), ('Erik', 'Polsean', 2, 1), ('Jean', 'Gray', 1, 1), ('Wade', 'Wilson', 1, 1);
go

insert into Registration.Course(Title, Department, Professor, StartTime, EndTime, Capacity, Credit, Active)
values ('CS-101', 'Computer Science', 5, 10, 11, 35, 3, 1), ('CS-201', 'Computer Science', 5, 11, 12, 35, 3, 1), ('MT-101', 'Mutant Training', 3, 9, 17, 250, 12, 1);
go

insert into Registration.Schedule(PersonId, CourseId, Active)
values (1, 1, 1), (1, 2, 1), (2, 1, 1), (2, 2, 1), (3, 3, 1), (4, 2, 1), (5, 1, 1), (5, 2, 1), (6, 3, 1), (7, 3, 0);
go