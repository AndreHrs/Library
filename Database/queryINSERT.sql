select * from userlist
select * from Account$

insert INTO USERLIST 
VALUES 
('admin','admin','Admin','Tzuyu','Tainan','02140210','Female','D:\ProjectC#\Database',0)
ALTER TABLE Account$
DROP Column F1


INSERT INTO Userlist SELECT * FROM Account$
------------------------------------
select * from booklist
select * from books$

ALTER TABLE Books$
DROP Column F1

ALTER TABLE Books$
DROP Column Publisher, SynopsisPath

INSERT INTO Booklist SELECT * FROM Books$
DELETE FROM Books$ WHERE BookId IS NULL
----------------------------------------
--DATA STEVE

select * from Books$
alter table Books$
drop column f1,f5, SynopsisPath
DELETE FROM BOOKS$ WHERE BOOKID IS NULL
INSERT INTO Booklist SELECT * FROM Books$

select * from booklist
update books$ set stock = 2 where bookid ='800028'