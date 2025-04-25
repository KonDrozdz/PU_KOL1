CREATE OR ALTER TRIGGER trg_Student_AfterDelete
ON Students
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO Historia (Imie, Nazwisko, IDGrupy, ActionType, Date)
    SELECT 
        Imie, 
        Nazwisko, 
        IDGrupy, 
        'delete', 
        GETDATE()
    FROM 
        deleted;
END