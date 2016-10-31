create schema Costume;
go

create table Costume.Costume
(
    CostumeId int not null identity(1,1)
    ,Name nvarchar(250) not null
    ,TypeId int not null
    ,PicturePath nvarchar(256) null
	,Complete bit not null
    ,Active bit not null
);
go

create table Costume.CostumeType
(
    CostumeTypeId int not null identity(1,1)
    ,TypeName nvarchar(250) not null
    ,Active bit not null
);
go

alter table Costume.CostumeType
    add constraint pk_costume_costumetypeid primary key clustered (CostumeTypeId);
go

alter table Costume.Costume
    add constraint pk_costume_costumeid primary key clustered (CostumeId);
go

alter table Costume.Costume
    add constraint fk_costume_typeid foreign key (TypeId) references Costume.CostumeType (CostumeTypeId);
go
