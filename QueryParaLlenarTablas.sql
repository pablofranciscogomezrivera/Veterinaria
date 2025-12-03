-- === BLOQUE OPCIONAL: LIMPIEZA DE DATOS (Descomentar si quieres borrar todo antes) ===
/*
DELETE FROM Atenciones;
DELETE FROM Mascotas;
DELETE FROM Owners;
DBCC CHECKIDENT ('Owners', RESEED, 0);
DBCC CHECKIDENT ('Mascotas', RESEED, 0);
DBCC CHECKIDENT ('Atenciones', RESEED, 0);
*/

-- =============================================
-- 1. INSERTAR DUEÑOS (20 Registros)
-- =============================================
INSERT INTO Owners (Cuil, NombreCompleto, Dni, Domicilio, Email, Telefono) VALUES
('20304567891', 'Juan Perez', '30456789', 'Av. San Martín 123', 'juan.perez@email.com', '1155550001'),
('27315678902', 'Maria Gonzalez', '31567890', 'Calle Falsa 123', 'maria.gonz@email.com', '1155550002'),
('20326789013', 'Carlos Lopez', '32678901', 'Rivadavia 456', 'carlos.lopez@email.com', '1155550003'),
('27337890124', 'Ana Martinez', '33789012', 'Belgrano 789', 'ana.martinez@email.com', '1155550004'),
('20348901235', 'Pedro Sanchez', '34890123', 'Mitre 101', 'pedro.sanchez@email.com', '1155550005'),
('27359012346', 'Laura Fernandez', '35901234', 'Sarmiento 202', 'laura.fer@email.com', '1155550006'),
('20360123457', 'Diego Diaz', '36012345', 'Alvear 303', 'diego.diaz@email.com', '1155550007'),
('27371234568', 'Sofia Rodriguez', '37123456', 'Colon 404', 'sofia.rod@email.com', '1155550008'),
('20382345679', 'Miguel Angel Torres', '38234567', 'Pueyrredon 505', 'miguel.torres@email.com', '1155550009'),
('27393456780', 'Lucia Gomez', '39345678', 'Lavalle 606', 'lucia.gomez@email.com', '1155550010'),
('20404567891', 'Fernando Ruiz', '40456789', 'Moreno 707', 'fernando.ruiz@email.com', '1155550011'),
('27415678902', 'Valentina Castro', '41567890', 'Saavedra 808', 'valen.castro@email.com', '1155550012'),
('20426789013', 'Gabriel Morales', '42678901', 'Urquiza 909', 'gaby.morales@email.com', '1155550013'),
('27437890124', 'Martina Silva', '43789012', 'Castelli 1001', 'martina.silva@email.com', '1155550014'),
('20448901235', 'Lucas Nuñez', '44890123', 'Güemes 1102', 'lucas.nunez@email.com', '1155550015'),
('27459012346', 'Camila Bravo', '45901234', 'Laprida 1203', 'camila.bravo@email.com', '1155550016'),
('20460123457', 'Matias Herrera', '46012345', 'Paz 1304', 'matias.herrera@email.com', '1155550017'),
('27471234568', 'Florencia Acosta', '47123456', 'Libertad 1405', 'flor.acosta@email.com', '1155550018'),
('20482345679', 'Javier Rojas', '48234567', 'Independencia 1506', 'javier.rojas@email.com', '1155550019'),
('27493456780', 'Agustina Medina', '49345678', 'San Lorenzo 1607', 'agus.medina@email.com', '1155550020');

-- =============================================
-- 2. INSERTAR MASCOTAS (Vinculadas por IdOwner 1 al 20)
-- =============================================
INSERT INTO Mascotas (Nombre, Especie, Raza, FechaNacimiento, IdOwner) VALUES
-- Dueño 1 (Juan) tiene 2 mascotas
('Firulais', 'Perro', 'Mestizo', '2020-01-15', 1),
('Michi', 'Gato', 'Siamés', '2019-05-20', 1),
-- Dueño 2 (Maria)
('Luna', 'Perro', 'Golden Retriever', '2021-03-10', 2),
-- Dueño 3 (Carlos)
('Thor', 'Perro', 'Bulldog Francés', '2018-11-05', 3),
-- Dueño 4 (Ana) tiene 2 mascotas (Gatos)
('Pelusa', 'Gato', 'Persa', '2022-01-01', 4),
('Garfield', 'Gato', 'Mestizo', '2020-07-22', 4),
-- Dueño 5 (Pedro)
('Rocky', 'Perro', 'Boxer', '2017-09-12', 5),
-- Dueño 6 (Laura) - Mascota exótica
('Nemo', 'Otro', 'Pez Dorado', '2023-01-01', 6),
-- Dueño 7 (Diego)
('Lola', 'Perro', 'Caniche Toy', '2019-12-24', 7),
-- Dueño 8 (Sofia) tiene 3 mascotas
('Simba', 'Gato', 'Común Europeo', '2021-06-15', 8),
('Nala', 'Gato', 'Común Europeo', '2021-06-15', 8),
('Rex', 'Perro', 'Ovejero Alemán', '2016-04-20', 8),
-- Dueños 9 a 15 (Una mascota c/u)
('Coco', 'Perro', 'Labrador', '2020-02-14', 9),
('Princesa', 'Perro', 'Chihuahua', '2021-08-30', 10),
('Max', 'Perro', 'Beagle', '2019-10-10', 11),
('Pepe', 'Ave', 'Loro', '2015-05-05', 12),
('Toby', 'Perro', 'Mestizo', '2018-01-20', 13),
('Bella', 'Perro', 'Border Collie', '2022-03-15', 14),
('Milo', 'Gato', 'Angora', '2020-11-11', 15),
-- Dueño 16 (Camila) tiene 2 mascotas
('Kiara', 'Perro', 'Pitbull', '2019-07-07', 16),
('Zeus', 'Perro', 'Doberman', '2021-02-28', 16),
-- Dueños 17 a 20
('Oreo', 'Gato', 'Mestizo', '2022-05-05', 17),
('Boby', 'Perro', 'Salchicha', '2018-09-18', 18),
('Copito', 'Conejo', 'Cabeza de León', '2023-02-10', 19),
('Daisy', 'Perro', 'Cocker Spaniel', '2020-12-01', 20);

