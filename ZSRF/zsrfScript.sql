use master
go
create database ZSRF
go
use ZSRF
go

create table Client
(
clientID int identity(1,1),
CLastName varchar(15),
CFirstName varchar(15),
CAddress varchar(25),
CCity varchar (15),
CState char(2),
CZip char(5),
CCountry varchar(15),
CPhone varchar(15),
CAge char(3),
CDOB date,
CEmail varchar(35),
CCellPhone varchar(15),
CDiagnosis varchar(25),
CReferLast varchar(15),
CReferFirst varchar(15),
CReferRelation varchar(15),
CReferAddress varchar(25),
CReferCity varchar(15),
CReferState char(2),
CReferZip varchar(5),
CReferPhone varchar(15),
CRefCell varchar(15),
CDoctorName varchar(25),
CDoctorAddress varchar(40),
CDoctorPhone varchar(15),
CHospital varchar(15),
CMemo varchar(50),
LastModified date,
constraint pk_clientID primary key (clientID)
)

create table Service
(
serviceID int identity(1,1),
clientID int,
serviceType varchar(20) not null,
serviceDate date not null,
serviceCheckNum int,
serviceAmnt decimal(8,2),
memo varchar(50),
notes varchar(50),
lastModified date default getdate()
constraint pk_serviceID primary key (serviceID),
constraint fk_clientID foreign key (clientID) references client(clientID)
)



--use master
--go
--drop database zsrf