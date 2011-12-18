-- SQL Manager 2008 for SQL Server 3.3.0.1
-- ---------------------------------------
-- Host      : (local)
-- Database  : TS3000SZ
-- Version   : Microsoft SQL Server  10.0.1600.22


CREATE DATABASE [TS3000SZ]
ON PRIMARY
  ( NAME = [TS3000],
    FILENAME = 'C:\Program Files\TSoft\DataBase\TS3000.mdf',
    SIZE = 3 MB,
    MAXSIZE = UNLIMITED,
    FILEGROWTH = 1 MB )
LOG ON
  ( NAME = [TS3000_log],
    FILENAME = 'C:\Program Files\TSoft\DataBase\TS3000_log.ldf',
    SIZE = 3840 KB,
    MAXSIZE = 0 MB,
    FILEGROWTH = 10 % )
COLLATE Chinese_PRC_CI_AS
GO

USE [TS3000SZ]
GO

SET NOCOUNT ON
GO

--
-- Definition for table CM_Csgl : 
--

CREATE TABLE [dbo].[CM_Csgl] (
  [cGUID] bigint IDENTITY(1, 1) NOT NULL,
  [cCode] varchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cName] nvarchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cParent] nvarchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cType] nvarchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cUserValue] varchar(20) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cDefValue] nvarchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cValueFetch] nvarchar(max) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table CM_Customer : 
--

CREATE TABLE [dbo].[CM_Customer] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] varchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cShortName] varchar(25) COLLATE Chinese_PRC_CI_AS NULL,
  [cClassGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [iLeaf] smallint CONSTRAINT [DF_BS_Customer_iLeaf] DEFAULT 0 NOT NULL,
  [cParentGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cAddress] nvarchar(150) COLLATE Chinese_PRC_CI_AS NULL,
  [cPostCode] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cRegion] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cSupBank] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cAccount] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cLPersion] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cPhone] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cFax] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iCreLimit] numeric(21, 9) NULL,
  [iStatus] smallint CONSTRAINT [DF_BS_Customer_iStatus] DEFAULT 1 NULL,
  [cRemark] nvarchar(150) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cContact] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cContactPhone] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL
)
ON [PRIMARY]
GO

--
-- Definition for table CM_Department : 
--

CREATE TABLE [dbo].[CM_Department] (
  [cGUID] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cShortName] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iLeaf] smallint NULL,
  [cParent] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iDisabledFlag] smallint NULL,
  [cRemark] nvarchar(250) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL,
  [cFullName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(20) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

EXEC sp_addextendedproperty 'MS_Description', '所属部门', 'schema', 'dbo', 'table', 'CM_Department', 'column', 'cParent'
GO

EXEC sp_addextendedproperty 'MS_Description', '禁用标示：0启用；1禁用', 'schema', 'dbo', 'table', 'CM_Department', 'column', 'iForbidden'
GO

EXEC sp_addextendedproperty 'MS_Description', '全名', 'schema', 'dbo', 'table', 'CM_Department', 'column', 'cFullName'
GO

--
-- Definition for table CM_Employee : 
--

CREATE TABLE [dbo].[CM_Employee] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iSex] int NULL,
  [cID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [iLeaf] smallint NULL,
  [cDepartment] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cOfficePhone] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cEmail] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cPhone] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cBirthplace] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cAddress] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iStatus] smallint NULL,
  [dBirthDate] datetime NULL,
  [iDimisssion] nchar(10) COLLATE Chinese_PRC_CI_AS NULL,
  [cRemark] nvarchar(250) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cGroupGUID] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cEducational] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [dEnterDate] datetime NULL,
  [cGraduateschool] nchar(10) COLLATE Chinese_PRC_CI_AS NULL,
  [cAge] int NULL,
  [iForbidden] int NULL,
  [cBank] varchar(30) COLLATE Chinese_PRC_CI_AS NULL,
  [cBankAccount] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [dExitDate] datetime NULL
)
ON [PRIMARY]
GO

EXEC sp_addextendedproperty 'MS_Description', '1:男;0:女', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'iSex'
GO

EXEC sp_addextendedproperty 'MS_Description', '身份证号码', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'cID'
GO

EXEC sp_addextendedproperty 'MS_Description', '所属部门', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'cDepartment'
GO

EXEC sp_addextendedproperty 'MS_Description', '入职时间', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'dEnterDate'
GO

EXEC sp_addextendedproperty 'MS_Description', '1：禁用；0:启用', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'iForbidden'
GO

