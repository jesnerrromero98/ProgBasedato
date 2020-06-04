											
											--GESTOR DE BASE DATOS = SQL SERVER 2014 MANAGEMENT STUDIO--

CREATE DATABASE FRESHDENT /*SE CREA LA BASE DE DATOS APLICANDO NOMBRE A ELLA*/
GO

USE FRESHDENT /*SE MANDA A LLAMAR PARA GUARDAR LA CODIFICACIÓN QUE TENDRÁ PARA QUE MAS ADELANTE UTILIZARLA PARA GUARDAR INFORMACION POR OTROS MEDIOS PROGRAMATIVOS, EN ESTE CASO EL SISTEMA
				QUE SE CREARÁ EN VISUAL ESTUDIO RELACIONADO A ODONTOLOGIA*/
GO

CREATE TABLE Expediente (																--Creación de la tabla Expediente.
IdExpediente INT PRIMARY KEY IDENTITY (1,1),											--Almacena el código de expediente.
Cedula VARCHAR (100),																	--Almacena la cedula de la persona en el expediente.
Nombres VARCHAR (80),																	--Almacena los nombres de la persona en el expediente.
Apellidos VARCHAR (80),																	--Almacena los apellidos de la persona en el expediente.
Fecha_Nacimiento DATE,																	--Almacena la fecha de nacimiento de la persona en el expediente.
Telefono_Celular INT,																	--Almacena el teléfono-celular de la persona en el expediente.
Municipio VARCHAR (50),																	--Almacena el municipio donde vive la persona en el expediente. 
Departamento VARCHAR (50),																--Almacena el departamento que forma parte el municipio donde vive la persona en el expediente.
CONSTRAINT Expediente_Paciente UNIQUE (Cedula, Fecha_Nacimiento, Telefono_Celular)
);

CREATE TABLE Receta (																	--Creación de la tabla Receta.
IdReceta INT PRIMARY KEY IDENTITY (1,1),												--Almacena código de receta médica.
Nombre VARCHAR (50),																	--Almacena el nombre de lo medicamento.
Presentacion VARCHAR (100),																--Almacena la información del medicamento.
Cantidad INT,																			--Almacena cantidad de medicamentos.
Descripcion VARCHAR (150),																--Almacena la indicación de la toma del medicamento.
CONSTRAINT Receta_Info UNIQUE (Nombre, Cantidad)
);

CREATE TABLE Especialidad (																--Creación de la tabla Especialidad.
IdEspecialidad INT PRIMARY KEY IDENTITY (1,1),											--Almacena código de especialidad.
NombreEspecialidad VARCHAR (50),														--Almacena nombre de especialidad.
DescpEspecialidad VARCHAR (500),														--Almacena descripción de especialidad.
CONSTRAINT Especialista UNIQUE (NombreEspecialidad, DescpEspecialidad)
);

CREATE TABLE Medico (																	--Creación de la tabla Médico
IdMedico INT PRIMARY KEY IDENTITY (1,1),												--Almacena el código del médico.
NombreMedico VARCHAR (30),																--Almacena el nombre del médico.
Telefono_Celular INT,																	--Almacena el numero telefónico personal del médico.
IdEspecialidad INT																		/*Almacena el código de la especialidad.*/
FOREIGN KEY (IdEspecialidad) REFERENCES Especialidad (IdEspecialidad),
CONSTRAINT Medico_Nombre UNIQUE (Telefono_Celular)
);

CREATE TABLE Cita (																		--Creación de la tabla Cita.
IdCita INT PRIMARY KEY IDENTITY (1,1),													--Almacena código de la cita.
FechaCita DATE,																			--Almacena fecha de cita.
HoraDisponible TIME,																	--Almacena hora disponible de la cita.
Precio INT,																				--Almacena costo de la cita.
Tipo VARCHAR (50),																		--Almacena el tipo de cita, es decir si está programada o no.
IdExpediente INT																		/*Almacena el código del expediente.*/
FOREIGN KEY (IdExpediente) REFERENCES Expediente (IdExpediente),
IdMedico INT																			/*Almacena el código del médico.*/
FOREIGN KEY (IdMedico) REFERENCES Medico (IdMedico),
CONSTRAINT Opcion CHECK (Tipo = 'Programada' OR Tipo = 'No programada')
);

