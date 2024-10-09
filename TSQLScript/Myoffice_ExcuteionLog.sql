USE [Interview]
GO

/****** Object:  Table [dbo].[Myoffice_ExcuteionLog]    Script Date: 2024/10/9 上午 10:47:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Myoffice_ExcuteionLog](
	[DeLog_AuthID] [int] NOT NULL,
	[DeLog_StoredPrograms] [nvarchar](120) NULL,
	[DeLog_GroupID] [uniqueidentifier] NULL,
	[DeLog_isCustomDebug] [bit] NULL,
	[DeLog_ExecutionProgram] [nvarchar](120) NULL,
	[DeLog_ExecuteionInfo] [nvarchar](max) NULL,
	[DeLog_VerifyNeeded] [bit] NULL,
	[exelog_nowdatetime] [datetime] NULL,
 CONSTRAINT [PK_Myoffice_ExcuteionLog] PRIMARY KEY CLUSTERED 
(
	[DeLog_AuthID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自訂索引碼' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ExcuteionLog', @level2type=N'COLUMN',@level2name=N'DeLog_AuthID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'預存程序名稱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ExcuteionLog', @level2type=N'COLUMN',@level2name=N'DeLog_StoredPrograms'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'執行的群組代碼' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ExcuteionLog', @level2type=N'COLUMN',@level2name=N'DeLog_GroupID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否認定為 Bug' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ExcuteionLog', @level2type=N'COLUMN',@level2name=N'DeLog_isCustomDebug'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'執行的項目' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ExcuteionLog', @level2type=N'COLUMN',@level2name=N'DeLog_ExecutionProgram'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'執行的內容或是說明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ExcuteionLog', @level2type=N'COLUMN',@level2name=N'DeLog_ExecuteionInfo'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'此錯誤是否要進行檢查' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ExcuteionLog', @level2type=N'COLUMN',@level2name=N'DeLog_VerifyNeeded'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新增日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Myoffice_ExcuteionLog', @level2type=N'COLUMN',@level2name=N'exelog_nowdatetime'
GO