EXEC sp_addextendedproperty 'MS_Description', '开户银行', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'cBank'
GO

EXEC sp_addextendedproperty 'MS_Description', '银行账号', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'cBankAccount'
GO

EXEC sp_addextendedproperty 'MS_Description', '离职时间', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'dExitDate'
GO

--
-- Definition for table CM_Region : 
--

CREATE TABLE [dbo].[CM_Region] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cParent] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL
)
ON [PRIMARY]
GO

--
-- Definition for table CM_Supply : 
--

CREATE TABLE [dbo].[CM_Supply] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] varchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cShortName] varchar(25) COLLATE Chinese_PRC_CI_AS NULL,
  [cClassGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [iLeaf] smallint CONSTRAINT [DF_BS_Supply_iLeaf] DEFAULT 0 NOT NULL,
  [cParent] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cAddress] nvarchar(150) COLLATE Chinese_PRC_CI_AS NULL,
  [cPostCode] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cRegion] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cSupBank] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cAccount] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cLPersion] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cPhone] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cFax] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iCreLimit] numeric(21, 9) NULL,
  [iStatus] smallint CONSTRAINT [DF_BS_Supply_iStatus] DEFAULT 1 NULL,
  [cRemark] nvarchar(150) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cContact] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cContactPhone] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cFullName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL
)
ON [PRIMARY]
GO

--
-- Definition for table CM_SysInfo : 
--

CREATE TABLE [dbo].[CM_SysInfo] (
  [cGUID] nvarchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cParent] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_Log : 
--

CREATE TABLE [dbo].[Sys_Log] (
  [cGUID] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [dDateTime] datetime NULL,
  [cAction] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cUserName] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cRoleName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cModualName] varchar(100) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_Menu : 
--

CREATE TABLE [dbo].[Sys_Menu] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] varchar(200) COLLATE Chinese_PRC_CI_AS NULL,
  [cParent] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cTitle] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cForm] varchar(200) COLLATE Chinese_PRC_CI_AS NULL,
  [cField] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [iOrder] int NULL,
  [cImgPath] varchar(250) COLLATE Chinese_PRC_CI_AS NULL,
  [cAction] varchar(30) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

EXEC sp_addextendedproperty 'MS_Description', '基础数据、列表、账表', 'schema', 'dbo', 'table', 'Sys_Menu', 'column', 'cField'
GO

--
-- Definition for table Sys_Modual : 
--

CREATE TABLE [dbo].[Sys_Modual] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL,
  [cTitle] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cType] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cImgPath] varchar(200) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_ModualFlow : 
--

CREATE TABLE [dbo].[Sys_ModualFlow] (
  [cGUID] varchar(20) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cModual] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cButton] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iX] int NULL,
  [iY] int NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_Role : 
--

CREATE TABLE [dbo].[Sys_Role] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL,
  [cParent] varchar(20) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_RoleBtnSecu : 
--

CREATE TABLE [dbo].[Sys_RoleBtnSecu] (
  [cRole] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cBtnSecu] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cModual] varchar(50) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_RoleSecu : 
--

CREATE TABLE [dbo].[Sys_RoleSecu] (
  [cRole] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cSecu] varchar(100) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_SysMenu : 
--

CREATE TABLE [dbo].[Sys_SysMenu] (
  [cGUID] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cParent] varchar(20) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_SysModualBtn : 
--

CREATE TABLE [dbo].[Sys_SysModualBtn] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cParent] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL,
  [cTimeStamp] varchar(20) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_User : 
--

CREATE TABLE [dbo].[Sys_User] (
  [cGUID] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cEmployee] nvarchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cRole] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int CONSTRAINT [DF_Sys_User_iForbidden] DEFAULT 0 NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_UserSecu : 
--

CREATE TABLE [dbo].[Sys_UserSecu] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cUser] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cPassword] varchar(18) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for indices : 
--

ALTER TABLE [dbo].[CM_Region]
ADD CONSTRAINT [PK__CM_Regio__FF6300F72B3F6F97] 
PRIMARY KEY CLUSTERED ([cGUID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sys_Menu]
ADD CONSTRAINT [Sys_Menu_pk] 
PRIMARY KEY CLUSTERED ([cGUID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sys_Modual]
ADD CONSTRAINT [Sys_Modual_pk] 
PRIMARY KEY CLUSTERED ([cGUID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sys_ModualFlow]
ADD CONSTRAINT [PK__SysModua__FF6300F75CD6CB2B] 
PRIMARY KEY CLUSTERED ([cGUID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