CREATE TABLE Consulta (																	--Creación de la tabla Consulta.
IdConsulta INT PRIMARY KEY IDENTITY (1,1),												--Almacena código de consulta.
Fecha DATE,																				--Almacena la fecha que se está realizando la consulta.
Hora TIME,																				--Almacena la hora que se está realizando la consulta.
Sintoma VARCHAR (250),																	--Almacena los síntomas tomada por la persona que está en consulta.
Diagnostico VARCHAR (200),																--Almacena el diagnostico que determina el medico.
IdExpediente INT																		/*Almacena el código del expediente.*/
FOREIGN KEY (IdExpediente) REFERENCES Expediente (IdExpediente),
IdMedico INT																			/*Almacena el código del médico.*/
FOREIGN KEY (IdMedico) REFERENCES Medico (IdMedico),
);

CREATE TABLE Consulta_Receta(
IdConsulta INT																			/*Almacena código de consulta.*/
FOREIGN KEY (IdConsulta) REFERENCES Consulta (IdConsulta),
IdReceta INT																			/*Almacena código de receta médica.*/
FOREIGN KEY (IdReceta) REFERENCES Receta (IdReceta),
);

 ----------------------------------------------------------------PROCEDIMIENTO ALMACENADO------------------------------------------------------------------------------------


 --Se crea el procedimiento almacenado para la tabla Expediente
CREATE PROCEDURE Expedient
	@b INT, @IdExpediente INT, @Cedula VARCHAR (100), @Nombres VARCHAR (80), @Apellidos VARCHAR (80), @Fecha_Nacimiento DATETIME, @Telefono_Celular INT, @Municipio VARCHAR (50), @Departamento VARCHAR (50)
	---------------------------------------------------------------------------Atributos que tiene el procedimiento almacenado------------------------------------------------------------------------------
	
	AS
		BEGIN
			SET NOCOUNT ON;
			
			IF @b=1
				INSERT INTO Expediente VALUES (@Cedula, @Nombres, @Apellidos, @Fecha_Nacimiento, @Telefono_Celular, @Municipio, @Departamento); --Guarda la información insertada.
			IF @b=2
				DELETE FROM Expediente WHERE IdExpediente = @IdExpediente; --Elimina la información guardada utilizando el número que fue asignado de forma automática.
			IF @b=3
				SELECT * FROM Expediente --Muestra toda la información guardada.
			IF @b=4
				UPDATE Expediente SET Cedula=@Cedula, Nombres=@Nombres, Apellidos=@Apellidos, Fecha_Nacimiento=@Fecha_Nacimiento, Telefono_Celular = @Telefono_Celular, Municipio = @Municipio, Departamento = @Departamento WHERE IdExpediente = @IdExpediente; --Actualiza la información seleccionada por el número de registro asignado.
			IF @b=5
				SELECT * FROM Expediente WHERE Cedula LIKE '%' + @Cedula + '%' --Busca la información utilizando un atributo de la entidad, en este caso se utiliza cédula para observar la información de la persona que contenga el número de cédula ingresado.
		END
	GO

--Se crea el procedimiento almacenado para la tabla Especialidad
CREATE PROCEDURE Especialid
	@b INT, @IdEspecialidad INT, @NombreEspecialidad VARCHAR (50), @DescpEspecialidad VARCHAR (500)
	-------------------Atributos que tiene el procedimiento almacenado----------------------------
	
	AS
		BEGIN
			SET NOCOUNT ON;
			
			IF @b=1
				INSERT INTO Especialidad VALUES (@NombreEspecialidad, @DescpEspecialidad); --Guarda la información insertada.
			IF @b=2
				DELETE FROM Especialidad WHERE IdEspecialidad = @IdEspecialidad; --Elimina la información guardada utilizando el número que fue asignado de forma automática.
			IF @b=3
				SELECT * FROM Especialidad --Muestra toda la información guardada.
			IF @b=4
				UPDATE Especialidad SET NombreEspecialidad = @NombreEspecialidad, DescpEspecialidad = @DescpEspecialidad WHERE IdEspecialidad = @IdEspecialidad; --Actualiza la información seleccionada por el número de registro asignado.
			IF @b=5
				SELECT * FROM Especialidad WHERE NombreEspecialidad LIKE '%' + @NombreEspecialidad + '%' --Busca la información utilizando un atributo de la entidad, en este caso se utiliza Nombre Especialidad para observar la información de la especialidad determinada.
		END
	GO

