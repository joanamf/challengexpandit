CREATE TABLE [dbo].[Persons](
	[personId] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](250) NOT NULL,
	[address] [nvarchar](250) NULL,
	[zipCode] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[email] [nvarchar](250) NULL,
	[photo] [image] NULL,
	[mobileNumber] [nvarchar](50) NULL,
	[homeNumber] [nvarchar](50) NULL,
	[officeNumber] [nvarchar](50) NULL,
	[otherNumber] [nvarchar](50) NULL,
	[createdOn] [datetime] NOT NULL,
	[createdBy] [nvarchar](100) NOT NULL,
	[updatedOn] [datetime] NOT NULL,
	[updatedBy] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[personId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO