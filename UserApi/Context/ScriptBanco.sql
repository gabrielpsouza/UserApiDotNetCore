USE [UserDb]  
GO   
SET ANSI_NULLS ON  
GO  
  
SET QUOTED_IDENTIFIER ON  
GO  
  
SET ANSI_PADDING ON  
GO  
  
CREATE TABLE [dbo].[User](  
    [UserId] [int] IDENTITY(1,1) NOT NULL,  
    [UserName] [varchar](50) NOT NULL,  
    [UserLastName] [varchar](50) NOT NULL,  
    [UserAge] [int] NOT NULL,  
PRIMARY KEY CLUSTERED   
(  
    [UserId] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY]  
  
GO  
  
SET ANSI_PADDING ON  
GO  

INSERT INTO [User] (UserName, UserLastName, UserAge) VALUES ('Gabriel', 'Souza', 20)

select * from [User]