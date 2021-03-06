USE [MVCCurd]
GO
/****** Object:  Table [dbo].[BookShop]    Script Date: 05-01-2022 11:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookShop](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [varchar](100) NULL,
	[BookAuthor] [varchar](200) NULL,
	[BookPrice] [decimal](18, 0) NULL,
	[BookLaunchDate] [date] NULL,
	[BookAvailablityStatus] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
