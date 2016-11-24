-- 删除所有数据表

USE BaoJia


drop table dbo.Product
drop table dbo.ProductModule
drop table dbo.Brand
drop table dbo.RecommandTable
drop table dbo.DeliveryArea
drop table dbo.DeliveryMode
drop table dbo.TechnologyRequest
drop table dbo.PrintColor
drop table dbo.SpecialColor
drop table dbo.BackChannel


						/**商品表**/
-- 创建商品表
CREATE TABLE dbo.Product
(
	Id			INT NOT NULL PRIMARY KEY IDENTITY, 
    ProductName	NVARCHAR(50) NOT NULL UNIQUE, 
    Value1		REAL NOT NULL, 
    Value2		REAL NOT NULL
)
-- 添加数据
insert into dbo.Product(Product.ProductName, Product.Value1, Product.Value2) values(N'指定品牌和型号',	0,	 0)
insert into dbo.Product(Product.ProductName, Product.Value1, Product.Value2) values(N'水胶铜版纸	',		2.6, 2.9)
insert into dbo.Product(Product.ProductName, Product.Value1, Product.Value2) values(N'热胶铜版纸	',		2.5, 2.8)
insert into dbo.Product(Product.ProductName, Product.Value1, Product.Value2) values(N'一防热敏纸	',		2.6, 2.6)
insert into dbo.Product(Product.ProductName, Product.Value1, Product.Value2) values(N'水胶三防热敏纸',	2.9, 2.9)
insert into dbo.Product(Product.ProductName, Product.Value1, Product.Value2) values(N'热胶三防热敏纸',	2.8, 2.9)
insert into dbo.Product(Product.ProductName, Product.Value1, Product.Value2) values(N'水胶合成纸	',		4.9, 5.5)
insert into dbo.Product(Product.ProductName, Product.Value1, Product.Value2) values(N'可移胶合成纸',		6.8, 7.3)
insert into dbo.Product(Product.ProductName, Product.Value1, Product.Value2) values(N'白色PET',			7.6, 8.1)
insert into dbo.Product(Product.ProductName, Product.Value1, Product.Value2) values(N'哑银PET',			7.6, 8.1)

						/***推荐类型表***/
-- 创建推荐类型表
CREATE TABLE dbo.RecommandTable
(
	Id INT NOT NULL PRIMARY KEY IDENTITY, 
    Name NVARCHAR(50) NULL
)
insert into dbo.RecommandTable(RecommandTable.Name) values(N'')
insert into dbo.RecommandTable(RecommandTable.Name) values(N'价格推荐')
insert into dbo.RecommandTable(RecommandTable.Name) values(N'品质推荐')

-- select * from dbo.RecommandTable

						/***品牌表***/
-- DROP TABLE dbo.Brand
CREATE TABLE dbo.Brand
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BrandName] NVARCHAR(50) NOT NULL unique, 
    [RecommandType] INT NOT NULL DEFAULT 0,		-- 推荐类型
    [Value] REAL NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Brand_ToRecommand] FOREIGN KEY (RecommandType) REFERENCES [RecommandTable]([Id])
)
insert into dbo.Brand(Brand.BrandName, Brand.RecommandType, Brand.Value) values(N'成邦',		2, 0)
insert into dbo.Brand(Brand.BrandName, Brand.RecommandType, Brand.Value) values(N'臻上',		1, 0)
insert into dbo.Brand(Brand.BrandName, Brand.RecommandType, Brand.Value) values(N'艾利',		3, 0)
insert into dbo.Brand(Brand.BrandName, Brand.RecommandType, Brand.Value) values(N'圣维拉',	1, 0)

-- 内连接
-- select a.*, b.Name from dbo.Brand a inner join dbo.RecommandTable b on a.RecommandType = b.Id
-- 左链接
-- select a.*, b.Name from dbo.Brand a left join dbo.RecommandTable b on a.RecommandType = b.Id
-- 右链接
-- select a.*, b.Name from dbo.Brand a right join dbo.RecommandTable b on a.RecommandType = b.Id
-- 外链接
-- select a.*, b.Name from dbo.Brand a full outer join dbo.RecommandTable b on a.RecommandType = b.Id


						/***产品型号***/
