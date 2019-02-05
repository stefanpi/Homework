create table Book
(
	BookID int identity(1,1) primary key,
	Title varchar(200) UNIQUE NOT NULL,
	PublisherID int NOT NULL,
	Year int NOT NULL,
	Price int,

)

creatxe table Author
(
	AuthorID int identity(1,1) primary key,
	FirstName varchar(50) NOT NULL,
	LastName varchar(50) NOT NULL,
	Birthdate date
)

alter table BookAuthor
(
	BookAuthorId int identity(1,1) primary key,
	BookID int NOT NULL,
	AuthorID int NOT NULL,
	CONSTRAINT FK_BookAuthor_BookID FOREIGN KEY (BookID) references Book(BookID),
	CONSTRAINT FK_BookAuthor_AuthorID FOREIGN KEY (AuthorID) references Author(AuthorID)

)

create table Category
(
	CategoryID int identity(1,1) primary key,
	Name varchar(50) UNIQUE NOT NULL
)

create table BookCategory
(
	BookCategoryID int identity(1,1) primary key,
	BookID int NOT NULL,
	CategoryID int NOT NULL
)

create table Address
(
	AdressID int identity(1,1) primary key,
	Street VARCHAR(100) NOT NULL,
	BuildingNumber int,
	BuildingName varchar(100),
	EntranceNumber int,
	FloorNr int,
	ApartmentNumber int,
	City varchar(50),
	PostalCode int NOT NULL,
	Country varchar(50),
	OtherDetails varchar(200)
)




