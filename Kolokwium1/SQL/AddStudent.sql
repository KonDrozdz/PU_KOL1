CREATE OR ALTER PROCEDURE AddStudent
    @Imie NVARCHAR(50),
    @Nazwisko NVARCHAR(50),
    @IDGrupy INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO Students (Imie, Nazwisko, IDGrupy)
    VALUES (@Imie, @Nazwisko, @IDGrupy)
    
    SELECT SCOPE_IDENTITY() AS NewStudentID;
END