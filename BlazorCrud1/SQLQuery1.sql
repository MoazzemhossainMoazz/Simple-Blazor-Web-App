

use Company
create table Employees(
	Id int primary key identity(1,1),
	Name nvarchar(100),
	Department nvarchar(100),
	Salary decimal(18, 2)
	)