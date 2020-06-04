											
											--GESTOR DE BASE DATOS = SQL SERVER 2014 MANAGEMENT STUDIO--

CREATE DATABASE FRESHDENT /*SE CREA LA BASE DE DATOS APLICANDO NOMBRE A ELLA*/
GO

USE FRESHDENT /*SE MANDA A LLAMAR PARA GUARDAR LA CODIFICACI�N QUE TENDR� PARA QUE MAS ADELANTE UTILIZARLA PARA GUARDAR INFORMACION POR OTROS MEDIOS PROGRAMATIVOS, EN ESTE CASO EL SISTEMA
				QUE SE CREAR� EN VISUAL ESTUDIO RELACIONADO A ODONTOLOGIA*/
GO

CREATE TABLE Expediente (																--Creaci�n de la tabla Expediente.
IdExpediente INT PRIMARY KEY IDENTITY (1,1),											--Almacena el c�digo de expediente.
Cedula VARCHAR (100),																	--Almacena la cedula de la persona en el expediente.
Nombres VARCHAR (80),																	--Almacena los nombres de la persona en el expediente.
Apellidos VARCHAR (80),																	--Almacena los apellidos de la persona en el expediente.
Fecha_Nacimiento DATE,																	--Almacena la fecha de nacimiento de la persona en el expediente.
Telefono_Celular INT,																	--Almacena el tel�fono-celular de la persona en el expediente.
Municipio VARCHAR (50),																	--Almacena el municipio donde vive la persona en el expediente. 
Departamento VARCHAR (50),																--Almacena el departamento que forma parte el municipio donde vive la persona en el expediente.
CONSTRAINT Expediente_Paciente UNIQUE (Cedula, Fecha_Nacimiento, Telefono_Celular)
);

CREATE TABLE Receta (																	--Creaci�n de la tabla Receta.
IdReceta INT PRIMARY KEY IDENTITY (1,1),												--Almacena c�digo de receta m�dica.
Nombre VARCHAR (50),																	--Almacena el nombre de lo medicamento.
Presentacion VARCHAR (100),																--Almacena la informaci�n del medicamento.
Cantidad INT,																			--Almacena cantidad de medicamentos.
Descripcion VARCHAR (150),																--Almacena la indicaci�n de la toma del medicamento.
CONSTRAINT Receta_Info UNIQUE (Nombre, Cantidad)
);

CREATE TABLE Especialidad (																--Creaci�n de la tabla Especialidad.
IdEspecialidad INT PRIMARY KEY IDENTITY (1,1),											--Almacena c�digo de especialidad.
NombreEspecialidad VARCHAR (50),														--Almacena nombre de especialidad.
DescpEspecialidad VARCHAR (500),														--Almacena descripci�n de especialidad.
CONSTRAINT Especialista UNIQUE (NombreEspecialidad, DescpEspecialidad)
);

CREATE TABLE Medico (																	--Creaci�n de la tabla M�dico
IdMedico INT PRIMARY KEY IDENTITY (1,1),												--Almacena el c�digo del m�dico.
NombreMedico VARCHAR (30),																--Almacena el nombre del m�dico.
Telefono_Celular INT,																	--Almacena el numero telef�nico personal del m�dico.
IdEspecialidad INT																		/*Almacena el c�digo de la especialidad.*/
FOREIGN KEY (IdEspecialidad) REFERENCES Especialidad (IdEspecialidad),
CONSTRAINT Medico_Nombre UNIQUE (Telefono_Celular)
);

CREATE TABLE Cita (																		--Creaci�n de la tabla Cita.
IdCita INT PRIMARY KEY IDENTITY (1,1),													--Almacena c�digo de la cita.
FechaCita DATE,																			--Almacena fecha de cita.
HoraDisponible TIME,																	--Almacena hora disponible de la cita.
Precio INT,																				--Almacena costo de la cita.
Tipo VARCHAR (50),																		--Almacena el tipo de cita, es decir si est� programada o no.
IdExpediente INT																		/*Almacena el c�digo del expediente.*/
FOREIGN KEY (IdExpediente) REFERENCES Expediente (IdExpediente),
IdMedico INT																			/*Almacena el c�digo del m�dico.*/
FOREIGN KEY (IdMedico) REFERENCES Medico (IdMedico),
CONSTRAINT Opcion CHECK (Tipo = 'Programada' OR Tipo = 'No programada')
);

CREATE TABLE Consulta (																	--Creaci�n de la tabla Consulta.
IdConsulta INT PRIMARY KEY IDENTITY (1,1),												--Almacena c�digo de consulta.
Fecha DATE,																				--Almacena la fecha que se est� realizando la consulta.
Hora TIME,																				--Almacena la hora que se est� realizando la consulta.
Sintoma VARCHAR (250),																	--Almacena los s�ntomas tomada por la persona que est� en consulta.
Diagnostico VARCHAR (200),																--Almacena el diagnostico que determina el medico.
IdExpediente INT																		/*Almacena el c�digo del expediente.*/
FOREIGN KEY (IdExpediente) REFERENCES Expediente (IdExpediente),
IdMedico INT																			/*Almacena el c�digo del m�dico.*/
FOREIGN KEY (IdMedico) REFERENCES Medico (IdMedico),
);

