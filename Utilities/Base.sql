

-- Tabla especialidades
create table Especialidades(
    Id int not null auto_increment,
    Nombre varchar(125),
    Descripcion text,
    Estado enum ('Activo', 'Inactivo', 'Eliminado'),
    PRIMARY KEY(Id)
);

-- Insertamos datos especialidades
INSERT INTO Especialidades (Nombre, Descripcion, Estado) VALUES 
('Cardiología', 'Especialidad médica que se encarga del diagnóstico y tratamiento de las enfermedades del corazón.', 'Activo'),
('Dermatología', 'Especialidad médica que se ocupa del conocimiento y estudio de la piel humana y de las enfermedades que la afectan.', 'Activo'),
('Endocrinología', 'Rama de la medicina que se ocupa del estudio del sistema endocrino y sus enfermedades.', 'Activo'),
('Gastroenterología', 'Rama de la medicina dedicada al estudio del sistema digestivo y sus trastornos.', 'Activo'),
('Neurología', 'Especialidad médica que trata los trastornos del sistema nervioso.', 'Activo'),
('Pediatría', 'Rama de la medicina que se ocupa del cuidado y tratamiento de las enfermedades de los niños.', 'Activo'),
('Psiquiatría', 'Especialidad médica que se ocupa del estudio y tratamiento de las enfermedades mentales.', 'Activo'),
('Oftalmología', 'Especialidad médica que estudia las enfermedades de los ojos.', 'Activo'),
('Ortopedia', 'Rama de la medicina que se ocupa de las deformidades y enfermedades del aparato locomotor.', 'Activo'),
('Oncología', 'Rama de la medicina que estudia y trata el cáncer.', 'Activo');


-- Tabla Medicos
create table Medicos(
    Id int not null auto_increment,
    NombreCompleto varchar(125),
    EspecialidadId int,
    Foreign Key (EspecialidadId) REFERENCES Especialidades(Id),
    Correo varchar(125) UNIQUE,
    Telefono varchar(75),
    Estado enum ('Activo', 'Inactivo', 'Eliminado'),
    PRIMARY KEY(Id)
);

-- Insertamos datos medicos
INSERT INTO Medicos (NombreCompleto, EspecialidadId, Correo, Telefono, Estado) VALUES 
('Dr. Juan Pérez', 1, 'juan.perez@correo.com', '555-1234', 'Activo'),
('Dra. María Gómez', 2, 'maria.gomez@correo.com', '555-5678', 'Activo'),
('Dr. Carlos Ramírez', 3, 'carlos.ramirez@correo.com', '555-9101', 'Activo'),
('Dra. Ana Fernández', 4, 'ana.fernandez@correo.com', '555-1122', 'Activo'),
('Dr. Pedro Martínez', 5, 'pedro.martinez@correo.com', '555-3344', 'Activo'),
('Dra. Laura Sánchez', 6, 'laura.sanchez@correo.com', '555-5566', 'Activo'),
('Dr. Andrés López', 7, 'andres.lopez@correo.com', '555-7788', 'Activo'),
('Dra. Carmen Díaz', 8, 'carmen.diaz@correo.com', '555-9900', 'Activo'),
('Dr. Jorge Torres', 9, 'jorge.torres@correo.com', '555-1111', 'Activo'),
('Dra. Sofía Morales', 10, 'sofia.morales@correo.com', '555-2222', 'Activo');


-- Tabla Citas
create table Citas(
    Id int not null auto_increment,
    MedicoId int,
    Foreign Key (MedicoId) REFERENCES Medicos(Id),
    PacienteId int,
    Foreign Key (PacienteId) REFERENCES Pacientes(Id),
    Fecha date,
    Estado enum ('Activo', 'Inactivo', 'Eliminado'),
    PRIMARY KEY(Id)
);

