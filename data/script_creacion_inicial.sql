CREATE TABLE Roles (
	Rol_id INT IDENTITY(1,1) PRIMARY KEY,
	Rol_nombre VARCHAR (20) NOT NULL,
	Rol_activo BIT NOT NULL); -- El BIT es BOOLEANO, 0 es false y 1 es true.

CREATE TABLE Funciones (
	Funcion_id INT IDENTITY(1,1) PRIMARY KEY,
	Fun_nombre VARCHAR(50) NOT NULL);

CREATE TABLE Funciones_Roles(
	Rol_id INT,
	Funcion_id INT,
	PRIMARY KEY(Rol_id, Funcion_id),
	FOREIGN KEY(Rol_id) REFERENCES Roles (Rol_id),
	FOREIGN KEY(Funcion_id) REFERENCES Funciones (Funcion_id));

CREATE TABLE Usuarios(
	Usuario_id VARCHAR(50) PRIMARY KEY, --Nombre usuario
	Usuario_password VARCHAR(150) NOT NULL,
	Usuario_nombre VARCHAR(255),
	Usuario_intentos INT DEFAULT 0,
	Usuario_habilitado BIT NOT NULL DEFAULT 1); --1 es habilitado, 0 no.

CREATE TABLE Roles_Usuario(
	Rol_id INT,
	Usuario_id VARCHAR(50),
	PRIMARY KEY(Rol_id,Usuario_id),
	FOREIGN KEY(Rol_id) REFERENCES Roles (Rol_id),
	FOREIGN KEY(Usuario_id) REFERENCES Usuarios (Usuario_id)); 

CREATE TABLE Planes(	--Todos valores de tabla maestra
	Plan_codigo numeric(18,0) PRIMARY KEY,
	Plan_descripcion VARCHAR(255),
	Plan_precio_bono_consulta numeric(18,0),
	Plan_precio_bono_farmacia numeric(18,0));

CREATE TABLE Grupos_Familiares(
	Grupo_id INT IDENTITY(1,1) PRIMARY KEY,
	Grupo_plan numeric(18,0),
	FOREIGN KEY (Grupo_plan) REFERENCES Planes (Plan_codigo));

CREATE TABLE Afiliados(
	Afiliado_id INT IDENTITY(1,1) PRIMARY KEY,
	Afiliado_grupo INT,
	Afiliado_numero INT, --Dentro del grupo familiar
	Afiliado_nombre VARCHAR(255) NOT NULL,
	Afiliado_apellido VARCHAR(255) NOT NULL,
	Afiliado_tipo VARCHAR(15) NOT NULL CHECK (Afiliado_tipo IN ('DNI', 'LD', 'LC', 'CI')),
	Afiliado_nroDoc numeric(18,0) NOT NULL,
	Afiliado_direccion VARCHAR(255) NOT NULL,
	Afiliado_telefono numeric(18,0) NULL,
	Afiliado_mail VARCHAR(255) NOT NULL,
	Afiliado_fec_nac DATETIME NOT NULL,
	Afiliado_sexo CHAR CHECK (Afiliado_sexo IN ('M', 'F')),
	Afiliado_estado_civil VARCHAR(20) CHECK (Afiliado_estado_civil IN ('Soltero/a', 'Casado/a', 'Viudo/a', 'Concubinato', 'Divorciado/a')),
	Afiliado_familiares_a_cargo INT,
	Afiliado_activo BIT, -- 1 activo, 0 desactivado
	FOREIGN KEY (Afiliado_grupo) REFERENCES Grupos_Familiares(Grupo_id));

CREATE TABLE LogsCambioAfiliados(
	Cambio_id INT IDENTITY (1,1) PRIMARY KEY,
	Cambio_afiliado INT,
	Cambio_fecha DATETIME,
	Cambio_descripcion VARCHAR(255)
	FOREIGN KEY(Cambio_afiliado) REFERENCES Afiliados (Afiliado_id));


CREATE TABLE Transacciones(
	Transaccion_id INT IDENTITY(1,1) PRIMARY KEY,
	Tansaccion_cantidad INT NOT NULL,
	Transaccion_precio INT NOT NULL,
	Transaccion_fecha DATETIME NOT NULL,
	Transaccion_afiliado INT,
	FOREIGN KEY (Transaccion_afiliado) REFERENCES Afiliados (Afiliado_id));

CREATE TABLE Profesionales(
	Profesional_id INT IDENTITY(1,1) PRIMARY KEY,
	Profesional_nombre VARCHAR(255) NOT NULL,
	Profesional_apellido VARCHAR(255) NOT NULL,
	Profesional_tipo VARCHAR(15) NOT NULL CHECK (Profesional_tipo IN ('DNI', 'LD', 'LC', 'CI')),
	Profesional_nroDoc numeric(18,0) NOT NULL,
	Profesional_direccion VARCHAR(255) NOT NULL,
	Profesional_telefono numeric(18,0) NULL,
	Profesional_mail VARCHAR(255) NOT NULL,
	Profesional_fec_nac DATETIME NOT NULL,
	Profesional_sexo CHAR CHECK (Profesional_sexo IN ('M', 'F')),
	Profesional_matricula VARCHAR (50));

