drop database FSC_Login_in
create database Fishball_Secure_Communication
create table FSC_Login
(
	Account varchar(100),
	PassW varchar(100)
)

insert FSC_Login
(
	Account,
	PassW
)select 'Dennis','123456'