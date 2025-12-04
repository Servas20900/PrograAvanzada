CREATE PROCEDURE dbo.ValidarUsuarios
    @Email VARCHAR(100),
    @Password VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        IdUsuario,
        ID,
        Name,
        Email,
        Password,
        Estado,
        IdPerfil
    FROM dbo.T_Usuario
    WHERE Email = @Email
      AND Password = @Password
      AND Estado = 1;
END;
GO
