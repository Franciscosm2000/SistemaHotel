USE HOTEL
GO

CREATE TABLE sysuser(
	usr_id INTEGER PRIMARY KEY IDENTITY(0,1),
	usrname VARCHAR(25),
	pswd VARCHAR(100),
	rol VARCHAR(30)
);

CREATE PROCEDURE log_in
@usrname Varchar(25), @pswd Varchar(100)
As
if exists (select * from sysuser where usrname=@usrname and decryptbypassphrase(@pswd,pswd) = @pswd)
Begin
Select 'GRANTED'
end
Else
Begin
Select 'DENIED'
End

CREATE PROCEDURE sp_in_sysuser
@usrname VARCHAR(25), @pswd VARCHAR(100), @rol VARCHAR(30)
AS
	INSERT INTO sysuser VALUES(@usrname, ENCRYPTBYPASSPHRASE(@pswd, @pswd), @rol);


EXEC sp_in_sysuser 'Admin', 'Admin', 'SysAdmin';
EXEC sp_in_sysuser 'User1', 'Abc.123', 'FullUser';
EXEC sp_in_sysuser 'User2', 'Def.456', 'Salesman';
EXEC sp_in_sysuser 'User3', 'Ghi.789', 'Reserver';