CREATE TABLE Consulta_Receta(
IdConsulta INT																			/*Almacena c�digo de consulta.*/
FOREIGN KEY (IdConsulta) REFERENCES Consulta (IdConsulta),
IdReceta INT																			/*Almacena c�digo de receta m�dica.*/
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
				INSERT INTO Expediente VALUES (@Cedula, @Nombres, @Apellidos, @Fecha_Nacimiento, @Telefono_Celular, @Municipio, @Departamento); --Guarda la informaci�n insertada.
			IF @b=2
				DELETE FROM Expediente WHERE IdExpediente = @IdExpediente; --Elimina la informaci�n guardada utilizando el n�mero que fue asignado de forma autom�tica.
			IF @b=3
				SELECT * FROM Expediente --Muestra toda la informaci�n guardada.
			IF @b=4
				UPDATE Expediente SET Cedula=@Cedula, Nombres=@Nombres, Apellidos=@Apellidos, Fecha_Nacimiento=@Fecha_Nacimiento, Telefono_Celular = @Telefono_Celular, Municipio = @Municipio, Departamento = @Departamento WHERE IdExpediente = @IdExpediente; --Actualiza la informaci�n seleccionada por el n�mero de registro asignado.
			IF @b=5
				SELECT * FROM Expediente WHERE Cedula LIKE '%' + @Cedula + '%' --Busca la informaci�n utilizando un atributo de la entidad, en este caso se utiliza c�dula para observar la informaci�n de la persona que contenga el n�mero de c�dula ingresado.
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
				INSERT INTO Especialidad VALUES (@NombreEspecialidad, @DescpEspecialidad); --Guarda la informaci�n insertada.
			IF @b=2
				DELETE FROM Especialidad WHERE IdEspecialidad = @IdEspecialidad; --Elimina la informaci�n guardada utilizando el n�mero que fue asignado de forma autom�tica.
			IF @b=3
				SELECT * FROM Especialidad --Muestra toda la informaci�n guardada.
			IF @b=4
				UPDATE Especialidad SET NombreEspecialidad = @NombreEspecialidad, DescpEspecialidad = @DescpEspecialidad WHERE IdEspecialidad = @IdEspecialidad; --Actualiza la informaci�n seleccionada por el n�mero de registro asignado.
			IF @b=5
				SELECT * FROM Especialidad WHERE NombreEspecialidad LIKE '%' + @NombreEspecialidad + '%' --Busca la informaci�n utilizando un atributo de la entidad, en este caso se utiliza Nombre Especialidad para observar la informaci�n de la especialidad determinada.
		END
	GO

--Se crea el procedimiento almacenado para la tabla M�dico
CREATE PROCEDURE Medic
	@b INT, @IdMedico INT, @NombreMedico VARCHAR (30), @Telefono_Celular INT, @IdEspecialidad INT
	-------------------Atributos que tiene el procedimiento almacenado----------------------------
	
	AS
		BEGIN
			SET NOCOUNT ON;
			
			IF @b=1
				INSERT INTO Medico VALUES (@NombreMedico, @Telefono_Celular, @IdEspecialidad); --Guarda la informaci�n insertada
			IF @b=2
				DELETE FROM Medico WHERE IdMedico = @IdMedico; --Elimina la informaci�n guardada utilizando el n�mero que fue asignado de forma autom�tica.
			IF @b=3
				SELECT * FROM Medico --Muestra toda la informaci�n guardada.
			IF @b=4
				UPDATE Medico SET NombreMedico = @NombreMedico, Telefono_Celular = @Telefono_Celular, IdEspecialidad = @IdEspecialidad WHERE IdMedico = @IdMedico; --Actualiza la informaci�n seleccionada por el n�mero de registro asignado.
			IF @b=5
				SELECT * FROM Medico WHERE NombreMedico LIKE '%' + @NombreMedico + '%' --Buscar la informaci�n utilizando un atributo de la entidad, en este caso se utiliza Nombre Medico para observar la informacion del m�dico determinado.
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
				INSERT INTO Consulta VALUES (@Fecha, @Hora, @Sintoma, @Diagnostico, @IdExpediente, @IdMedico); --Guarda la informaci�n insertada
			IF @b=2
				DELETE FROM Consulta WHERE IdConsulta = @IdConsulta; --Elimina la informaci�n guardada utilizando el n�mero que fue asignado de forma autom�tica.
			IF @b=3
				SELECT * FROM Consulta --Muestra toda la informaci�n guardada.
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
				INSERT INTO Receta VALUES (@Nombre, @Presentacion, @Cantidad, @Descripcion); --Guarda la informaci�n insertada
			IF @b=2
				DELETE FROM Receta WHERE IdReceta = @IdReceta; --Elimina la informaci�n guardada utilizando el n�mero que fue asignado de forma autom�tica.
			IF @b=3
				SELECT * FROM Receta --Muestra toda la informaci�n guardada.
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
				INSERT INTO Cita VALUES (@FechaCita, @HoraDisponible, @Precio, @Tipo, @IdExpediente, @IdMedico); --Guarda la informaci�n insertada
			IF @b=2
				DELETE FROM Cita WHERE IdCita = @IdCita; --Elimina la informaci�n guardada utilizando el n�mero que fue asignado de forma autom�tica.
			IF @b=3
				SELECT * FROM Cita --Muestra toda la informaci�n guardada.
		END
	GO