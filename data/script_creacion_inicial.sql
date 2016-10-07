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
		Tipo VARCHAR(1) NOT NULL CHECK(Tipo IN('A','B','M')),	
		Afiliado INT NOT NULL,
		Fecha DATETIME NOT NULL DEFAULT GETDATE(),
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
		Fecha DATETIME,
		Sintoma VARCHAR(255),
		Enfermedad VARCHAR(255),
		Turno_id INT NOT NULL,
		FOREIGN KEY(Turno_id) REFERENCES [kernel_panic].[Turnos] (Id),
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

	CREATE TABLE [kernel_panic].[Esquema_Trabajo] (
		Id INT IDENTITY (1,1) PRIMARY KEY,
		Profesional INT,
		Desde DATE,
		Hasta DATE,
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
		Desde DATE,
		Hasta DATE,
		FOREIGN KEY (EsquemaTrabajo) REFERENCES [kernel_panic].[Esquema_Trabajo] (Id));
GO

CREATE PROCEDURE kernel_panic.BorrarTablas
AS
	DROP TABLE [kernel_panic].[Franjas_Canceladas]
	DROP TABLE [kernel_panic].[Agenda_Diaria]
	DROP TABLE [kernel_panic].[Esquema_Trabajo]
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
		
		INSERT INTO kernel_panic.Roles_Usuario (Rol_id, Usuario_id) VALUES (2,CONVERT(VARCHAR(50), @IdAfiliadoReal))


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
		
		INSERT INTO kernel_panic.Roles_Usuario (Rol_id, Usuario_id) VALUES (3,CONVERT(VARCHAR(50), @MedicoDNI))
						
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
	INSERT INTO kernel_panic.Turnos (Id,Afiliado_id, Profesional_id, Fecha, Especialidad, Fecha_llegada)
	SELECT M.Turno_Numero, A.Id, P.Id, M.Turno_Fecha, M.Especialidad_Codigo, M.Turno_Fecha
	FROM gd_esquema.Maestra AS M JOIN kernel_panic.Profesionales AS P ON (P.Numero_doc = M.Medico_Dni)
								 JOIN kernel_panic.Afiliados AS A ON (M.Paciente_Dni = A.Numero_doc)
	GROUP BY M.Especialidad_Codigo, P.Id, A.Id, M.Turno_Numero, M.Turno_Fecha
	SET IDENTITY_INSERT kernel_panic.Turnos OFF
GO

