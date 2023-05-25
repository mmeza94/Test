Create Table TblExamen( IdExamen int not null, Nombre Varchar(255) null, Descripcion Varchar(255) null )
GO


Create Procedure SpAgregar 
@Id int,
@Nombre varchar(255),
@Descripcion varchar(255)
AS
BEGIN
	

	BEGIN TRY

		Insert into TblExamen(IdExamen,Nombre,Descripcion )
		Values(@Id, @Nombre,@Descripcion)

		Select 0 AS CodigoRetorno, 'Registro Insertado Correctamente' as DescripcionRetorno

	END TRY
	BEGIN CATCH
		Select ERROR_NUMBER() as CodigoRetorno, ERROR_MESSAGE() as DescripcionRetorno
	END CATCH
END
GO

Create Procedure SpActualizar 
@Id int,
@Nombre varchar(255),
@Descripcion varchar(255)
AS
BEGIN
	

	BEGIN TRY

		Update TblExamen
		Set Nombre = @Nombre , Descripcion = @Descripcion
		Where IdExamen = @Id

		Select 0 AS CodigoRetorno, 'Registro Insertado Correctamente' as DescripcionRetorno

	END TRY
	BEGIN CATCH
		Select ERROR_NUMBER() as CodigoRetorno, ERROR_MESSAGE() as DescripcionRetorno
	END CATCH
END
GO

Create Procedure SpEliminar 
@Id int
AS
BEGIN
	

	BEGIN TRY

		Delete TblExamen
		Where IdExamen = @Id

		Select 0 AS CodigoRetorno, 'Registro Insertado Correctamente' as DescripcionRetorno

	END TRY
	BEGIN CATCH
		Select ERROR_NUMBER() as CodigoRetorno, ERROR_MESSAGE() as DescripcionRetorno
	END CATCH
END
GO

Create Procedure SpConsultar 

@Nombre varchar(255),
@Descripcion varchar(255)
AS
BEGIN
	

	BEGIN TRY

		Select IdExamen, Nombre, Descripcion
		FRom TblExamen
		Where Nombre = @Nombre And Descripcion = @Descripcion

	END TRY
	BEGIN CATCH
		Select ERROR_NUMBER() as CodigoRetorno, ERROR_MESSAGE() as DescripcionRetorno
	END CATCH
END
GO



