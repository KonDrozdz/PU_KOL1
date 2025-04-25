CREATE OR ALTER PROCEDURE GetPagedHistory
    @PageNumber INT,
    @PageSize INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @Offset INT = (@PageNumber - 1) * @PageSize;
    
    SELECT 
        ID,
        Imie,
        Nazwisko,
        IDGrupy,
        ActionType AS TypAkcji,
        Date AS Data
    FROM 
        Historia
    ORDER BY 
        Date DESC
    OFFSET @Offset ROWS
    FETCH NEXT @PageSize ROWS ONLY;
    
    SELECT COUNT(*) AS TotalCount FROM Historia;
END