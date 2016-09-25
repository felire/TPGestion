USE [GD2C2016]
GO

CREATE SCHEMA [kernel_panic] AUTHORIZATION [gd]
GO


CREATE PROCEDURE kernel_panic.CrearTablas
AS
	CREATE TABLE [kernel_panic].[Roles] (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		Nombre VARCHAR (20) NOT NULL UNIQUE,
		Esta_activo BIT NOT NULL DEFAULT 1); -- El BIT es BOOLEANO, 0 es false y 1 es true.

	CREATE TABLE [kernel_panic].[Funciones] (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		Nombre VARCHAR(50) NOT NULL);

	CREATE TABLE [kernel_panic].[Funciones_Roles] (
		Rol_id INT,
		Funcion_id INT,
		PRIMARY KEY(Rol_id, Funcion_id),
		FOREIGN KEY(Rol_id) REFERENCES [kernel_panic].[Roles] (Id),
		FOREIGN KEY(Funcion_id) REFERENCES [kernel_panic].[Funciones] (Id));

	CREATE TABLE [kernel_panic].[Usuarios] (
		Nombre_usuario VARCHAR(50) PRIMARY KEY, --Nombre usuario
		Password_usuario CHAR(64),
		Intentos_fallidos INT DEFAULT 0,
		Habilitado BIT NOT NULL DEFAULT 1); --1 es habilitado, 0 no.
	CREATE TABLE [kernel_panic].[Roles_Usuario] (
		Rol_id INT,
		Usuario_id VARCHAR(50),
		PRIMARY KEY(Rol_id,Usuario_id),
		FOREIGN KEY(Rol_id) REFERENCES [kernel_panic].[Roles] (Id),
		FOREIGN KEY(Usuario_id) REFERENCES [kernel_panic].[Usuarios] (Nombre_usuario)); 

	CREATE TABLE [kernel_panic].[Planes] (	--Todos valores de tabla maestra
		Codigo numeric(18,0) PRIMARY KEY,
		Descripcion VARCHAR(255),
		Precio_bono_consulta numeric(18,0),
		Precio_bono_farmacia numeric(18,0));

	CREATE TABLE [kernel_panic].[Grupos_Familiares] (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		Plan_grupo numeric(18,0),
		FOREIGN KEY (Plan_Grupo) REFERENCES [kernel_panic].[Planes] (Codigo));

	CREATE TABLE [kernel_panic].[Afiliados] (
		Id INT PRIMARY KEY,
		Numero_de_grupo INT,
		Numero_en_el_grupo INT, --Dentro del grupo familiar
		Nombre VARCHAR(255) NOT NULL,
		Apellido VARCHAR(255) NOT NULL,
		Tipo_doc VARCHAR(15) NOT NULL CHECK (Tipo_doc IN ('DNI', 'LD', 'LC', 'CI')),
		Numero_doc numeric(18,0) NOT NULL,
		Direccion VARCHAR(255) NOT NULL,
		Telefono numeric(18,0) NULL,
		Mail VARCHAR(255) NOT NULL,
		Fecha_nacimiento DATETIME NOT NULL,
		Sexo CHAR CHECK (Sexo IN ('M', 'F')),
		Estado_civil VARCHAR(20) CHECK (Estado_civil IN ('Soltero/a', 'Casado/a', 'Viudo/a', 'Concubinato', 'Divorciado/a')),
		Familiares_a_cargo INT,
		Esta_activo BIT, -- 1 activo, 0 desactivado
		Nombre_usuario VARCHAR(50),
		FOREIGN KEY (Nombre_usuario) REFERENCES [kernel_panic].[Usuarios] (Nombre_usuario),
		FOREIGN KEY (Numero_de_grupo) REFERENCES [kernel_panic].[Grupos_Familiares] (Id));

	CREATE TABLE [kernel_panic].[LogsCambioAfiliados] (
		Id INT IDENTITY (1,1) PRIMARY KEY,
		Afiliado INT,
		Fecha DATETIME,
		Descripcion VARCHAR(255)
		FOREIGN KEY(Afiliado) REFERENCES [kernel_panic].[Afiliados] (Id));

	CREATE TABLE [kernel_panic].[Transacciones] (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		Cantidad INT NOT NULL,
		Precio INT NOT NULL,
		Fecha DATETIME NOT NULL,
		Afiliado INT,
		FOREIGN KEY (Afiliado) REFERENCES [kernel_panic].[Afiliados] (Id));

	CREATE TABLE [kernel_panic].[Profesionales] (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		Nombre VARCHAR(255) NOT NULL,
		Apellido VARCHAR(255) NOT NULL,
		Tipo_doc VARCHAR(15) NOT NULL CHECK (Tipo_doc IN ('DNI', 'LD', 'LC', 'CI')),
		Numero_doc numeric(18,0) NOT NULL,
		Direccion VARCHAR(255) NOT NULL,
		Telefono numeric(18,0) NULL,
		Mail VARCHAR(255) NOT NULL,
		Fecha_nacimiento DATETIME NOT NULL,
		Sexo CHAR CHECK (Sexo IN ('M', 'F')),
		Usuario_id VARCHAR(50),
		FOREIGN KEY (Usuario_id) REFERENCES [kernel_panic].[Usuarios] (Nombre_usuario),
		Profesional_matricula VARCHAR (50));

	CREATE TABLE [kernel_panic].[Tipo_Especialidad] (
		Codigo numeric(18,0) PRIMARY KEY,
		Descripcion VARCHAR(255) NOT NULL);

	CREATE TABLE [kernel_panic].[Especialidades] (
		Codigo numeric(18,0) PRIMARY KEY,
		Descripcion VARCHAR(255) NOT NULL,
		Tipo numeric(18,0)
		FOREIGN KEY (Tipo) REFERENCES [kernel_panic].[Tipo_Especialidad] (Codigo));

	CREATE TABLE [kernel_panic].[Especialidad_Profesional] (
		Especialidad_codigo numeric(18,0),
		Profesional_id INT,
		PRIMARY KEY(Especialidad_codigo,Profesional_id),
		FOREIGN KEY(Especialidad_codigo) REFERENCES [kernel_panic].[Especialidades] (Codigo),
		FOREIGN KEY(Profesional_id) REFERENCES [kernel_panic].[Profesionales] (Id));

	CREATE TABLE [kernel_panic].[Cancelaciones] (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		Tipo VARCHAR(30) CHECK (Tipo IN ('Afiliado', 'Profesional')),
		Detalle VARCHAR(400),
		Fecha DATETIME);

	CREATE TABLE [kernel_panic].[Turnos] (
		Id INT IDENTITY(202165,1) PRIMARY KEY,
		Afiliado_id INT NOT NULL,
		Profesional_id INT NOT NULL,
		Fecha DATETIME NOT NULL,
		Especialidad numeric(18,0) NOT NULL,
		Fecha_llegada DATETIME NULL,
		Cancelacion INT NULL,
		FOREIGN KEY(Afiliado_id) REFERENCES [kernel_panic].[Afiliados] (Id),
		FOREIGN KEY(Profesional_id) REFERENCES [kernel_panic].[Profesionales] (Id),
		FOREIGN KEY(Especialidad) REFERENCES [kernel_panic].[Especialidades] (Codigo),
		FOREIGN KEY(Cancelacion) REFERENCES [kernel_panic].[Cancelaciones] (Id));

	CREATE TABLE [kernel_panic].[Diagnosticos] (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		Afiliado_id INT NOT NULL,
		Profesional_id INT NOT NULL,
		Fecha DATETIME NOT NULL,
		Sintoma VARCHAR(255) NOT NULL,
		Enfermedad VARCHAR(255),
		FOREIGN KEY(Afiliado_id) REFERENCES [kernel_panic].[Afiliados] (Id),
		FOREIGN KEY(Profesional_id) REFERENCES [kernel_panic].[Profesionales] (Id));

	CREATE TABLE [kernel_panic].[Bonos_Consultas] (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		Nro_consulta INT NULL,
		Grupo_afiliado INT NOT NULL,
		Plan_Uso numeric(18,0) NOT NULL,
		Afiliado_Uso INT NULL, --Afiliado que lo utilizo
		Fecha_Bono_compra DATETIME,
		Fecha_Impresion DATETIME, --Es fecha de uso
		Turno INT NULL,
		FOREIGN KEY(Grupo_afiliado) REFERENCES [kernel_panic].[Grupos_Familiares] (Id),
		FOREIGN KEY(Plan_Uso) REFERENCES [kernel_panic].[Planes] (Codigo),
		FOREIGN KEY(Turno) REFERENCES [kernel_panic].[Turnos] (Id),
		FOREIGN KEY(Afiliado_Uso) REFERENCES [kernel_panic].[Afiliados] (Id));

	CREATE TABLE [kernel_panic].[Bonos_Farmacia] (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		Afiliado_uso INT NULL,
		Grupo_afiliado INT NOT NULL,
		Plan_uso numeric(18,0) NOT NULL,
		Fecha_compra DATETIME,
		FOREIGN KEY(Grupo_afiliado) REFERENCES [kernel_panic].[Grupos_Familiares] (Id),
		FOREIGN KEY(Plan_uso) REFERENCES [kernel_panic].[Planes] (Codigo),
		FOREIGN KEY(Afiliado_uso) REFERENCES [kernel_panic].[Afiliados] (Id));

	CREATE TABLE [kernel_panic].[Esquema_Trabajo] (
		Id INT IDENTITY (1,1) PRIMARY KEY,
		Profesional INT,
		Desde DATETIME,
		Hasta DATETIME,
		FOREIGN KEY (Profesional) REFERENCES [kernel_panic].[Profesionales] (Id));

	CREATE TABLE [kernel_panic].[Agenda_Diaria] (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		EsquemaTrabajo INT,
		Dia INT, --El numero del dia esta en el codigo de c#
		Desde TIME,
		Hasta TIME,
		Especialidad numeric(18,0),
		FOREIGN KEY (Especialidad) REFERENCES [kernel_panic].[Especialidades] (Codigo),
		FOREIGN KEY (EsquemaTrabajo) REFERENCES [kernel_panic].[Esquema_Trabajo] (Id));
		
	CREATE TABLE [kernel_panic].[Franjas_Canceladas] (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		EsquemaTrabajo INT,
		Desde DATETIME,
		Hasta DATETIME,
		FOREIGN KEY (EsquemaTrabajo) REFERENCES [kernel_panic].[Esquema_Trabajo] (Id));
