CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Work_Order] NVARCHAR(50) NOT NULL, 
    [Tool_ref] NVARCHAR(50) NOT NULL, 
    [Team_Member] TEXT NOT NULL, 
    [Status] TEXT NOT NULL, 
    [Duration] TIME NOT NULL
)
