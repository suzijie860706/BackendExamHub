USE [Interview]
GO

/****** Object:  Table [dbo].[Myoffice_ACPD]    Script Date: 2024/10/9 上午 10:47:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Myoffice_ACPD](
	[acpd_sid] [char](20) NOT NULL,
	[acpd_cname] [nvarchar](60) NULL,
	[acpd_ename] [nvarchar](40) NULL,
	[acpd_sname] [nvarchar](40) NULL,
	[acpd_email] [nchar](10) NULL,
	[acpd_status] [tinyint] NULL,
	[acpd_stop] [bit] NULL,
	[acpd_stopMemo] [nvarchar](600) NULL,
	[acpd_LoginID] [nvarchar](30) NULL,
	[acpd_LoginPW] [nvarchar](60) NULL,
	[acpd_memo] [nvarchar](120) NULL,
	[acpd_nowdatetime] [datetime] NULL,
	[appd_nowid] [nvarchar](20) NULL,
	[acpd_upddatetitme] [datetime] NULL,
	[acpd_updid] [nvarchar](20) NULL,
 CONSTRAINT [PK_Myoffice_ACPD] PRIMARY KEY CLUSTERED 
(
	[acpd_sid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'使用者主鍵' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_sid'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'中文名稱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_cname'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'英文名稱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_ename'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N' 簡稱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_sname'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'使用者信箱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_email'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'狀況 0=正常 , 99=不正常' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_status'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N' 是否停用/不可登入' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_stop'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'停用原因' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_stopMemo'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登入帳號' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_LoginID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登入密碼' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_LoginPW'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'備註' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_memo'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新增日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_nowdatetime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新增人員代碼' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'appd_nowid'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_upddatetitme'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人員代碼' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ACPD', @level2type=N'COLUMN',@level2name=N'acpd_updid'
GO

