create database HYIP
use HYIP
create table WEBHYIP
(
	ID int IDENTITY,
	NameWeb varchar(30),
	Deposit int,
	DateJoin datetime,
	Statuss int,
	Monitor int,
	RCB float

)

create table MONITOR
(
	ID int IDENTITY,
	NameMonitor varchar(30)
)
create table STATUSS
(
	ID int IDENTITY,
	NameStatus varchar(30)
)

create table RUNNING
(
	MaWeb int,
	Progress float,
	PercenttPaid  int
)
create table ChartWebHyip
(
	MaWeb int,
	Today datetime,
	TotalDeposit float,
	TotalWithdraw float

)

create table TrackingWebHYIP
(
	ID int identity,
	AddressWeb varchar(60),
	GetInformationAuto int,
	Good int
)

create table TrackingWebHYIPDatabase
(
	MaWeb int,	
	Deposit float,
	Withdraw float,
	Today datetime
)
create table WithdrawHistory
(
	MaWeb int ,
	Amount float,
	DayWithdraw datetime
)


-----primary key
alter table WEBHYIP
add constraint PK_WEBHYIP
primary key (ID)

alter table MONITOR
add constraint PK_MONITOR
primary key (ID)

alter table STATUSS
add constraint PK_STATUSS
primary key (ID)

alter table TrackingWebHYIP
add constraint PK_TrackingWebHYIP
primary key (ID)

--fereign key
alter table WEBHYIP
add constraint FK_WEBHYIP_MONITOR
foreign key (Monitor)
references MONITOR(ID)

alter table WEBHYIP
add constraint FK_WEBHYIP_STATUSS
foreign key (Statuss)
references STATUSS(ID)

alter table RUNNING
add constraint FK_RUNNING_WEBHYIPs
foreign key (MaWeb)
references WEBHYIP(ID)

alter table ChartWebHyip
add constraint FK_ChartWebHyip_WEBHYIPs
foreign key(MaWeb)
references WEBHYIP(ID)

alter table TrackingWebHYIPDatabase
add constraint FK_TrackingWebHYIPDatabase_TrackingWebHYIP
foreign key (MaWeb)
references TrackingWebHYIP(ID)
 
alter table WithdrawHistory
add constraint FK_WithdrawHistory_WEBHYIPs
foreign key (MaWeb)
references WEBHYIP(ID)

-----triger
GO
create trigger tg_them on WEBHYIP
for insert
as
begin
	declare @maweb int= (select ID from inserted)
	declare @dep int= (select Deposit from inserted)	
	declare @rcb float= (select RCB from inserted)	
	declare @per int= ROUND( (@rcb/@dep)*100,0 )
	insert into RUNNING values(@maweb,@rcb,@per)	
end

go
create trigger insert_table_trackdatabase on TrackingWebHYIPDatabase
for insert
as
begin
	declare @maweb int = ( select MaWeb from inserted );
	declare @totaldep float= ( select Deposit from inserted );
	declare @totalwith float = ( select Withdraw from inserted );
	declare @preDeposit float =(select Deposit from TrackingWebHYIPDatabase where  DATEDIFF(day,Today,GETDATE())=1 and MaWeb =@maweb);
	declare @preWithdraw float =(select Withdraw from TrackingWebHYIPDatabase where  DATEDIFF(day,Today,GETDATE())=1 and MaWeb =@maweb);
	if (@preDeposit is not null and @preWithdraw is not null)
	begin
		if @totaldep-@preDeposit>600 and @totalwith-@preWithdraw>200
			print'it it still good';
		else
		begin
			print'not good now';
			update TrackingWebHYIP set Good=0 where ID=@maweb;
		end
	end	

end

 
------------------insert data
insert into MONITOR values('MYHYIP')
insert into MONITOR values('HYIPCRUISER')
insert into MONITOR values('ISA')
insert into MONITOR values('NONE')

insert into STATUSS values('PAYING')
insert into STATUSS values('SCAM')
insert into STATUSS values('NOT JOIN')


--------------test
select * from MONITOR
select * from STATUSS 
select * from WEBHYIP
select * from ChartWebHyip
select * from RUNNING
select *  from TrackingWebHYIPDatabase where MaWeb=14
select * from TrackingWebHYIP where AddressWeb='https://cryptosolutions.biz'
update TrackingWebHYIP set Good=1 where ID =14


select trac.ID,trac.AddressWeb
from TrackingWebHYIPDatabase trackdata, TrackingWebHYIP trac
where trac.Good=1 and trac.ID = trackdata.MaWeb and DATEDIFF(day,trackdata.Today,GETDATE()) =0 and trackdata.Deposit -(
	select trackdata1.Deposit
	from TrackingWebHYIPDatabase trackdata1
	where  DATEDIFF(day,trackdata1.Today,GETDATE()) =1 and trackdata1.MaWeb = trackdata.MaWeb
) >30000
