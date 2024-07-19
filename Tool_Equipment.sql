CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Tool_Ref] NCHAR(10) NOT NULL, 
    [Tool/Equipment] TEXT NOT NULL, 
    [Rental_Items] NCHAR(10) NOT NULL, 
    [Spare_Parts] NCHAR(10) NOT NULL, 
    [Stock_Status] TEXT NOT NULL, 
    [Packages_Received] NCHAR(10) NOT NULL, 
    [Processed_Packages] NCHAR(10) NOT NULL
)
