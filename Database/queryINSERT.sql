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
DELETE FROM Books$ WHERE BookId IS NULL;

