CREATE PROCEDURE CrearTablas
AS
CREATE TABLE Roles (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR (20) NOT NULL,
	Esta_activo BIT NOT NULL); -- El BIT es BOOLEANO, 0 es false y 1 es true.

CREATE TABLE Funciones (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(50) NOT NULL);

CREATE TABLE Funciones_Roles(
	Rol_id INT,
	Funcion_id INT,
	PRIMARY KEY(Rol_id, Funcion_id),
	FOREIGN KEY(Rol_id) REFERENCES Roles (Id),
	FOREIGN KEY(Funcion_id) REFERENCES Funciones (Id));

CREATE TABLE Usuarios(
	Nombre_usuario VARCHAR(50) PRIMARY KEY, --Nombre usuario
	Password_usuario CHAR(32) NOT NULL,
	Nombre VARCHAR(255),
	Intentos_fallidos INT DEFAULT 0,
	Habilitado BIT NOT NULL DEFAULT 1); --1 es habilitado, 0 no.

CREATE TABLE Roles_Usuario(
	Rol_id INT,
	Usuario_id VARCHAR(50),
	PRIMARY KEY(Rol_id,Usuario_id),
	FOREIGN KEY(Rol_id) REFERENCES Roles (Id),
	FOREIGN KEY(Usuario_id) REFERENCES Usuarios (Nombre_usuario)); 

CREATE TABLE Planes(	--Todos valores de tabla maestra
	Codigo numeric(18,0) PRIMARY KEY,
	Descripcion VARCHAR(255),
	Precio_bono_consulta numeric(18,0),
	Precio_bono_farmacia numeric(18,0));

CREATE TABLE Grupos_Familiares(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Plan_Grupo numeric(18,0),
	FOREIGN KEY (Plan_Grupo) REFERENCES Planes (Codigo));

CREATE TABLE Afiliados(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Numero_de_Grupo INT,
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
	FOREIGN KEY (Nombre_usuario) REFERENCES Usuarios (Nombre_usuario),
	FOREIGN KEY (Numero_de_Grupo) REFERENCES Grupos_Familiares(Id));

CREATE TABLE LogsCambioAfiliados(
	Id INT IDENTITY (1,1) PRIMARY KEY,
	Afiliado INT,
	Fecha DATETIME,
	Descripcion VARCHAR(255)
	FOREIGN KEY(Afiliado) REFERENCES Afiliados (Id));


CREATE TABLE Transacciones(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Cantidad INT NOT NULL,
	Precio INT NOT NULL,
	Fecha DATETIME NOT NULL,
	Afiliado INT,
	FOREIGN KEY (Afiliado) REFERENCES Afiliados (Id));

CREATE TABLE Profesionales(
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
	FOREIGN KEY (Usuario_id) REFERENCES Usuarios (Nombre_usuario),
	Profesional_matricula VARCHAR (50));

CREATE TABLE Tipo_Especialidad(
	Codigo numeric(18,0) PRIMARY KEY,
	Descripcion VARCHAR(255) NOT NULL);

CREATE TABLE Especialidades(
	Codigo numeric(18,0) PRIMARY KEY,
	Descripcion VARCHAR(255) NOT NULL,
	Tipo numeric(18,0)
	FOREIGN KEY (Tipo) REFERENCES Tipo_Especialidad (Codigo));

CREATE TABLE Especialidad_Profesional(
	Especialidad_codigo numeric(18,0),
	Profesional_id INT,
	PRIMARY KEY(Especialidad_codigo,Profesional_id),
	FOREIGN KEY(Especialidad_codigo) REFERENCES Especialidades (Codigo),
	FOREIGN KEY(Profesional_id) REFERENCES Profesionales (Id));

CREATE TABLE Cancelaciones(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Tipo VARCHAR(30) CHECK (Tipo IN ('Afiliado', 'Profesional')),
	Detalle VARCHAR(400),
	Fecha DATETIME);

CREATE TABLE Turnos(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Afiliado_id INT NOT NULL,
	Profesional_id INT NOT NULL,
	Fecha DATETIME NOT NULL,
	Especialidad numeric(18,0) NOT NULL,
	Fecha_llegada DATETIME NULL,
	Cancelacion INT NULL,
	FOREIGN KEY(Afiliado_id) REFERENCES Afiliados (Id),
	FOREIGN KEY(Profesional_id) REFERENCES Profesionales (Id),
	FOREIGN KEY(Especialidad) REFERENCES Especialidades (Codigo),
	FOREIGN KEY(Cancelacion) REFERENCES Cancelaciones (Id));

CREATE TABLE Diagnosticos(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Af_Id INT NOT NULL,
	Pf_Id INT NOT NULL,
	Fecha DATETIME NOT NULL,
	Sintoma VARCHAR(255) NOT NULL,
	Enfermedad VARCHAR(255),
	FOREIGN KEY(Af_Id) REFERENCES Afiliados (Id),
	FOREIGN KEY(Pf_Id) REFERENCES Profesionales (Id));