--Se crea el procedimiento almacenado para la tabla Médico
CREATE PROCEDURE Medic
	@b INT, @IdMedico INT, @NombreMedico VARCHAR (30), @Telefono_Celular INT, @IdEspecialidad INT
	-------------------Atributos que tiene el procedimiento almacenado----------------------------
	
	AS
		BEGIN
			SET NOCOUNT ON;
			
			IF @b=1
				INSERT INTO Medico VALUES (@NombreMedico, @Telefono_Celular, @IdEspecialidad); --Guarda la información insertada
			IF @b=2
				DELETE FROM Medico WHERE IdMedico = @IdMedico; --Elimina la información guardada utilizando el número que fue asignado de forma automática.
			IF @b=3
				SELECT * FROM Medico --Muestra toda la información guardada.
			IF @b=4
				UPDATE Medico SET NombreMedico = @NombreMedico, Telefono_Celular = @Telefono_Celular, IdEspecialidad = @IdEspecialidad WHERE IdMedico = @IdMedico; --Actualiza la información seleccionada por el número de registro asignado.
			IF @b=5
				SELECT * FROM Medico WHERE NombreMedico LIKE '%' + @NombreMedico + '%' --Buscar la información utilizando un atributo de la entidad, en este caso se utiliza Nombre Medico para observar la informacion del médico determinado.
		END
	GO

--Se crea el procedimiento almacenado para la tabla Consulta
CREATE PROCEDURE Consul
	@b INT, @IdConsulta INT, @Fecha DATE, @Hora TIME, @Sintoma VARCHAR (250), @Diagnostico VARCHAR (200), @IdExpediente INT, @IdMedico INT
	----------------------------------------Atributos que tiene el procedimiento almacenado-----------------------------------------------
	
	AS
		BEGIN
			SET NOCOUNT ON;

			IF @b=1
				INSERT INTO Consulta VALUES (@Fecha, @Hora, @Sintoma, @Diagnostico, @IdExpediente, @IdMedico); --Guarda la información insertada
			IF @b=2
				DELETE FROM Consulta WHERE IdConsulta = @IdConsulta; --Elimina la información guardada utilizando el número que fue asignado de forma automática.
			IF @b=3
				SELECT * FROM Consulta --Muestra toda la información guardada.
		END 
	GO

--Se crea el procedimiento almacenado para la tabla Receta
CREATE PROCEDURE Recet 
	@b INT, @IdReceta INT, @Nombre VARCHAR (50), @Presentacion VARCHAR (100), @Cantidad INT, @Descripcion VARCHAR (150)
	-------------------------------Atributos que tiene el procedimiento almacenado------------------------------------
	
	AS
		BEGIN
			SET NOCOUNT ON;

			IF @b=1
				INSERT INTO Receta VALUES (@Nombre, @Presentacion, @Cantidad, @Descripcion); --Guarda la información insertada
			IF @b=2
				DELETE FROM Receta WHERE IdReceta = @IdReceta; --Elimina la información guardada utilizando el número que fue asignado de forma automática.
			IF @b=3
				SELECT * FROM Receta --Muestra toda la información guardada.
		END
	GO

--Se crea el procedimiento almacenado para la tabla Cita
CREATE PROCEDURE Cit
	@b INT, @IdCita INT, @FechaCita DATE, @HoraDisponible TIME, @Precio INT, @Tipo VARCHAR (50), @IdExpediente INT, @IdMedico INT
	----------------------------------Atributos que tiene el procedimiento almacenado--------------------------------------------
	
	AS
		BEGIN
			SET NOCOUNT ON;

			IF @b=1
				INSERT INTO Cita VALUES (@FechaCita, @HoraDisponible, @Precio, @Tipo, @IdExpediente, @IdMedico); --Guarda la información insertada
			IF @b=2
				DELETE FROM Cita WHERE IdCita = @IdCita; --Elimina la información guardada utilizando el número que fue asignado de forma automática.
			IF @b=3
				SELECT * FROM Cita --Muestra toda la información guardada.
		END
	GO