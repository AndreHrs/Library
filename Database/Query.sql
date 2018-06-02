CREATE TABLE Userlist
(
	Username char(20) NOT NULL,
	PasswordAkun char(20) NOT NULL,
	Alamat varchar(100) NOT NULL,
	Telepon char(14) NOT NULL,
	Gender char(20) NOT NULL,
	TipeAkun char(20) NOT NULL,
	FilePath varchar(200),
	constraint PK_Userlist primary key (Username)
)

CREATE TABLE Booklist
(
	BookId char(20) NOT NULL,
	Title char(50) NOT NULL,
	Author varchar(50) NOT NULL,
	YearReleased char(5) NOT NULL,
	Genre varchar(50) NOT NULL,
	PicturePath varchar(300) NOT NULL,
	constraint PK_Booklist primary key (BookID)
)

CREATE TABLE Lendings
(
	Username char(20) NOT NULL,
	BookID char(20) NOT NULL,
	LendDate varchar(20) NOT NULL,
	DueDate varchar(20) NOT NULL,
	Fine char(8) NOT NULL,
	CONSTRAINT FK_Lendings1 FOREIGN KEY (Username) REFERENCES Userlist(Username) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_Lendings2 FOREIGN KEY (BookID) REFERENCES Booklist(BookID) ON DELETE CASCADE ON UPDATE CASCADE
)

INSERT INTO Userlist VALUES('k','seharusnyaKosongJuga','Admin','Tidak Bernama','Suatu tempat dibumi','00000000000','Neither','D:\Mikroskil\Sem 4\OOP C#\ProjectC#\Pic Folders\Andre.jpg')
INSERT INTO Userlist VALUES('tesnull','seharusnyaKosongJ','Admin','Tidak Bernama','Suatu tempat dibumi','00000000000','Neither','')
INSERT INTO Userlist VALUES('tesnull','seharusnyaKosongJ','Admin','Tidak Bernama','Suatu tempat dibumi','00000000000','Neither')

DELETE FROM Userlist WHERE Username='k'
select * from Userlist