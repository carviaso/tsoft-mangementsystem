-- SQL Manager 2008 for SQL Server 3.3.0.1
-- ---------------------------------------
-- Host      : (local)
-- Database  : TS3000SZ
-- Version   : Microsoft SQL Server  10.0.1600.22


--
-- Data for table dbo.Sys_Menu  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  (N'1', 'Employee', 'BaseData', '职员', 'TS.Sys.Platform.Forms.BaseDataForms.EmployeeForm', 'item', 'Employee', NULL, '\\Employee.png', NULL)
GO
 
INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  ('3', 'Department', 'BaseData;', '部门', 'TS.Sys.Platform.Forms.BaseDataForms.DepartmentForm', 'base;item', 'Department', NULL, '\\Department.png', NULL)
GO

 

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  ('425868004605718620', 'Region', 'BaseData;', '区域', 'TS.Sys.Platform.Forms.BaseDataForms.RegionForm', 'item', 'Region', NULL, '\\Region.png', NULL)
GO

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  ('5', 'User', 'SysManager;', '用戶', 'TS.Sys.Platform.Forms.SysManager.UserForm', 'item', 'User', NULL, '\\User.png', NULL)
GO

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  ('6', 'Role', 'SysManager;', '角色管理', 'TS.Sys.Platform.Forms.SysManager.RoleForm', 'item', 'Role', NULL, '\\Role.png', NULL)
GO

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  ('687704809578090819', 'Customer', 'BaseData;', '公司', 'TS.Sys.Platform.Forms.BaseDataForms.CustomerForm', 'item;', 'Customer', NULL, '\\Company.png', NULL)
GO



--
-- Data for table dbo.Sys_Modual  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_Modual] ([cGUID], [cCode], [cName], [cTimeStamp], [iForbidden], [cTitle], [cType], [cImgPath])
VALUES 
  ('1', '002', 'BaseData', '2', 0, '基础数据', 'base', '\\basedata.png')
GO

INSERT INTO [dbo].[Sys_Modual] ([cGUID], [cCode], [cName], [cTimeStamp], [iForbidden], [cTitle], [cType], [cImgPath])
VALUES 
  ('2', '003', 'SysManager', '3', 0, '系统管理', 'base', '\\SysManager.png')
GO


--
-- Data for table dbo.Sys_Role  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_Role] ([cGUID], [cCode], [cName], [cTimeStamp], [iForbidden], [cParent])
VALUES 
  ('196474437873810042', '001', '系统管理员', '834379212212367802', 0, '000000')
GO

INSERT INTO [dbo].[Sys_Role] ([cGUID], [cCode], [cName], [cTimeStamp], [iForbidden], [cParent])
VALUES 
  ('709754019572694177', '002', '操作员', '764084492202530149', 0, '000000')
GO

--
-- Data for table dbo.Sys_RoleBtnSecu  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnNew', 'RoleDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnSave', 'RoleDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnSecu', 'RoleDetail')
GO


INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnDelete', 'Department')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnDelete', 'Employee')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnNew', 'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnSave', 'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnDelete', 'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnNew', 'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnSave', 'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnDelete', 'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnDelete', 'User')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnDelete', 'Role')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnNew', 'UserDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnDelete', 'UserDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnSave', 'UserDetail')
GO


INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnDelete', 'RoleDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnSave', 'MemberAllowDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnSave', 'CustomerDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnDelete', 'CustomerDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnDelete', 'Customer')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnDelete', 'RegionDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnSave', 'RegionDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('001', 'btnDelete', 'Region')
GO


INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('002', 'btnDelete', 'Employee')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('002', 'btnDelete', 'Department')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('002', 'btnSave', 'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('002', 'btnDelete', 'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('002', 'btnSave', 'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('002', 'btnDelete', 'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('002', 'btnDelete', 'Customer')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('002', 'btnSave', 'CustomerDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('002', 'btnDelete', 'CustomerDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('002', 'btnDelete', 'Region')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('002', 'btnDelete', 'RegionDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  ('002', 'btnSave', 'RegionDetail')
GO



--
-- Data for table dbo.Sys_RoleSecu  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'BaseData')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'Employee')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'Department')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'Customer')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'CustomerDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'Region')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'RegionDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'SysManager')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'User')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'Role')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'UserDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('001', 'RoleDetail')
GO


INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('002', 'BaseData')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('002', 'Employee')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('002', 'Department')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('002', 'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('002', 'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('002', 'Customer')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('002', 'CustomerDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('002', 'Region')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  ('002', 'RegionDetail')
GO

--
-- Data for table dbo.Sys_SysMenu  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('2', 'BaseData', '基础数据', '000000')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('3', 'SysManager', '系统管理', '000000')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('4', 'Employee', '职员', 'BaseData')
GO



INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('6', 'User', '用户管理', 'SysManager')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('7', 'Department', '部门', 'BaseData')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('8', 'Role', '角色', 'SysManager')
GO


INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('641598202973036461', 'EmployeeDetail', '职员信息', 'BaseData')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('620862060877880539', 'DepartmentDetail', '部门信息', 'BaseData')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('882440247293767373', 'UserDetail', '用户信息', 'SysManager')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('291476838162828188', 'RoleDetail', '角色信息', 'SysManager')
GO


INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('630667100210013334', 'Customer', '公司', 'BaseData')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('990299510370251156', 'CustomerDetail', '公司信息', 'BaseData')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('264791715305606171', 'Region', '区域', 'BaseData')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  ('826199088004984525', 'RegionDetail', '区域信息', 'BaseData')
GO

--
-- Data for table dbo.Sys_SysModualBtn  (LIMIT 0,500)
--


INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('615032542291679103', 'btnForbidden', '禁用', 'UserDetail', 0, '392536713903971003')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('193348118955599114', 'btnSave', '保存', 'EmployeeDetail', 0, '341689994402234891')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('668931806611010372', 'btnDelete', '删除', 'EmployeeDetail', 0, '915636740064937803')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('397658173471912685', 'btnDelete', '删除', 'Employee', 0, '636155490666508260')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('683314221269324579', 'btnValueable', '启用', 'UserDetail', 0, '367284895471814174')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('636959251796138763', 'btnSave', '保存', 'DepartmentDetail', 0, '291436290509433181')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('914346473544937556', 'btnDelete', '删除', 'DepartmentDetail', 0, '143469551375984330')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('745953918632380294', 'btnForbidden', '禁用', 'RoleDetail', 0, '248918062558787320')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('233227569489918091', 'btnDelete', '删除', 'UserDetail', 0, '012472683455175720')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('441223097265463606', 'btnSave', '保存', 'UserDetail', 0, '506003733478022182')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('987877896566183265', 'btnValueable', '启用', 'RoleDetail', 0, '918686846218065860')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('969338681484832765', 'btnSave', '保存', 'RoleDetail', 0, '125521296172879353')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('759303068101182276', 'btnDelete', '删除', 'RoleDetail', 0, '935174608532053106')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('430840550890611849', 'btnSecu', '权限分配', 'RoleDetail', 0, '624333667281143779')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('592534133867519865', 'btnDelete', '删除', 'User', 0, '236689144393614346')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('671802600219286326', 'btnDelete', '删除', 'Role', 0, '203687408239755277')
GO
 

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('281271779130565105', 'btnDelete', '删除', 'Customer', 0, '878739460208056940')
GO
 

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('100527768707532741', 'btnDelete', '删除', 'Region', 0, '510220205343907466')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('051195229814682831', 'btnDelete', '删除', 'RegionDetail', 0, '733096946367535137')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('214946546043728205', 'btnSave', '保存', 'RegionDetail', 0, '343532904347579610')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('065858407472169254', 'btnForbidden', '禁用', 'RegionDetail', 0, '637192043785322098')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('667889330382817508', 'btnValueable', '启用', 'RegionDetail', 0, '924961563207768867')
GO
 

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('149522094948933056', 'btnDelete', '删除', 'Department', 0, '635608406818216810')
GO
 

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('917893950176042522', 'btnSave', '保存', 'CustomerDetail', 0, '179081200317631687')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('810489547581584122', 'btnDelete', '删除', 'CustomerDetail', 0, '493032964861766235')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('642283503699053895', 'btnForbidden', '禁用', 'CustomerDetail', 0, '457877719066921630')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('060228029925049052', 'btnValueable', '启用', 'CustomerDetail', 0, '064487629486476781')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('960062558109745991', 'btnForbidden', '禁用', 'EmployeeDetail', 0, '685965379229960648')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('120613416675825623', 'btnValueable', '启用', 'EmployeeDetail', 0, '933576268429180530')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('865849684843598941', 'btnForbidden', '禁用', 'DepartmentDetail', 0, '395828163508544670')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  ('590804953655480083', 'btnValueable', '启用', 'DepartmentDetail', 0, '708494476720658823')
GO
 
--
-- Data for table dbo.Sys_User  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_User] ([cGUID], [cName], [cEmployee], [cCode], [cTimeStamp], [cRole], [iForbidden])
VALUES 
  ('1', 'admin', NULL, '001', '691447842641059515', '001', 0)
GO
 

--
-- Data for table dbo.Sys_UserSecu  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_UserSecu] ([cGUID], [cUser], [cPassword])
VALUES 
  ('1', '001', 'admin1')
GO
 

