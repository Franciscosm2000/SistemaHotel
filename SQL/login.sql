USE HOTEL
GO

CREATE TABLE sysuser(
	usr_id INTEGER PRIMARY KEY IDENTITY(0,1),
	usrname VARCHAR(25),
	pswd VARCHAR(100),
	rol VARCHAR(30)
);

CREATE PROCEDURE sp_in_sysuser
@usrname VARCHAR(25), @pswd VARCHAR(100), @rol VARCHAR(30)
AS
	INSERT INTO sysuser VALUES(@usrname, ENCRYPTBYPASSPHRASE(@pswd, @pswd), @rol);


EXEC sp_in_sysuser 'Admin', 'Admin', 'SysAdmin';
EXEC sp_in_sysuser 'User1', 'Abc.123', 'FullUser';
EXEC sp_in_sysuser 'User2', 'Def.456', 'Reserver';
EXEC sp_in_sysuser 'User3', 'Ghi.789', 'Reserver';

select * from sysuser;

CREATE PROCEDURE log_in
@usrname VARCHAR(25), @pswd VARCHAR(100)
AS
	if exists(SELECT * FROM sysuser WHERE usrname=@usrname AND DECRYPTBYPASSPHRASE(@pswd, pswd)=@pswd)
	begin
		SELECT 'GRANTED'
	end
	else
	begin
		SELECT 'DENIED'
	end

exec log_in 'Admin', 'Admin';