-- drop table dbo.ProductModule
CREATE TABLE dbo.ProductModule
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	ModuleName NVARCHAR(50) NOT NULL,
	BrandId INT NOT NULL,
	Value REAL,
	Value2 REAL,
	CONSTRAINT FK_Brand_Id FOREIGN KEY(BrandId) REFERENCES Brand(Id)
)

insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底水胶铜版纸	',		1, 2.6,	 2.9)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底热胶铜版纸	',		1, 2.7,	 3)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底一防热敏纸	',		1, 2.5,	 2.8)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底水胶三防热敏纸',	1, 3,	 3.2)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底热胶三防热敏纸',	1, 3,	 3.2)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底水胶合成纸	',		1, 4.8,	 5.5)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底可移胶合成纸',		1, 6.8,	 7.3)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底水胶白色PET',		1, 8.5,	 9)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底水胶哑银PET',		1, 8.5,	 9)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底油胶白PET',		1, 12,	 12.)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底油胶哑银PET',		1, 13,	 13.)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底透明PET',			1, 7,	 7.5)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底透明PE',			1, 7,	 7.5)

insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底水胶铜版纸	',		2, 2.6,	2.9)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底热胶铜版纸	',		2, 2.7,	2.9)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底一防热敏纸	',		2, 2.5,	2.5)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底水胶三防热敏纸',	2, 3,		3)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底热胶三防热敏纸',	2, 3,		3)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底水胶合成纸	',		2, 4.8,	5.2)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底可移胶合成纸',		2, 6.8,	7.2)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底水胶白色PET',		2, 8.5,	9)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底水胶哑银PET',		2, 8.5,	9)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底油胶白PET',		2, 12,	13)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底油胶哑银PET',		2, 13,	14)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底透明PET',			2, 7,		7.5)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'格底透明PE',			2, 7,		7.5)

insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'AW4200P', 3, 1,			 0)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'AW3209',	 3, 2,			 2)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'AW5209',	 3, 3,			 2)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'AW3288',	 3, 3.5,		 2)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'NW5528',	 3, 4.142857143, 2)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'NW5558D', 3, 4.785714286, 2)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'BW0052',	 3, 5.428571429, 2)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'BW9206',	 3, 6.071428571, 3)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'72825',	 3, 6.714285714, 4)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'72826',	 3, 7.357142857, 5)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'MZ0333',	 3, 8,			 6)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'MZ0063',	 3, 8.642857143, 7)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'SY0029',	 3, 9.285714286, 8)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'1644A',	 3, 9.928571429, 9)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'NW1614',	 3, 10.57142857, 10)

insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'铜版纸（水胶、格底）',			4, 2.6,	2.9)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'铜版纸（水胶、黄底）',			4, 2.8,	3.1)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'铜版纸（可移胶、格底）',		4, 5.6,	5.9)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'镜面铜版（水胶、格底）',		4, 3.2,	3.5)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'镜面铜版（水胶、黄底）',		4, 2.8,	3.1)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'书写纸（水胶、格底）',			4, 3.1,	3.4)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'书写纸（热胶、黄底）',			4, 2.8,	3.1)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'合成纸（水胶、格底）',			4, 4.8,	5.1)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'合成纸（水胶、白底）',			4, 5.6,	5.9)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'25#透明PET（油胶、格底）',		4, 6,	6.3)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'50#哑银PET（水胶、格底）',		4, 7,	7.3)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'40#透明PVC（水胶、白底）',		4, 6.5,	6.8)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'80#透明PVC(水胶、白底)	',		4, 7,	7.3)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'80#哑白PVC(水胶、白底)	',		4, 7,	7.3)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'80#光白PVC(水胶、白底)	',		4, 7,	7.3)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'80#光黑PVC(水胶。白底)	',		4, 7.3,	7.6)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'80#哑黑PVC(水胶、白底)	',		4, 7.3,	7.6)
insert into dbo.ProductModule(ModuleName, BrandId, Value, Value2) values(N'50#素面镭射膜（水胶、白底）',	4, 9,	9.3)

-- select * from dbo.ProductModule

								/***运输方式(配送方式)***/
CREATE TABLE DeliveryMode
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	ModeName NVARCHAR(50)
)

