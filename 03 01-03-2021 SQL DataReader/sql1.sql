
USE [DBUsers]
GO
/****** Object:  Table [dbo].[TBUsers]    Script Date: 01/03/2021 11:51:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBUsers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Family] [nvarchar](50) NULL,
 CONSTRAINT [PK_TBUsers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBUsers] ON 

INSERT [dbo].[TBUsers] ([ID], [Name], [Family]) VALUES (1, N'avi', N'cohen')
INSERT [dbo].[TBUsers] ([ID], [Name], [Family]) VALUES (2, N'ben', N'bobo')
INSERT [dbo].[TBUsers] ([ID], [Name], [Family]) VALUES (3, N'charlie', N'brown')
INSERT [dbo].[TBUsers] ([ID], [Name], [Family]) VALUES (4, N'dora', N'bora')
INSERT [dbo].[TBUsers] ([ID], [Name], [Family]) VALUES (5, N'nir', N'near')
INSERT [dbo].[TBUsers] ([ID], [Name], [Family]) VALUES (7, N'aviv', N'chaviv')
INSERT [dbo].[TBUsers] ([ID], [Name], [Family]) VALUES (8, N'maya', N'papaya')
SET IDENTITY_INSERT [dbo].[TBUsers] OFF
USE [master]
GO
ALTER DATABASE [DBUsers] SET  READ_WRITE 
GO
