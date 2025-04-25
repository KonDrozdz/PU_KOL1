CREATE OR ALTER TRIGGER trg_Student_AfterUpdate
ON Students
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO Historia (Imie, Nazwisko, IDGrupy, ActionType, Date)
    SELECT 
        d.Imie, 
        d.Nazwisko, 
        d.IDGrupy, 
        'edit', 
        GETDATE()
    FROM 
        deleted d
    JOIN 
        inserted i ON d.ID = i.ID
    WHERE 
        d.Imie <> i.Imie OR 
        d.Nazwisko <> i.Nazwisko OR 
        ISNULL(d.IDGrupy, -1) <> ISNULL(i.IDGrupy, -1);
END