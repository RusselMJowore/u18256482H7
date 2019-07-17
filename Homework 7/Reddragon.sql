Use Master
GO

If exists (Select * from sys.databases where name = 'Reddragon')
Drop Database Reddragon
GO

use Reddragon
GO


Create Table ShopItem 
(
 Item_ID  int primary key identity(1,1) Not NUll,
 Name  varchar (100) not null,
 Description  varchar(100)not null,
 Price  float Not NUll,
 QuantityAvailable  int Not NUll,

)