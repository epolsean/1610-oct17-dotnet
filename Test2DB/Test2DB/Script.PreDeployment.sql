/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

use master;
go

if(DB_ID(N'CostumeDB') is not null)
begin
	drop database CostumeDB;
end;

create database CostumeDB;
go

use CostumeDB;
go

if(SCHEMA_ID(N'Costume') is not null)
begin
	drop schema Costume;
end;