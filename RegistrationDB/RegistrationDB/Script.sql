create schema Registration;
go

create table Registration.Person
(
    PersonId int NOT NULL identity(1,1)
    ,FirstName nvarchar(250) NOT NULL
    ,LastName nvarchar(250) NOT NULL
    ,PersonType int NOT NULL
    ,Active bit NOT NULL
);
go

create table Registration.Course
(
    CourseId int NOT NULL identity(1,1)
    ,Title nvarchar(250) NOT NULL
    ,Department nvarchar(250) NOT NULL
    ,Professor int NOT NULL
    ,StartTime int NOT NULL
    ,EndTime int NOT NULL
    ,Capacity int NOT NULL
    ,Credit int NOT NULL
    ,Active bit NOT NULL
);
go

create table Registration.Schedule
(
    ScheduleId int NOT NULL identity(1,1)
    ,PersonId int NOT NULL
    ,CourseId int NOT NULL
    ,Active bit NOT NULL
);
go

create table Registration.PersonType
(
    PersonTypeId int NOT NULL identity(1,1)
    ,PersonType nvarchar(250) NOT NULL
    ,Active bit NOT NULL
);
go

alter table Registration.Person
    add constraint pk_person_personid primary key clustered (PersonId);
go

alter table Registration.Course
    add constraint pk_course_courseid primary key clustered (CourseId);
go

alter table Registration.Schedule
    add constraint pk_schedule_scheduleid primary key clustered (ScheduleId);
go

alter table Registration.PersonType
    add constraint pk_persontype_persontypeid primary key clustered (PersonTypeId);
go

alter table Registration.Person
    add constraint fk_person_persontype foreign key (PersonType) references Registration.PersonType (PersonTypeId);
go

alter table Registration.Course
    add constraint fk_course_professor foreign key (Professor) references Registration.Person (PersonId);
go

alter table Registration.Schedule
    add constraint fk_schedule_personid foreign key (PersonId) references Registration.Person (PersonId);
go

alter table Registration.Schedule
    add constraint fk_schedule_courseid foreign key (CourseId) references Registration.Course (CourseId);
go
