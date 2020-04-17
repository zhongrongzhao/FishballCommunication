select * from FSC_Login
update FSC_Login set Chat = null, Order_Already_Read = 'O',State = 'N',Dou_Dou = 'N',PrivateKey = null,PrivateKey_State='N'

alter table FSC_Login add PrivateKey_State varchar(max)

update FSC_Login set PrivateKey = '1',PrivateKey_State='N' where Account ='Dennis'

select *  from FSC_Login where Account='Dennis';update FSC_Login set PrivateKey = null,PrivateKey_State='O' where Account = 'Dennis'

update FSC_Login set Chat = null, Order_Already_Read = 'O',Dou_Dou = 'N',PrivateKey = null,PrivateKey_State='N';update FSC_Login set State = 'N' where Account = 'Dennis'