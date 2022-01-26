CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL IDENTITY, 
    [Username] NCHAR(30) NOT NULL, 
    [Userpassword] NCHAR(20) NOT NULL, 
    [Usere-mailaddress] NCHAR(20) NOT NULL, 
    CONSTRAINT [PK_User] PRIMARY KEY ([Id]) 
)

GO

CREATE INDEX [IX_User_Column] ON [dbo].[User] ([Id])
