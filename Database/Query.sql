CREATE DATABASE Library
ON 
( NAME = Library,
    FILENAME = 'D:\ProjectC#\Library\Database\Library.mdf',  
    SIZE = 5MB,  
    MAXSIZE = 4GB,  
    FILEGROWTH = 1MB )  
LOG ON  
( NAME = Library_log,  
    FILENAME = 'D:\ProjectC#\Library\Database\Library_log.ldf',
    SIZE = 1MB,  
    MAXSIZE = 25MB,  
    FILEGROWTH = 1MB ) ;  
GO

CREATE TABLE Userlist
(
	Username varchar(20) NOT NULL,
	PasswordAkun char(48) NOT NULL,
	TipeAkun char(20) NOT NULL,
	Nama varchar(50) NOT NULL,
	Alamat varchar(100) NOT NULL,
	Telepon char(16) NOT NULL,
	Gender char(20) NOT NULL,
	FilePath varchar(200),
	Fine varchar(10),
	constraint PK_Userlist primary key (Username)
)

CREATE TABLE Booklist
(
	BookId char(10) NOT NULL,
	Title varchar(50) NOT NULL,
	Author varchar(50) NOT NULL,
	YearReleased char(4) NOT NULL,
	Genre varchar(50) NOT NULL,
	PicturePath varchar(500),
	Stock varchar(3),
	constraint PK_Booklist primary key (BookID)
)

CREATE TABLE Lendings
(
	LendID char(10) NOT NULL,
	Username varchar(20) NOT NULL,
	BookID char(10) NOT NULL,
	LendDate varchar(10) NOT NULL,
	DueDate varchar(10) NOT NULL,
	CONSTRAINT PK_Lendings PRIMARY KEY (LendID),
	CONSTRAINT FK_Lendings1 FOREIGN KEY (Username) REFERENCES Userlist(Username) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_Lendings2 FOREIGN KEY (BookID) REFERENCES Booklist(BookID) ON DELETE CASCADE ON UPDATE CASCADE
)