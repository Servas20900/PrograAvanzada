
CREATE PROCEDURE CrearUsuarios
	@ID			VARCHAR(50),
	@Name		VARCHAR(50),
	@Email		VARCHAR(50),
	@Password	VARCHAR(50)
AS
BEGIN
	
    --Se valida si el usuario ya existe
    IF NOT EXISTS(  SELECT  1 
                    FROM    dbo.T_Usuario
                    WHERE   ID = @ID
                        OR  Email = @Email)
    BEGIN

        --Si no existe se manda a crear
        INSERT INTO dbo.T_Usuario (ID,Name,Email,Password,Estado,IdPerfil)
        VALUES (@ID, @Name, @Email, @Password, 1, 2)

    END
END
GO