-- =============================================
-- 3. INSERTAR ATENCIONES (Vinculadas por IdMascota 1 al 25)
-- =============================================
INSERT INTO Atenciones (FechaAtencion, TipoServicio, Monto, Observaciones, IdMascota) VALUES
-- Atenciones para Firulais (Id 1)
('2024-01-10 09:30:00', 'Consulta', 5000.00, 'Control anual general', 1),
('2024-01-10 10:00:00', 'Vacunación', 8000.00, 'Vacuna Quintuple aplicada', 1),
('2024-03-15 11:00:00', 'Baño', 4500.00, 'Baño y corte de uñas', 1),

-- Atenciones para Michi (Id 2)
('2024-02-01 15:00:00', 'Consulta', 5000.00, 'Decaimiento y falta de apetito', 2),
('2024-02-05 16:30:00', 'Análisis', 12000.00, 'Análisis de sangre completo', 2),

-- Atenciones para Luna (Id 3)
('2024-01-20 09:00:00', 'Vacunación', 8000.00, 'Antirrábica', 3),

-- Atenciones para Thor (Id 4) - Cirugía
('2023-12-10 08:00:00', 'Consulta', 5000.00, 'Problema respiratorio', 4),
('2023-12-15 08:00:00', 'Cirugía', 45000.00, 'Cirugía de paladar blando', 4),
('2024-01-05 10:00:00', 'Consulta', 3000.00, 'Control post-quirúrgico', 4),

-- Atenciones para Pelusa (Id 5)
('2024-03-01 17:00:00', 'Peluquería', 6000.00, 'Corte higiénico', 5),

-- Atenciones para Garfield (Id 6)
('2024-02-14 10:00:00', 'Desparasitación', 4000.00, 'Pipeta externa e interna', 6),

-- Atenciones para Rocky (Id 7)
('2024-01-08 14:00:00', 'Radiografía', 15000.00, 'Pata delantera derecha golpeada', 7),

-- Sin atenciones para Nemo (Id 8)

-- Atenciones para Lola (Id 9)
('2024-04-01 09:30:00', 'Consulta', 5000.00, 'Alergia en la piel', 9),

-- Atenciones para Simba, Nala y Rex (Dueño 8 - Ids 10, 11, 12)
('2024-01-15 10:00:00', 'Vacunación', 8000.00, 'Triple felina', 10),
('2024-01-15 10:15:00', 'Vacunación', 8000.00, 'Triple felina', 11),
('2024-02-20 11:00:00', 'Ecografía', 18000.00, 'Control abdominal', 12),

-- Varias atenciones dispersas
('2024-03-10 16:00:00', 'Consulta', 5000.00, 'Chequeo general', 13), -- Coco
('2024-03-12 09:00:00', 'Peluquería', 5500.00, NULL, 14), -- Princesa
('2024-03-14 18:00:00', 'Consulta', 5000.00, 'Otitis', 15), -- Max
('2024-01-30 10:30:00', 'Otro', 2500.00, 'Corte de pico y uñas', 16), -- Pepe (Loro)
('2024-04-05 12:00:00', 'Vacunación', 8000.00, 'Sextuple', 17), -- Toby
('2024-02-28 15:45:00', 'Desparasitación', 3500.00, NULL, 18), -- Bella
('2024-03-22 14:20:00', 'Baño', 4000.00, NULL, 19), -- Milo
('2024-01-18 11:15:00', 'Consulta', 5000.00, 'Cojera leve', 20), -- Kiara
('2024-02-11 09:00:00', 'Urgencia', 15000.00, 'Ingestión de cuerpo extraño', 21), -- Zeus
('2024-03-05 17:30:00', 'Consulta', 5000.00, 'Control peso', 22), -- Oreo
('2024-04-02 10:00:00', 'Vacunación', 8000.00, 'Antirrábica', 23), -- Boby
('2024-01-25 13:00:00', 'Consulta', 4500.00, 'Dientes largos', 24), -- Copito
('2024-03-30 16:00:00', 'Peluquería', 7000.00, 'Corte de raza completo', 25); -- Daisy