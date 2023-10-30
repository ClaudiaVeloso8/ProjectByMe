USE [Hospital]
GO

/****** Object:  Table [dbo].[tbl_Patient]    Script Date: 12/10/2023 23:42:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Patient](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OtherID] [varchar](10) NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Telephone] [nvarchar](20) NOT NULL,
	[Mobile] [nvarchar](20) NOT NULL,
	[Fax] [nvarchar](50) NULL,
	[OtherTelephone] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Sex] [nvarchar](10) NOT NULL,
	[BirthDate] [nvarchar](15) NOT NULL,
	[ProcessNumber] [nvarchar](20) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[PostalArea] [nvarchar](10) NULL,
	[Locality] [nvarchar](10) NULL,
	[PostalCodeID] [nvarchar](10) NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Town] [nvarchar](20) NOT NULL,
	[PostalCodeFull] [nvarchar](20) NULL,
	[NIF] [nvarchar](10) NOT NULL,
	[SNS] [nvarchar](12) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