CREATE PROCEDURE kernel_panic.Cargar_diagnosticos
AS
	INSERT INTO kernel_panic.Diagnosticos (Afiliado_id, Profesional_id, Fecha, Sintoma, Enfermedad, Turno_id)
	SELECT A.Id, P.Id, M.Turno_Fecha, M.Consulta_Sintomas, M.Consulta_Enfermedades,M.Turno_Numero
	FROM gd_esquema.Maestra AS M JOIN kernel_panic.Profesionales AS P ON (P.Numero_doc = M.Medico_Dni)
								 JOIN kernel_panic.Afiliados AS A ON (M.Paciente_Dni = A.Numero_doc)
	WHERE M.Consulta_Sintomas IS NOT NULL
	GROUP BY A.Id, P.Id, M.Turno_Fecha, M.Consulta_Sintomas, M.Consulta_Enfermedades, M.Turno_Numero
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

	IF (SELECT Password_usuario FROM #user) = @pass
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
			IF EXISTS (SELECT Password_usuario FROM #user) AND (SELECT Password_usuario FROM #user) IS NULL
				BEGIN
					SET @fallo = 3 --Primer logeo usuario
					return
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
				SET @fallo = 2 /*Contraseña Incorrecta*/
				return
				END
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
@fechaDesde DATE,
@fechaHasta DATE,
@id INT OUTPUT
AS
	IF(SELECT COUNT(*) FROM kernel_panic.Esquema_Trabajo WHERE (@fechaDesde BETWEEN Desde AND Hasta OR @fechaHasta BETWEEN Desde AND Hasta) AND Profesional = @profesional) > 0
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

CREATE PROCEDURE kernel_panic.cancelarTurnoAfi
@idTurno INT,
@detalle VARCHAR(400),
@tipo VARCHAR(30)
AS
	INSERT INTO kernel_panic.Cancelaciones (Tipo, Detalle, Fecha) VALUES (@tipo, @detalle, GETDATE())
	UPDATE kernel_panic.Turnos SET Cancelacion = @@IDENTITY WHERE Id = @idTurno
GO

CREATE PROCEDURE kernel_panic.cancelarDiaProfesional
@dia DATE,
@profesional INT,
@detalle VARCHAR(400),
@tipo VARCHAR(30),
@fallo INT OUTPUT
AS
	IF EXISTS (SELECT EM.Id FROM kernel_panic.Esquema_Trabajo EM WHERE (@dia BETWEEN EM.Desde AND EM.Hasta) AND Profesional = @profesional)
		BEGIN
		INSERT INTO kernel_panic.Cancelaciones (Tipo, Detalle, Fecha) VALUES (@tipo, @detalle, GETDATE())
		UPDATE kernel_panic.Turnos SET Cancelacion = @@IDENTITY WHERE Profesional_id = @profesional AND CONVERT(DATE,Fecha) = @dia
		INSERT INTO kernel_panic.Franjas_Canceladas (EsquemaTrabajo, Desde, Hasta) VALUES ((SELECT EM.Id FROM kernel_panic.Esquema_Trabajo EM WHERE (@dia BETWEEN EM.Desde AND EM.Hasta) AND Profesional = @profesional),@dia,@dia)
		SET @fallo = 1 --funco
		END
	ELSE
		BEGIN
		SET @fallo = -1 --fallo
		END
GO

CREATE PROCEDURE kernel_panic.cancelarFranjaProfesional
@desde DATE,
@hasta DATE,
@profesional INT,
@detalle VARCHAR(400),
@tipo VARCHAR(30),
@fallo INT OUTPUT
AS
	IF EXISTS (SELECT EM.Id FROM kernel_panic.Esquema_Trabajo EM WHERE (@desde BETWEEN EM.Desde AND EM.Hasta OR @hasta BETWEEN EM.Desde AND EM.Hasta) AND Profesional = @profesional)
		BEGIN
		INSERT INTO kernel_panic.Cancelaciones (Tipo, Detalle, Fecha) VALUES (@tipo, @detalle, GETDATE())
		UPDATE kernel_panic.Turnos SET Cancelacion = @@IDENTITY WHERE Profesional_id = @profesional AND Fecha BETWEEN @desde AND @hasta
		INSERT INTO kernel_panic.Franjas_Canceladas (EsquemaTrabajo, Desde, Hasta)
		SELECT EM.Id,@desde,@hasta FROM kernel_panic.Esquema_Trabajo EM WHERE (@desde BETWEEN EM.Desde AND EM.Hasta OR @hasta BETWEEN EM.Desde AND EM.Hasta) AND Profesional = @profesional
		SET @fallo = 1
		END
	ELSE
		BEGIN
		SET @fallo = -1
		END
GO


CREATE PROCEDURE kernel_panic.consultaNueva
@afiliado INT,
@profesional INT,
@idConsulta INT OUTPUT,
@idTurno INT OUTPUT
AS

	SELECT D.Id idConsulta, T.Id idTurno
	INTO #consulta
	FROM kernel_panic.Diagnosticos D JOIN kernel_panic.Turnos T ON (D.Turno_id = T.Id)	
	WHERE T.Cancelacion IS NULL AND D.Fecha IS NULL AND T.Afiliado_id = @afiliado AND T.Profesional_id = @profesional
	ORDER BY D.Id ASC

	IF (SELECT COUNT(idConsulta) FROM #consulta) = 0 
	BEGIN
		SET @idConsulta = -1
	END
	ELSE
	BEGIN
		SET @idConsulta = (SELECT TOP 1 idConsulta FROM #consulta)
		SET @idTurno = (SELECT TOP 1 idTurno FROM #consulta)
	END

	DROP TABLE #consulta
GO

CREATE PROCEDURE kernel_panic.agregarRegistroDeLogsInicial
AS
declare @1 int
set @1 = (select top 1 Id from kernel_panic.Afiliados)
insert into kernel_panic.LogsCambioAfiliados (Afiliado, Tipo, Descripcion) values (@1,'M','se modifico')
insert into kernel_panic.LogsCambioAfiliados (Afiliado, Tipo, Descripcion) values (@1,'B','se elimino')
insert into kernel_panic.LogsCambioAfiliados (Afiliado, Tipo, Descripcion) values (@1,'M','se habilito')
GO

create procedure kernel_panic.baja_logica_afiliado (@Id int, @Motivo varchar(500)) AS
declare @fec datetime
set @fec = GETDATE()
insert into GD2C2016.kernel_panic.LogsCambioAfiliados (Tipo, Afiliado, Descripcion) values ('B',@Id, @Motivo)
update GD2C2016.kernel_panic.Afiliados SET GD2C2016.kernel_panic.Afiliados.Esta_Activo= 0 where GD2C2016.kernel_panic.Afiliados.Id = @Id
	IF (select COUNT(GD2C2016.kernel_panic.Turnos.Id)  from GD2C2016.kernel_panic.Turnos where GD2C2016.kernel_panic.Turnos.Afiliado_Id = @Id 
	AND GD2C2016.kernel_panic.Turnos.Fecha > @fec and GD2C2016.kernel_panic.Turnos.Cancelacion IS NULL ) > 0
	Begin
	INSERT INTO kernel_panic.Cancelaciones (Tipo, Detalle, Fecha) VALUES ('Afiliado', @Motivo, @fec)
	UPDATE kernel_panic.Turnos SET Cancelacion = @@IDENTITY WHERE Id = @id
	End
GO

create procedure kernel_panic.alta_afiliado
--recibo parametros
		@Nom VARCHAR(255),
		@Ape VARCHAR(255),
		@Tipo_doc VARCHAR(15),
		@Doc numeric(18,0),
		@Dire VARCHAR(255),
		@Tel numeric(18,0),
		@Mail VARCHAR(255),
		@Fecha_nac VARCHAR(30),
		@Sexo CHAR,
		@Estado_civil VARCHAR(20), 
		@Hijos INT,
		@Plan_Medico numeric(18,0) 
AS
	declare @Id int
	declare @IdAfiReal int
	IF (select COUNT(GD2C2016.kernel_panic.Afiliados.Numero_doc)  from GD2C2016.kernel_panic.Afiliados where GD2C2016.kernel_panic.Afiliados.Numero_doc = @Doc) > 0
	begin
	print 'Afiliado con Tipo de documento '+@Tipo_doc+' y documento '+CONVERT(VARCHAR(20), @Doc)+' ya existe'
	set @IdAfiReal = (select Id from kernel_panic.Afiliados where kernel_panic.Afiliados.Tipo_doc = @Tipo_doc AND kernel_panic.Afiliados.Numero_doc = @Doc)
	print 'El Afiliado Id es: '+CONVERT(VARCHAR(20), @IdAfiReal)
	return -@IdAfiReal
	end
	Else begin
		insert into GD2C2016.kernel_panic.Grupos_Familiares (Plan_grupo) values (@Plan_Medico)
			if @@rowcount = 0
				begin
				print 'El Afiliado no ha podido ser asociado al Plan Medico'
				return 2			
			end
		set @Id = @@IDENTITY
		set @IdAfiReal = CONVERT(INT,CONVERT(VARCHAR(20),@Id)+'01')
		insert into kernel_panic.Usuarios (Nombre_usuario, Password_usuario, Habilitado) values (CONVERT(VARCHAR(50), @IdAfiReal), 'default', 0)
			if @@rowcount = 0
			begin
			print 'No se ha podido crear el usuario'+@IdAfiReal
				IF @@ERROR <> 0
				BEGIN
					 PRINT N'ERROR: error '
                    + RTRIM(CAST(@@ERROR AS NVARCHAR(10)))
                    + N' occurred.'
				END
			return 3		
			end
		INSERT INTO kernel_panic.Afiliados (Id,Numero_de_grupo, Numero_en_el_grupo ,Nombre, Apellido, Tipo_doc, Numero_doc, Direccion, Telefono, Mail, Fecha_nacimiento, Sexo, Estado_civil, Familiares_a_cargo, Esta_activo, Nombre_usuario)
		VALUES
		(@IdAfiReal, @Id, 1, @Nom,@Ape, @Tipo_doc, @Doc, @Dire, @Tel, @Mail, CONVERT(datetime, @Fecha_nac, 120), @Sexo, @Estado_civil, @Hijos, 0, (CONVERT(VARCHAR(50), @IdAfiReal)) )
		if @@rowcount = 0
		begin
			print 'No se ha podido ingresar el alta del afiliado'+@IdAfiReal
			IF @@ERROR <> 0
			BEGIN
                PRINT N'ERROR: error '
                    + RTRIM(CAST(@@ERROR AS NVARCHAR(10)))
                    + N' occurred.'
			END
            RETURN 4
		 END
		 RETURN @IdAfiReal
	end
GO

--Alta/Habilitacion usuario existente
create procedure kernel_panic.rehabilitar_alta @IdAfiliado int
AS
	IF (@IdAfiliado < 0)
		BEGIN
		SET @IdAfiliado = -@IdAfiliado
	END
	update kernel_panic.Afiliados SET Esta_activo = 0 where Id = @IdAfiliado
	IF @@rowcount = 0
		BEGIN
			PRINT 'Hubo un problema al habilitar el usuario'+@IdAfiliado
			IF @@ERROR <> 0
			BEGIN
                PRINT N'ERROR: error '
                    + RTRIM(CAST(@@ERROR AS NVARCHAR(10)))
                    + N' occurred.'
			END
		RETURN 1
	END
	INSERT INTO kernel_panic.LogsCambioAfiliados (Tipo, Afiliado, Descripcion) VALUES ('A',@IdAfiliado,'Se rehabilita el usuario')
	RETURN @IdAfiliado
GO

--Alta Conyugue 
create procedure kernel_panic.alta_conyuge
--recibo parametros
		@Nom VARCHAR(255),
		@Ape VARCHAR(255),
		@Tipo_doc VARCHAR(15),
		@Doc numeric(18,0),
		@Dire VARCHAR(255),
		@Tel numeric(18,0),
		@Mail VARCHAR(255),
		@Fecha_nac VARCHAR(30),
		@Sexo CHAR,
		@Plan_Medico numeric(18,0),
		@IdAfiInput int
AS
	DECLARE @Id int
	DECLARE @IdAfiReal int
	DECLARE @Hijos int
	DECLARE @Estado_civil VARCHAR(20)
	IF (select COUNT(kernel_panic.Afiliados.Numero_doc)  from kernel_panic.Afiliados where kernel_panic.Afiliados.Numero_doc = @Doc) > 0
	BEGIN
		PRINT 'Afiliado con Tipo de documento '+@Tipo_doc+' y documento '+CONVERT(VARCHAR(20), @Doc)+' ya existe'
		SET @IdAfiReal = (select Id from kernel_panic.Afiliados where kernel_panic.Afiliados.Tipo_doc = @Tipo_doc AND kernel_panic.Afiliados.Numero_doc = @Doc)
		PRINT 'El Afiliado Id es: '+CONVERT(VARCHAR(20), @IdAfiReal)
		RETURN -@IdAfiReal
	END
	ElSE BEGIN
		SET @Id = (SELECT Numero_de_grupo from kernel_panic.Afiliados where kernel_panic.Afiliados.Id = @IdAfiInput)
		SET @Estado_civil = (SELECT Estado_civil from kernel_panic.Afiliados where kernel_panic.Afiliados.Id = @IdAfiInput)
		SET @Hijos = (SELECT Familiares_a_cargo from kernel_panic.Afiliados where kernel_panic.Afiliados.Id = @IdAfiInput)
		SET @IdAfiReal = @IdAfiInput+1
		INSERT INTO kernel_panic.Usuarios (Nombre_usuario, Password_usuario, Habilitado) values (CONVERT(VARCHAR(50), @IdAfiReal), 'default', 0)
		IF @@rowcount = 0
		BEGIN
			PRINT 'No se ha podido crear el usuario'+@IdAfiReal
				IF @@ERROR <> 0
				BEGIN
					 PRINT N'ERROR: error '
                    + RTRIM(CAST(@@ERROR AS NVARCHAR(10)))
                    + N' occurred.'
				END
			RETURN 2		
		END
		INSERT INTO kernel_panic.Afiliados (Id,Numero_de_grupo, Numero_en_el_grupo ,Nombre, Apellido, Tipo_doc, Numero_doc, Direccion, Telefono, Mail, Fecha_nacimiento, Sexo, Estado_civil, Familiares_a_cargo, Esta_activo, Nombre_usuario)
		VALUES
		(@IdAfiReal, @Id, 2, @Nom,@Ape, @Tipo_doc, @Doc, @Dire, @Tel, @Mail, CONVERT(DATETIME, @Fecha_nac, 120), @Sexo, @Estado_civil, @Hijos, 0, (CONVERT(VARCHAR(50), @IdAfiReal)) )
		IF @@rowcount = 0
		BEGIN
			print 'No se ha podido ingresar el alta del afiliado'+@IdAfiReal
			IF @@ERROR <> 0
			BEGIN
                PRINT N'ERROR: error '
                    + RTRIM(CAST(@@ERROR AS NVARCHAR(10)))
                    + N' occurred.'
			END
            RETURN 3
		 END
		 RETURN @IdAfiReal
		 END
GO

DROP PROCEDURE kernel_panic.alta_hermano
--Alta hermano
create procedure kernel_panic.alta_hermano
--recibo parametros
		@Nom VARCHAR(255),
		@Ape VARCHAR(255),
		@Tipo_doc VARCHAR(15),
		@Doc numeric(18,0),
		@Dire VARCHAR(255),
		@Tel numeric(18,0),
		@Mail VARCHAR(255),
		@Fecha_nac VARCHAR(30),
		@Sexo CHAR,
		@Plan_Medico numeric(18,0),
		@NroHijo int,
		@IdAfiInput int
AS
	DECLARE @Id int
	DECLARE @CantHijos int
	DECLARE @IdAfiReal int
	DECLARE @Estado_civil VARCHAR(20)
	IF (select COUNT(kernel_panic.Afiliados.Numero_doc)  from kernel_panic.Afiliados where kernel_panic.Afiliados.Numero_doc = @Doc) > 0
	BEGIN
		PRINT 'Afiliado con Tipo de documento '+@Tipo_doc+' y documento '+CONVERT(VARCHAR(20), @Doc)+' ya existe'
		SET @IdAfiReal = (select Id from kernel_panic.Afiliados where kernel_panic.Afiliados.Tipo_doc = @Tipo_doc AND kernel_panic.Afiliados.Numero_doc = @Doc)
		PRINT 'El Afiliado Id es: '+CONVERT(VARCHAR(20), @IdAfiReal)
		RETURN -@IdAfiReal
	END
	ElSE BEGIN
		SET @Id = (SELECT Numero_de_grupo from kernel_panic.Afiliados where kernel_panic.Afiliados.Id = @IdAfiInput)
		SET @Estado_civil = 'Soltero/a'
		SET @CantHijos = (SELECT Familiares_a_cargo from kernel_panic.Afiliados where kernel_panic.Afiliados.Id = @IdAfiInput)
		--Reservo el 1 para el conyuge + el nro de hijo que estoy registrando
		SET @IdAfiReal = @IdAfiInput+1+@NroHijo
		INSERT INTO kernel_panic.Usuarios (Nombre_usuario, Password_usuario, Habilitado) values (CONVERT(VARCHAR(50), @IdAfiReal), 'default', 0)
		IF @@rowcount = 0
		BEGIN
			PRINT 'No se ha podido crear el usuario'+@IdAfiReal
				IF @@ERROR <> 0
				BEGIN
					 PRINT N'ERROR: error '
                    + RTRIM(CAST(@@ERROR AS NVARCHAR(10)))
                    + N' occurred.'
				END
			RETURN 2		
		END
		INSERT INTO kernel_panic.Afiliados (Id,Numero_de_grupo, Numero_en_el_grupo ,Nombre, Apellido, Tipo_doc, Numero_doc, Direccion, Telefono, Mail, Fecha_nacimiento, Sexo, Estado_civil, Familiares_a_cargo, Esta_activo, Nombre_usuario)
		VALUES
		(@IdAfiReal, @Id, @NroHijo, @Nom,@Ape, @Tipo_doc, @Doc, @Dire, @Tel, @Mail, CONVERT(DATETIME, @Fecha_nac, 120), @Sexo, @Estado_civil, NULL, 0, (CONVERT(VARCHAR(50), @IdAfiReal)) )
		IF @@rowcount = 0
		BEGIN
			print 'No se ha podido ingresar el alta del afiliado'+@IdAfiReal
			IF @@ERROR <> 0
			BEGIN
                PRINT N'ERROR: error '
                    + RTRIM(CAST(@@ERROR AS NVARCHAR(10)))
                    + N' occurred.'
			END
            RETURN 3
		 END
		 RETURN (@IdAfiReal-1-@NroHijo)
		 --Devuelvo el padre original
		 END
GO

Create trigger kernel_panic.Alta_AF_inserta_log
on GD2C2016.kernel_panic.Afiliados
after insert as
	begin
	declare @id numeric
	set @id = (select top 1 Id from inserted order by id DESC)
	insert into GD2C2016.kernel_panic.LogsCambioAfiliados (Tipo, Afiliado, Descripcion) values ('A',@id,'Alta de usuario')
	end
go


EXEC kernel_panic.BorrarTablas
EXEC kernel_panic.CrearTablas
EXEC kernel_panic.Cargar_planes
EXEC kernel_panic.CargarRoles
EXEC kernel_panic.CargarFuncionalidades
EXEC kernel_panic.CargarRoles_Funcionalidad
EXEC kernel_panic.crearUsuarioYRolesxU
EXEC kernel_panic.Cargar_registro_afiliados
EXEC kernel_panic.Cargar_tipo_especialidad
EXEC kernel_panic.Cargar_especialidades
EXEC kernel_panic.Cargar_profesionales
EXEC kernel_panic.Cargar_especialidad_profesional
EXEC kernel_panic.Cargar_turnos
EXEC kernel_panic.Cargar_diagnosticos
EXEC kernel_panic.Cargar_transacciones
EXEC kernel_panic.CargarBonos
EXEC kernel_panic.agregarRegistroDeLogsInicial


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
DROP PROCEDURE kernel_panic.cancelarTurnoAfi
DROP PROCEDURE kernel_panic.cancelarDiaProfesional
DROP PROCEDURE kernel_panic.cancelarFranjaProfesional
DROP PROCEDURE kernel_panic.agregarRegistroDeLogsInicial
DROP PROCEDURE kernel_panic.consultaNueva



--SELECT LISTADOS

--Listado 1
SELECT TOP 5 E.Descripcion AS Especialidad, T.Descripcion AS Tipo, COUNT(Tu.Id) AS Cantidad_cancelaciones,MONTH(Tu.Fecha)
FROM kernel_panic.Especialidades E JOIN kernel_panic.Tipo_Especialidad T ON (T.Codigo = E.Tipo)
								   JOIN kernel_panic.Turnos Tu ON (Tu.Especialidad = E.Codigo)
WHERE Tu.Cancelacion IS NOT NULL AND YEAR(Tu.Fecha)=2016	  
GROUP BY E.Descripcion, T.Descripcion,MONTH(Tu.Fecha)
ORDER BY cantidad_cancelaciones DESC


--Listado 2
SELECT TOP 5 P.Id Id, P.Nombre nombre, P.Apellido apellido, P.Tipo_doc tipoDoc, P.Numero_doc numeroDoc, COUNT(DISTINCT T.Id) Consultas
FROM kernel_panic.Profesionales P JOIN kernel_panic.Diagnosticos T ON(T.Profesional_id = P.Id)
								  JOIN kernel_panic.Afiliados A ON (T.Afiliado_id = A.Id)
								  JOIN kernel_panic.Grupos_Familiares GF ON (A.Numero_de_grupo = GF.Id)
								  JOIN kernel_panic.Turnos Tu ON (T.Turno_id = Tu.Id)
--WHERE Tu.Especialidad = @especialidad AND GF.Plan_grupo = @planGrupo AND YEAR(T.Fecha) = 2016 esto es para filtrar por año etc
GROUP BY P.Id, P.Nombre, P.Apellido, P.Tipo_doc, P.Numero_doc
ORDER BY COUNT(DISTINCT T.Id) DESC

--Listado 3
SELECT TOP 5 P.Id Id, P.Nombre nombre, P.Apellido apellido, P.Tipo_doc tipoDoc, P.Numero_doc numeroDoc, E.Desde desde,E.Hasta hasta,SUM(DATEDIFF(hour,AD.Desde, AD.Hasta))*DATEDIFF(week, E.Desde, E.Hasta) HorasTrabajadasEnFranja
FROM kernel_panic.Profesionales P JOIN kernel_panic.Esquema_Trabajo E ON (E.Profesional = P.Id)
								  JOIN kernel_panic.Agenda_Diaria AD ON (AD.EsquemaTrabajo = E.Id)
--WHERE AD.Especialidad = @especialidad
GROUP BY  P.Id, P.Nombre, P.Apellido, P.Tipo_doc, P.Numero_doc,E.Desde,E.Hasta
ORDER BY SUM(DATEDIFF(hour,AD.Desde, AD.Hasta))*DATEDIFF(week, E.Desde, E.Hasta) DESC

--Listado 4
SELECT TOP 5 A.Nombre Nombre, A.Apellido Apellido, SUM(T.Cantidad) AS Cantidad_Comprados, A.Numero_de_grupo,(SELECT CAST(
   CASE WHEN (SELECT COUNT(A2.Numero_de_grupo) FROM kernel_panic.Afiliados A2 WHERE A2.Numero_de_grupo = A.Numero_de_grupo) > 1 THEN 1 
   ELSE 0 
   END 
AS BIT)) AS pertenece_a_grupo
FROM kernel_panic.Afiliados A JOIN kernel_panic.Transacciones T ON (T.Afiliado = A.Id)
WHERE YEAR(T.Fecha)=2015 AND MONTH(T.Fecha)>6
GROUP BY A.Nombre, A.Apellido, A.Numero_de_grupo
ORDER BY Cantidad_Comprados DESC, A.Numero_de_grupo ASC

--Listado 5

SELECT TOP 5 E.Descripcion AS Especialidad,Ti.Descripcion AS Tipo,COUNT(B.Id) AS Bonos_Utilizados
FROM kernel_panic.Turnos T 
		JOIN kernel_panic.Bonos_Consultas B ON (T.Id=B.Turno)
		JOIN kernel_panic.Especialidades E ON (T.Especialidad= E.Codigo)
		JOIN kernel_panic.Tipo_Especialidad Ti ON (Ti.Codigo = E.Tipo)
GROUP BY  Ti.Descripcion,E.Descripcion
ORDER BY Bonos_Utilizados DESC


