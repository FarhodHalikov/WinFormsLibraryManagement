CREATE TABLE [dbo].[NewStudent]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [student_name] VARCHAR(50) NOT NULL, 
    [student_gender] VARCHAR(1) NOT NULL, 
    [enroll] VARCHAR(250) NOT NULL, 
    [department] VARCHAR(250) NOT NULL, 
    [semester] VARCHAR(250) NOT NULL, 
    [contact] BIGINT NOT NULL, 
    [email] VARCHAR(250) NOT NULL
)