insert into dbo.DeliveryMode(ModeName) values(N'物流自提')
insert into dbo.DeliveryMode(ModeName) values(N'包邮')
insert into dbo.DeliveryMode(ModeName) values(N'自提')

								/** 物流表 **/
-- 创建新表
CREATE TABLE dbo.DeliveryArea
(
	Id INT NOT NULL PRIMARY KEY IDENTITY, 
    Name NVARCHAR(50) NOT NULL UNIQUE, 
    Value1 REAL NULL, 
    Value2 REAL NULL, 
    Value3 REAL NULL
)
-- 添加数据
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'苏锡常',	0.5,	0.5,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'江浙沪',	0.5,	0.6,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'北京',		1,		1.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'上海',		0.5,	0.6,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'天津',		1,		1.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'重庆',		1,		1.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'辽宁',		1,		1.6,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'吉林',		1,		1.4,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'黑龙江',		1,		1.4,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'河北',		1,		1,		0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'山西',		1,		1.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'陕西',		1,		1.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'甘肃',		1,		1.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'青海',		1,		1.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'山东',		1,		1,		0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'安徽',		1,		1,		0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'江苏',		1,		0.6,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'浙江',		1,		0.6,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'河南',		1,		1.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'湖南',		1,		1.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'湖北',		1,		1.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'江西',		1,		1.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'福建',		1,		1.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'云南',		1,		1.4,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'海南',		1,		1.4,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'四川',		1,		1.4,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'贵州',		1,		1.4,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'广东',		1,		1.4,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'内蒙古',		1.2,	2,		0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'新疆',		1.6,	2,		0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'广西',		1.6,	2,		0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'西藏',		1.6,	2.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'宁夏',		1.6,	2.2,	0)
INSERT INTO dbo.DeliveryArea (Name, Value1, Value2, Value3) VALUES(N'台湾',		0,		0,		0)

-- SELECT * FROM dbo.DeliveryArea

							/***工艺要求***/
CREATE TABLE TechnologyRequest
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Name NVARCHAR(50),
	Value REAL
)

insert into TechnologyRequest(Name, Value) values(N'无要求', 0)
insert into TechnologyRequest(Name, Value) values(N'撕裂线', 0.1)
insert into TechnologyRequest(Name, Value) values(N'定位孔（常用于透明或非格底材料）', 0.3)
insert into TechnologyRequest(Name, Value) values(N'背印色标（常用于透明或非格底材料）', 1)
insert into TechnologyRequest(Name, Value) values(N'异型', 0.5)
insert into TechnologyRequest(Name, Value) values(N'双工位模切', 1)
insert into TechnologyRequest(Name, Value) values(N'打印序列', 5)
insert into TechnologyRequest(Name, Value) values(N'印刷', 0)

							/***印刷颜色***/
CREATE TABLE PrintColor
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Name NVARCHAR(50),
	Value REAL
)

insert into dbo.PrintColor(Name, Value) values(N'无',	0)
insert into dbo.PrintColor(Name, Value) values(N'1',	1.2)
insert into dbo.PrintColor(Name, Value) values(N'2',	1.5)
insert into dbo.PrintColor(Name, Value) values(N'3',	1.8)
insert into dbo.PrintColor(Name, Value) values(N'4',	2.5)

							/***专色***/
CREATE TABLE SpecialColor
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Name NVARCHAR(50),
	Value REAL
)

insert into dbo.SpecialColor(Name, Value) values(N'无', 0)
insert into dbo.SpecialColor(Name, Value) values(N'1', 1)
insert into dbo.SpecialColor(Name, Value) values(N'2', 2)

							/***后道***/
CREATE TABLE BackChannel
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Name NVARCHAR(50),
	Value REAL
)

insert into dbo.BackChannel(Name, Value) values(N'无',				0)
insert into dbo.BackChannel(Name, Value) values(N'覆光膜',			1)
insert into dbo.BackChannel(Name, Value) values(N'覆哑膜',			1.5)
insert into dbo.BackChannel(Name, Value) values(N'烫金（仅热烫）',	4)
insert into dbo.BackChannel(Name, Value) values(N'丝印（仅单色）',	4)
