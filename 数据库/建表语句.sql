
use zhongr4038

CREATE TABLE [dbo].[FSC_Login](
	[Account] [varchar](100) NULL,
	[PassW] [varchar](100) NULL,
	[Chat] [varchar](max) NULL,
	[Order_Already_Read] [varchar](10) NULL,
	[State] [varchar](10) NULL,
	[Dou_Dou] [varchar](10) NULL,
	[PrivateKey] [varchar](max) NULL,
	[PrivateKey_State] [varchar](max) NULL
) ON [PRIMARY]

select * from FSC_Login

insert FSC_Login (
Account,
PassW,
Chat,
Order_Already_Read,
State,
Dou_Dou,
PrivateKey,
PrivateKey_State
) select '0CC175B9C0F1B6A831C399E269772661','E10ADC3949BA59ABBE56E057F20F883E',NULL,'O','N','N',NULL,'N'