GO

CREATE PROCEDURE kernel_panic.BorrarTablas
AS
	DROP TABLE [kernel_panic].[Franjas_Canceladas]
	DROP TABLE [kernel_panic].[Agenda_Diaria]
	DROP TABLE [kernel_panic].[Esquema_Trabajo]
	DROP TABLE [kernel_panic].[Bonos_Farmacia]
	DROP TABLE [kernel_panic].[Bonos_Consultas]
	DROP TABLE [kernel_panic].[Diagnosticos]
	DROP TABLE [kernel_panic].[Turnos]
	DROP TABLE [kernel_panic].[Cancelaciones]
	DROP TABLE [kernel_panic].[Especialidad_Profesional]
	DROP TABLE [kernel_panic].[Especialidades]
	DROP TABLE [kernel_panic].[Tipo_Especialidad]
	DROP TABLE [kernel_panic].[Profesionales]
	DROP TABLE [kernel_panic].[Transacciones]
	DROP TABLE [kernel_panic].[LogsCambioAfiliados]
	DROP TABLE [kernel_panic].[Afiliados]
	DROP TABLE [kernel_panic].[Grupos_Familiares]
	DROP TABLE [kernel_panic].[Planes]
	DROP TABLE [kernel_panic].[Roles_Usuario]
	DROP TABLE [kernel_panic].[Usuarios]
	DROP TABLE [kernel_panic].[Funciones_Roles]
	DROP TABLE [kernel_panic].[Funciones]
	DROP TABLE [kernel_panic].[Roles]