-- Insertamos datos citas
INSERT INTO Citas (MedicoId, PacienteId, Fecha, Estado) VALUES 
(1, 1, '2023-01-15', 'Activo'),
(2, 2, '2023-02-20', 'Activo'),
(3, 3, '2023-03-25', 'Activo'),
(4, 4, '2023-04-30', 'Activo'),
(5, 5, '2023-05-05', 'Activo'),
(6, 6, '2023-06-10', 'Activo'),
(7, 7, '2023-07-15', 'Activo'),
(8, 8, '2023-08-20', 'Activo'),
(9, 9, '2023-09-25', 'Activo'),
(10, 10, '2023-10-30', 'Activo');


--Tabla Pacientes 
create table Pacientes(
    Id int not null auto_increment,
    Nombres varchar(125),
    Apellidos varchar(125),
    FechaNacimiento date,
    Correo varchar(125) UNIQUE,
    Telefono varchar(75),
    Direccion varchar(125),
    Estado enum ('Activo', 'Inactivo', 'Eliminado'),
    PRIMARY KEY(Id)
);

-- Insertamos datos pacientes
INSERT INTO Pacientes (Nombres, Apellidos, FechaNacimiento, Correo, Telefono, Direccion, Estado) VALUES 
('Carlos', 'García', '1985-02-15', 'carlos.garcia@correo.com', '555-3333', 'Calle Falsa 123', 'Activo'),
('Laura', 'Hernández', '1990-07-22', 'laura.hernandez@correo.com', '555-4444', 'Avenida Siempre Viva 456', 'Activo'),
('Pedro', 'López', '1975-03-30', 'pedro.lopez@correo.com', '555-5555', 'Calle 7 #89-45', 'Activo'),
('Ana', 'Martínez', '2000-11-12', 'ana.martinez@correo.com', '555-6666', 'Carrera 9 #12-34', 'Activo'),
('Luis', 'Rodríguez', '1988-09-05', 'luis.rodriguez@correo.com', '555-7777', 'Calle 4 #56-78', 'Activo'),
('Marta', 'Gómez', '1995-06-25', 'marta.gomez@correo.com', '555-8888', 'Calle 3 #45-67', 'Activo'),
('Jorge', 'Díaz', '1982-01-17', 'jorge.diaz@correo.com', '555-9999', 'Avenida 1 #23-45', 'Activo'),
('Elena', 'Vargas', '1993-12-08', 'elena.vargas@correo.com', '555-1010', 'Calle 5 #67-89', 'Activo'),
('Andrés', 'Torres', '1978-05-21', 'andres.torres@correo.com', '555-1112', 'Carrera 6 #12-34', 'Activo'),
('Carmen', 'Sánchez', '2001-10-14', 'carmen.sanchez@correo.com', '555-1213', 'Calle 8 #89-12', 'Activo');


-- Tabla Tratamientos
create table Tratamientos(
    Id int not null auto_increment,
    CitaID int,
    Foreign Key (CitaID) REFERENCES Citas(Id),
    Descripcion text,
    Estado enum ('Activo', 'Inactivo', 'Eliminado'),
    PRIMARY KEY(Id)
);

-- Insertamos datos tratamientos
INSERT INTO Tratamientos (CitaID, Descripcion, Estado) VALUES 
(1, 'Tratamiento para la hipertensión', 'Activo'),
(2, 'Tratamiento para el acné severo', 'Activo'),
(3, 'Tratamiento para la diabetes tipo 2', 'Activo'),
(4, 'Tratamiento para la gastritis crónica', 'Activo'),
(5, 'Tratamiento para la migraña', 'Activo'),
(6, 'Tratamiento preventivo infantil', 'Activo'),
(7, 'Tratamiento para la depresión', 'Activo'),
(8, 'Tratamiento para el glaucoma', 'Activo'),
(9, 'Tratamiento para fractura de pierna', 'Activo'),
(10, 'Tratamiento para el cáncer de mama', 'Activo');

select * from `Citas`;
select * from `Pacientes`;
select * from `Tratamientos`;
select * from `Medicos`;
select * from `Especialidades`;

drop table Especialidades;
