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

insert into Costume.CostumeType(TypeName, Active)
values (N'Mask', 1), (N'Clothing', 1), (N'Full', 1);
go

insert into Costume.Costume(Name, TypeId, Complete, Active)
values (N'Iron Man', 1, 1, 1), (N'Ghostbuster', 2, 1, 1), (N'Darth Vader', 3, 0, 1);
go