GO					

CREATE PROCEDURE kernel_panic.Cargar_registro_afiliados
AS
	SELECT DISTINCT Paciente_Nombre, Paciente_Apellido, Paciente_Dni, Paciente_Direccion, Paciente_Telefono, Paciente_Mail, Paciente_Fecha_Nac, Plan_Med_Codigo
	INTO #auxiliarPaciente
	FROM gd_esquema.Maestra
	DECLARE @PacienteDNI AS numeric(18,0)
	DECLARE @PacienteApellido AS varchar(255)
	DECLARE @PacienteDireccion AS varchar(255)
	DECLARE @PacienteTelefono AS numeric(18,0)
	DECLARE @PacienteFechaNac AS datetime
	DECLARE @PacienteMail AS varchar(255)
	DECLARE @PlanMed AS numeric(18,0)
	DECLARE @PacienteNombre AS varchar(255)
	DECLARE @IdAfiliadoReal AS INT
	DECLARE @UltimoGrupo AS INT
	DECLARE CursorPaciente CURSOR FOR SELECT Paciente_Nombre, Paciente_Apellido, Paciente_Dni, Paciente_Direccion, Paciente_Telefono, Paciente_Mail, Paciente_Fecha_Nac, Plan_Med_Codigo FROM #auxiliarPaciente
	--Abrimos cursor
	OPEN CursorPaciente
	FETCH NEXT FROM CursorPaciente INTO @PacienteNombre, @PacienteApellido, @PacienteDNI, @PacienteDireccion, @PacienteTelefono, @PacienteMail, @PacienteFechaNac, @PlanMed

	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO kernel_panic.Grupos_Familiares (Plan_Grupo) VALUES (@PlanMed)
		SET @UltimoGrupo = @@IDENTITY
		SET @IdAfiliadoReal = CONVERT(INT,CONVERT(VARCHAR(20),@UltimoGrupo)+'01')

		INSERT INTO kernel_panic.Usuarios (Nombre_usuario, Password_usuario)
		VALUES
		(CONVERT(VARCHAR(50), @IdAfiliadoReal), NULL)	

		INSERT INTO kernel_panic.Afiliados (Id,Numero_de_grupo, Numero_en_el_grupo ,Nombre, Apellido, Tipo_doc, Numero_doc, Direccion, Telefono, Mail, Fecha_nacimiento, Sexo, Estado_civil, Familiares_a_cargo, Esta_activo, Nombre_usuario)
		VALUES
		(@IdAfiliadoReal,@UltimoGrupo,1, @PacienteNombre, @PacienteApellido,'DNI', @PacienteDNI, @PacienteDireccion, @PacienteTelefono,@PacienteMail,@PacienteFechaNac,NULL,NULL,NULL,1,(CONVERT(VARCHAR(50), @IdAfiliadoReal)))
				
		FETCH NEXT FROM CursorPaciente INTO @PacienteNombre, @PacienteApellido, @PacienteDNI, @PacienteDireccion, @PacienteTelefono, @PacienteMail, @PacienteFechaNac, @PlanMed
		
	END
	CLOSE CursorPaciente
	DEALLOCATE CursorPaciente
	DROP TABLE #auxiliarPaciente