CREATE TABLE Bonos_Consultas(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nro_Consulta INT NULL,
	GrupAf INT NOT NULL,
	Plan_Uso numeric(18,0) NOT NULL,
	Af_Uso INT NULL, --Afiliado que lo utilizo
	Fecha_Bono DATETIME,
	Fecha_Imp DATETIME,
	Turno INT NULL,
	FOREIGN KEY(GrupAf) REFERENCES Grupos_Familiares (Id),
	FOREIGN KEY(Plan_Uso) REFERENCES Planes (Codigo),
	FOREIGN KEY(Turno) REFERENCES Turnos (Id),
	FOREIGN KEY(Af_Uso) REFERENCES Afiliados (Id));

CREATE TABLE Bonos_Farmacia(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Afiliado_uso INT NULL,
	Grupo_Afiliado INT NOT NULL,
	Plan_Uso numeric(18,0) NOT NULL,
	Fecha DATETIME,
	FOREIGN KEY(Grupo_Afiliado) REFERENCES Grupos_Familiares (Id),
	FOREIGN KEY(Plan_Uso) REFERENCES Planes (Codigo),
	FOREIGN KEY(Afiliado_uso) REFERENCES Afiliados (Id));

CREATE TABLE Agenda_Laboral(
	Id INT IDENTITY(1,1),
	Profesional INT,
	Dia DATETIME,
	Desde TIME,
	Hasta TIME,
	Cancelado INT NULL,
	FOREIGN KEY (Profesional) REFERENCES Profesionales (Id),
	FOREIGN KEY(Cancelado) REFERENCES Cancelaciones (Id));
GO


CREATE PROCEDURE BorrarTablas
AS
DROP TABLE Agenda_Laboral
DROP TABLE Bonos_Farmacia
DROP TABLE Bonos_Consultas
DROP TABLE Diagnosticos
DROP TABLE Turnos
DROP TABLE Cancelaciones
DROP TABLE Especialidad_Profesional
DROP TABLE Especialidades
DROP TABLE Tipo_Especialidad
DROP TABLE Profesionales
DROP TABLE Transacciones
DROP TABLE LogsCambioAfiliados
DROP TABLE Afiliados
DROP TABLE Grupos_Familiares
DROP TABLE Planes
DROP TABLE Roles_Usuario
DROP TABLE Usuarios
DROP TABLE Funciones_Roles
DROP TABLE Funciones
DROP TABLE Roles
GO

CREATE PROCEDURE RegistroAfiliados
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
	DECLARE CursorPaciente CURSOR FOR SELECT Paciente_Nombre, Paciente_Apellido, Paciente_Dni, Paciente_Direccion, Paciente_Telefono, Paciente_Mail, Paciente_Fecha_Nac, Plan_Med_Codigo FROM #auxiliarPaciente
	--Abrimos cursor
	OPEN CursorPaciente
	FETCH NEXT FROM CursorPaciente INTO @PacienteNombre, @PacienteApellido, @PacienteDNI, @PacienteDireccion, @PacienteTelefono, @PacienteMail, @PacienteFechaNac, @PlanMed

	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO dbo.Grupos_Familiares (Plan_Grupo) VALUES (@PlanMed)
		INSERT INTO dbo.Afiliados (Numero_de_grupo, Numero_en_el_grupo ,Nombre, Apellido, Tipo_doc, Numero_doc, Direccion, Telefono, Mail, Fecha_nacimiento, Sexo, Estado_civil, Familiares_a_cargo, Esta_activo, Nombre_usuario)
		VALUES
		((SELECT TOP 1 Id FROM dbo.Grupos_Familiares ORDER BY Id DESC),01, @PacienteNombre, @PacienteApellido,'DNI', @PacienteDNI, @PacienteDireccion, @PacienteTelefono,@PacienteMail,@PacienteFechaNac,NULL,NULL,NULL,1,NULL)
		FETCH NEXT FROM CursorPaciente INTO @PacienteNombre, @PacienteApellido, @PacienteDNI, @PacienteDireccion, @PacienteTelefono, @PacienteMail, @PacienteFechaNac, @PlanMed
		
	END
	CLOSE CursorPaciente
	DEALLOCATE CursorPaciente
	DROP TABLE #auxiliarPaciente
GO


CREATE PROCEDURE RegistrarPlanes
AS
INSERT INTO dbo.Planes (Codigo, Descripcion, Precio_bono_consulta, Precio_bono_farmacia)
SELECT DISTINCT Plan_Med_Codigo, Plan_Med_Descripcion, Plan_Med_Precio_Bono_Consulta, Plan_Med_Precio_Bono_Farmacia
FROM gd_esquema.Maestra
GO

EXEC BorrarTablas
EXEC CrearTablas
EXEC RegistrarPlanes
EXEC RegistroAfiliados


	