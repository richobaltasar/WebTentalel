USE [webtentakel]
GO
/****** Object:  Table [dbo].[DataSliderBanner]    Script Date: 8/20/2020 6:54:22 AM ******/
DROP TABLE [dbo].[DataSliderBanner]
GO
/****** Object:  Table [dbo].[DataSliderBanner]    Script Date: 8/20/2020 6:54:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataSliderBanner](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[bg_img] [nvarchar](max) NULL,
	[left1_text] [nvarchar](max) NULL,
	[left2_text] [nvarchar](max) NULL,
	[left_btn] [nvarchar](max) NULL,
	[right_text] [nvarchar](max) NULL,
	[right_img] [nvarchar](max) NULL,
	[name_page] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DataSliderBanner] ON 

INSERT [dbo].[DataSliderBanner] ([Id], [bg_img], [left1_text], [left2_text], [left_btn], [right_text], [right_img], [name_page]) VALUES (1, N'fileLandingPage/header-slider/IOT_Bg.jpg', N'<strong style="color:white;">IOT (Internet Of Thing Solution)</strong><br /><span style="color:white;">making better your business</span>', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis ets nostrud exercitation ullamco.', N'Home', NULL, N'', N'Home')
INSERT [dbo].[DataSliderBanner] ([Id], [bg_img], [left1_text], [left2_text], [left_btn], [right_text], [right_img], [name_page]) VALUES (2, N'fileLandingPage/header-slider/IOT_Bg2.jpg', N'<strong style="color:white;">IOT (Internet Of Thing Solution)</strong><br /><span style="color:white;">making better your business</span>', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis ets nostrud exercitation ullamco.', N'Home', NULL, N'', N'Home')
SET IDENTITY_INSERT [dbo].[DataSliderBanner] OFF