GO

CREATE PROCEDURE kernel_panic.Cargar_tipo_especialidad
AS
	INSERT INTO kernel_panic.Tipo_Especialidad (Codigo, Descripcion) 
	SELECT DISTINCT Tipo_Especialidad_Codigo, Tipo_Especialidad_Descripcion
	FROM gd_esquema.Maestra
	WHERE Tipo_Especialidad_Codigo IS NOT NULL
GO

CREATE PROCEDURE kernel_panic.Cargar_especialidades
AS
	INSERT INTO kernel_panic.Especialidades (Codigo, Descripcion,Tipo)
	SELECT DISTINCT Especialidad_Codigo, Especialidad_Descripcion, Tipo_Especialidad_Codigo
	FROM gd_esquema.Maestra
	WHERE Especialidad_Codigo IS NOT NULL
GO

CREATE PROCEDURE kernel_panic.Cargar_planes
AS
	INSERT INTO kernel_panic.Planes (Codigo, Descripcion, Precio_bono_consulta, Precio_bono_farmacia)
	SELECT DISTINCT Plan_Med_Codigo, Plan_Med_Descripcion, Plan_Med_Precio_Bono_Consulta, Plan_Med_Precio_Bono_Farmacia
	FROM gd_esquema.Maestra
GO

CREATE PROCEDURE kernel_panic.Cargar_profesionales
AS
	INSERT INTO kernel_panic.Profesionales (Nombre, Apellido, Tipo_doc, Numero_doc, Direccion, Telefono, Mail, Fecha_nacimiento, Sexo, Usuario_id, Profesional_matricula)
	SELECT DISTINCT Medico_Nombre, Medico_Apellido, 'DNI',Medico_Dni,Medico_Direccion,Medico_Telefono,Medico_Mail,Medico_Fecha_Nac,NULL,NULL,NULL
	FROM gd_esquema.Maestra
	WHERE Medico_Nombre IS NOT NULL


	DECLARE @MedicoDNI AS numeric(18,0)
	DECLARE CursorMedico CURSOR FOR SELECT Numero_doc FROM kernel_panic.Profesionales
	--Abrimos cursor
	OPEN CursorMedico
	FETCH NEXT FROM CursorMedico INTO @MedicoDNI
	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO kernel_panic.Usuarios (Nombre_usuario, Password_usuario)
		VALUES
		(CONVERT(VARCHAR(50), @MedicoDNI), NULL)	
		
		UPDATE kernel_panic.Profesionales SET Usuario_id = CONVERT(VARCHAR(50), @MedicoDNI) WHERE Numero_doc = @MedicoDNI				
		FETCH NEXT FROM CursorMedico INTO @MedicoDNI		
	END
	CLOSE CursorMedico
	DEALLOCATE CursorMedico
	
