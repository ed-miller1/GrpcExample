/****** Object:  Table [dbo].[TestPersonGrpcTbl]    Script Date: 9/3/2019 2:50:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestPersonGrpcTbl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TestPersonRestTbl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TestPersonTbl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

--filling test tables with test data.
declare @count int = 1;

while(@count <= 5000)
begin
	insert into dbo.TestPersonGrpcTbl(Name,Email) values ('Test'+@count+' Testerson'+@count, 'test'+@count+'@test.com');
	insert into dbo.TestPersonRestTbl(Name,Email) values ('Test'+@count+' Testerson'+@count, 'test'+@count+'@test.com');
	insert into dbo.TestPersonTbl(Name,Email) values ('Test'+@count+' Testerson'+@count, 'test'+@count+'@test.com');
	set @count = @count + 1;
end

go