CREATE TABLE Tipo_Especialidad(
	Tipo_codigo numeric(18,0) PRIMARY KEY,
	Tipo_descripcion VARCHAR(255) NOT NULL);

CREATE TABLE Especialidades(
	Especialidad_codigo numeric(18,0) PRIMARY KEY,
	Especialidad_descripcion VARCHAR(255) NOT NULL,
	Especialidad_tipo numeric(18,0)
	FOREIGN KEY (Especialidad_tipo) REFERENCES Tipo_Especialidad (Tipo_codigo));

CREATE TABLE Especialidad_Profesional(
	Especialidad_codigo numeric(18,0),
	Profesional_id INT,
	PRIMARY KEY(Especialidad_codigo,Profesional_id),
	FOREIGN KEY(Especialidad_codigo) REFERENCES Especialidades (Especialidad_codigo),
	FOREIGN KEY(Profesional_id) REFERENCES Profesionales (Profesional_id));

CREATE TABLE Cancelaciones(
	Cancelacion_id INT IDENTITY(1,1) PRIMARY KEY,
	Cancelacion_tipo VARCHAR(30) CHECK (Cancelacion_tipo IN ('Afiliado', 'Profesional')),
	Cancelacion_detalle VARCHAR(255),
	Cancelacion_fecha DATETIME);

CREATE TABLE Turnos(
	Turno_id INT IDENTITY(1,1) PRIMARY KEY,
	Turno_afiliado_id INT NOT NULL,
	Turno_profesional_id INT NOT NULL,
	Turno_fecha DATETIME NOT NULL,
	Turno_especialidad numeric(18,0) NOT NULL,
	Turno_fecha_llegada DATETIME NULL,
	Turno_cancelacion INT NULL,
	FOREIGN KEY(Turno_afiliado_id) REFERENCES Afiliados (Afiliado_id),
	FOREIGN KEY(Turno_profesional_id) REFERENCES Profesionales (Profesional_id),
	FOREIGN KEY(Turno_especialidad) REFERENCES Especialidades (Especialidad_codigo),
	FOREIGN KEY(Turno_cancelacion) REFERENCES Cancelaciones (Cancelacion_id));

CREATE TABLE Diagnosticos(
	Diagnostico_id INT IDENTITY(1,1) PRIMARY KEY,
	Diagnostico_Af_Id INT NOT NULL,
	Diagnostico_Pf_Id INT NOT NULL,
	Diagnostico_Fecha DATETIME NOT NULL,
	Diagnostico_sintoma VARCHAR(255) NOT NULL,
	Diagnostico_enfermedad VARCHAR(255),
	FOREIGN KEY(Diagnostico_Af_Id) REFERENCES Afiliados (Afiliado_id),
	FOREIGN KEY(Diagnostico_Pf_Id) REFERENCES Profesionales (Profesional_id));

CREATE TABLE Bonos_Consultas(
	Bonos_Consultas_Id INT IDENTITY(1,1) PRIMARY KEY,
	Bono_Cons_Nro_Consulta INT NULL,
	Bono_Cons_GrupAf INT NOT NULL,
	Bono_Cons_Plan numeric (18,0) NOT NULL,
	Bono_Cons_Af_Uso INT NULL, --Afiliado que lo utilizo
	Bono_Cons_Fecha_Bono DATETIME,
	Bono_Cons_Fecha_Imp DATETIME,
	Bono_Cons_Turno INT NULL,
	FOREIGN KEY(Bono_Cons_GrupAf) REFERENCES Grupos_Familiares (Grupo_id),
	FOREIGN KEY(Bono_Cons_Plan) REFERENCES Planes (Plan_codigo),
	FOREIGN KEY(Bono_Cons_Turno) REFERENCES Turnos (Turno_id),
	FOREIGN KEY(Bono_Cons_Af_Uso) REFERENCES Afiliados (Afiliado_id));

CREATE TABLE Bonos_Farmacia(
	Bono_Farm_id INT IDENTITY(1,1) PRIMARY KEY,
	Bono_Farm_Af_Uso INT NULL,
	Bono_Farm_GrupAf INT NOT NULL,
	Bono_Farm_Plan_Uso numeric(18,0) NOT NULL,
	Bono_Farm_Fecha DATETIME,
	FOREIGN KEY(Bono_Farm_GrupAf) REFERENCES Grupos_Familiares (Grupo_id),
	FOREIGN KEY(Bono_Farm_Plan_Uso) REFERENCES Planes (Plan_codigo),
	FOREIGN KEY(Bono_Farm_Af_Uso) REFERENCES Afiliados (Afiliado_id));

CREATE TABLE Agenda_Laboral(
	Disponibilidad_id INT IDENTITY(1,1),
	Disponibilidad_profesional INT,
	Disponibildiad_dia DATETIME,
	Disponibilidad_desde TIME,
	Disponibilidad_hasta TIME,
	Disponibilidad_cancelado INT,
	FOREIGN KEY (Disponibilidad_profesional) REFERENCES Profesionales (Profesional_id),
	FOREIGN KEY(Disponibilidad_cancelado) REFERENCES Cancelaciones (Cancelacion_id));