GO

CREATE PROCEDURE kernel_panic.Cargar_especialidad_profesional
AS
	INSERT INTO kernel_panic.Especialidad_Profesional (Especialidad_codigo, Profesional_id)
	SELECT M.Especialidad_Codigo, P.Id
	FROM gd_esquema.Maestra AS M JOIN kernel_panic.Profesionales AS P ON (P.Numero_doc = M.Medico_Dni)
	GROUP BY M.Especialidad_Codigo, P.Id
GO

CREATE PROCEDURE kernel_panic.Cargar_turnos
AS
	SET IDENTITY_INSERT kernel_panic.Turnos ON
	INSERT INTO kernel_panic.Turnos (Id,Afiliado_id, Profesional_id, Fecha, Especialidad)
	SELECT M.Turno_Numero, A.Id, P.Id, M.Turno_Fecha, M.Especialidad_Codigo
	FROM gd_esquema.Maestra AS M JOIN kernel_panic.Profesionales AS P ON (P.Numero_doc = M.Medico_Dni)
								 JOIN kernel_panic.Afiliados AS A ON (M.Paciente_Dni = A.Numero_doc)
	GROUP BY M.Especialidad_Codigo, P.Id, A.Id, M.Turno_Numero, M.Turno_Fecha
	SET IDENTITY_INSERT kernel_panic.Turnos OFF
GO

CREATE PROCEDURE kernel_panic.Cargar_diagnosticos
AS
	INSERT INTO kernel_panic.Diagnosticos (Afiliado_id, Profesional_id, Fecha, Sintoma, Enfermedad)
	SELECT A.Id, P.Id, M.Turno_Fecha, M.Consulta_Sintomas, M.Consulta_Enfermedades
	FROM gd_esquema.Maestra AS M JOIN kernel_panic.Profesionales AS P ON (P.Numero_doc = M.Medico_Dni)
								 JOIN kernel_panic.Afiliados AS A ON (M.Paciente_Dni = A.Numero_doc)
	WHERE M.Consulta_Sintomas IS NOT NULL
	GROUP BY A.Id, P.Id, M.Turno_Fecha, M.Consulta_Sintomas, M.Consulta_Enfermedades
GO

CREATE PROCEDURE kernel_panic.Cargar_transacciones
AS
	INSERT INTO kernel_panic.Transacciones (Cantidad, Precio, Fecha, Afiliado)
	SELECT COUNT(Bono_Consulta_Numero) /2, SUM(Plan_Med_Precio_Bono_Farmacia)/2 , Bono_Consulta_Fecha_Impresion, A.Id
	FROM gd_esquema.Maestra M JOIN kernel_panic.Afiliados A ON (A.Numero_doc = M.Paciente_Dni)
	WHERE Bono_Consulta_Fecha_Impresion IS NOT NULL
	GROUP BY Bono_Consulta_Fecha_Impresion,A.Id
GO

CREATE PROCEDURE kernel_panic.CargarBonos
AS
	SET IDENTITY_INSERT kernel_panic.Bonos_Consultas ON

	SELECT M.Bono_Consulta_Numero numeroBono, M.Plan_Med_Codigo codigoPlan, M.Bono_Consulta_Fecha_Impresion fecha, M.Turno_Numero turno, M.Paciente_Dni dni
	INTO #auxBonos
	FROM gd_esquema.Maestra M
	WHERE Bono_Consulta_Fecha_Impresion IS NOT NULL AND Turno_Numero IS NOT NULL
	ORDER BY numeroBono

	--Datos afiliado
	DECLARE @afiliadoId AS INT
	DECLARE @afiliadoDoc AS numeric(18,0)
	DECLARE @numGrupo AS INT

	--Datos bono

	--Cursor Afiliado
	DECLARE CursorAfiliado CURSOR FOR SELECT Id, Numero_doc, Numero_de_grupo FROM kernel_panic.Afiliados
	--abrimos cursor afiliado para comenzar migracion
	OPEN CursorAfiliado

	FETCH NEXT FROM CursorAfiliado INTO @afiliadoId, @afiliadoDoc, @numGrupo

	WHILE @@FETCH_STATUS = 0
		BEGIN

			INSERT INTO kernel_panic.Bonos_Consultas (Id,Nro_consulta,Grupo_afiliado,Plan_Uso,Afiliado_Uso,Fecha_Bono_compra,Fecha_Impresion,Turno)
			SELECT numeroBono, ROW_NUMBER() OVER (ORDER BY numeroBono), @numGrupo, codigoPlan, @afiliadoId, fecha,fecha, turno
			FROM #auxBonos
			WHERE dni = @afiliadoDoc

			FETCH NEXT FROM CursorAfiliado INTO @afiliadoId, @afiliadoDoc, @numGrupo		
		END
	CLOSE CursorAfiliado
	DEALLOCATE CursorAfiliado
	SET IDENTITY_INSERT kernel_panic.Bonos_Consultas OFF
