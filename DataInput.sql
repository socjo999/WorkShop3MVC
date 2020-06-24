use PhoneBook
declare @i tinyint = 0
while (@i < 10000)
begin
insert into dbo.[People] 
(
FirstName,
LastName,
Phone,
Email,
CreationDate,
UpdateDate
)
VALUES
(
SUBSTRING(CONVERT(varchar(40), NEWID()),0,9),
SUBSTRING(CONVERT(varchar(40), NEWID()),0,9),
right(convert(varchar,round(rand(checksum(newid()))*(10)+20,0))+convert(varchar,round(rand(checksum(newid()))*(10)+20,0))+convert(varchar,round(rand(checksum(newid()))*(10)+20,0))+convert(varchar,round(rand(checksum(newid()))*(10)+20,0))+convert(varchar,round(rand(checksum(newid()))*(10)+20,0)),9),
SUBSTRING(CONVERT(varchar(40), NEWID()),0,9)+'@'+SUBSTRING(CONVERT(varchar(40), NEWID()),0,9)+'.'+SUBSTRING(CONVERT(varchar(40), NEWID()),0,3)+'.'+SUBSTRING(CONVERT(varchar(40), NEWID()),0,2),
DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 364 ), '2011-01-01'),
DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 364 ), '2011-01-01')
)
 set @i = @i + 1
end
go
--use PhoneBook
--select * from dbo.[People]