GO

CREATE PROCEDURE kernel_panic.CargarRoles
AS
	INSERT INTO kernel_panic.Roles (Nombre, Esta_activo) VALUES ('Administrativo',1), ('Afiliado',1), ('Profesional',1)
GO

CREATE PROCEDURE kernel_panic.CargarFuncionalidades
AS
	INSERT INTO kernel_panic.Funciones (Nombre) VALUES ('ABM Roles'), ('ABM Afiliado'), ('ABM Agenda'), ('ABM Bonos'), ('ABM Turnos'), ('Llegada afiliado'), ('Resultado atencion medica'), ('ABM Cancelaciones'), ('Listado Estadistico')
GO

CREATE PROCEDURE kernel_panic.CargarRoles_Funcionalidad
AS
	INSERT INTO kernel_panic.Funciones_Roles (Rol_id,Funcion_id) VALUES (1,1),(1,2),(1,3),(1,4),(1,6),(1,9),(2,4),(2,5),(2,8),(3,7),(3,8)
GO

CREATE PROCEDURE kernel_panic.chequearUsuario
@nombreUsuario VARCHAR(50),
@pass CHAR(64),
@fallo INT OUTPUT
AS
	SELECT Nombre_usuario, Password_usuario, Intentos_fallidos, Habilitado 
	INTO #user 
	FROM kernel_panic.Usuarios 
	WHERE Nombre_usuario = @nombreUsuario 

	IF (SELECT Password_usuario FROM #user) LIKE @pass
		BEGIN
			IF (SELECT Habilitado FROM #user) = 0
				BEGIN
					SET @fallo = -1 /*No habilitado*/
					return
				END
			ELSE
				BEGIN
					UPDATE kernel_panic.Usuarios
					SET Intentos_fallidos = 0
					WHERE Nombre_usuario = @nombreUsuario
					SET @fallo = 1 /*Logeo exitoso*/
					return
				END
		END
	ELSE
		BEGIN
			UPDATE kernel_panic.Usuarios
			SET Intentos_fallidos = (SELECT Intentos_fallidos FROM #user) + 1
			WHERE Nombre_usuario = @nombreUsuario
			IF ((SELECT Intentos_fallidos FROM #user) + 1) = 3
				BEGIN
					UPDATE kernel_panic.Usuarios
					SET Habilitado = 0
					WHERE Nombre_usuario = @nombreUsuario
				END
			SET @fallo = 2 /*Contraseņa Incorrecta*/
			return
		END
	DROP TABLE #user
GO



CREATE PROCEDURE kernel_panic.crearUsuarioYRolesxU
AS
INSERT INTO kernel_panic.Usuarios (Nombre_usuario, Password_usuario) VALUES ('afiliado', '6b3f098db13fa8125179e832290d47df03bc6964fc76438f369e7d521cf0f15d') -- feli1234 la pass
INSERT INTO kernel_panic.Usuarios (Nombre_usuario, Password_usuario) VALUES ('profesional', '6b3f098db13fa8125179e832290d47df03bc6964fc76438f369e7d521cf0f15d') --feli1234 la pass
INSERT INTO kernel_panic.Usuarios (Nombre_usuario, Password_usuario) VALUES ('admin', 'dab4730e1ca848e8e23706ab952f88bb1df47d2410396b6f8389e1b35e77f496') --w23e la pass
INSERT INTO kernel_panic.Usuarios (Nombre_usuario, Password_usuario) VALUES ('a', '8f064368a44028fa577ccedd966721ef7b00de5537f04c5df084b3bcf6ec4d32') --a la pass
INSERT INTO kernel_panic.Roles_Usuario (Rol_id, Usuario_id) VALUES (1, 'admin'), (2, 'afiliado'), (3,'profesional'), (1, 'a')
GO


CREATE PROCEDURE kernel_panic.agregarRol
@nombreRol VARCHAR(20),
@id_rol INT OUTPUT
AS
	DECLARE @repetido AS INT
	SET @repetido = (SELECT COUNT(Id) FROM kernel_panic.Roles WHERE Nombre = @nombreRol)
	IF  @repetido = 0
		BEGIN
			INSERT INTO kernel_panic.Roles (Nombre) VALUES (@nombreRol)
			SET @id_rol = @@IDENTITY
		END
	ELSE
		BEGIN 
			SET @id_rol = -1
		END
GO

CREATE PROCEDURE kernel_panic.agregarEsquemaAgenda --Aca se podria validar si ya existe una franja con esos valores, etc..
@profesional INT,
@fechaDesde DATETIME,
@fechaHasta DATETIME,
@id INT OUTPUT
AS
	IF(SELECT COUNT(*) FROM kernel_panic.Esquema_Trabajo WHERE @fechaDesde BETWEEN Desde AND Hasta OR @fechaHasta BETWEEN Desde AND Hasta) > 0
	BEGIN
		SET @id = -1
	END
	ELSE
	BEGIN
		INSERT INTO kernel_panic.Esquema_Trabajo (Profesional, Desde, Hasta) VALUES (@profesional, @fechaDesde, @fechaHasta)
		SET @id = @@IDENTITY
	END
GO

CREATE PROCEDURE kernel_panic.agregarDiaAgenda
@esquema INT,
@dia INT,
@horaDesde TIME,
@horaHasta TIME,
@especialidad numeric(18,0)
AS
	INSERT INTO kernel_panic.Agenda_Diaria (EsquemaTrabajo, Dia, Desde, Hasta, Especialidad) VALUES (@esquema, @dia, @horaDesde, @horaHasta, @especialidad)
GO

EXEC kernel_panic.BorrarTablas
EXEC kernel_panic.CrearTablas
EXEC kernel_panic.Cargar_planes
EXEC kernel_panic.Cargar_registro_afiliados
EXEC kernel_panic.Cargar_tipo_especialidad
EXEC kernel_panic.Cargar_especialidades
EXEC kernel_panic.Cargar_profesionales
EXEC kernel_panic.Cargar_especialidad_profesional
EXEC kernel_panic.Cargar_turnos
EXEC kernel_panic.Cargar_diagnosticos
EXEC kernel_panic.Cargar_transacciones
EXEC kernel_panic.CargarBonos
EXEC kernel_panic.CargarRoles
EXEC kernel_panic.CargarFuncionalidades
EXEC kernel_panic.CargarRoles_Funcionalidad
EXEC kernel_panic.crearUsuarioYRolesxU

DROP PROCEDURE kernel_panic.BorrarTablas
DROP PROCEDURE kernel_panic.CrearTablas
DROP PROCEDURE kernel_panic.Cargar_planes
DROP PROCEDURE kernel_panic.Cargar_registro_afiliados
DROP PROCEDURE kernel_panic.Cargar_tipo_especialidad
DROP PROCEDURE kernel_panic.Cargar_especialidades
DROP PROCEDURE kernel_panic.Cargar_profesionales
DROP PROCEDURE kernel_panic.Cargar_especialidad_profesional
DROP PROCEDURE kernel_panic.Cargar_turnos
DROP PROCEDURE kernel_panic.Cargar_diagnosticos
DROP PROCEDURE kernel_panic.Cargar_transacciones
DROP PROCEDURE kernel_panic.CargarBonos
DROP PROCEDURE kernel_panic.CargarRoles
DROP PROCEDURE kernel_panic.CargarFuncionalidades
DROP PROCEDURE kernel_panic.CargarRoles_Funcionalidad
DROP PROCEDURE kernel_panic.chequearUsuario
DROP PROCEDURE kernel_panic.crearUsuarioYRolesxU
DROP PROCEDURE kernel_panic.agregarRol
DROP PROCEDURE kernel_panic.agregarEsquemaAgenda
DROP PROCEDURE kernel_panic.agregarDiaAgenda

