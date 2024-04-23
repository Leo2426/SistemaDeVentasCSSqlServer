--selecciona distritos por provincia
-- 
CREATE PROCEDURE spGetDistrictsByProvinceName 
	@ProvinceName varchar(45)
	AS
	BEGIN
	SELECT p.id, p.name, d.id AS districts_id
		FROM provinces p  
		JOIN districts d ON p.districts_id = d.id   
		WHERE p.name = @ProvinceName;
	END;
	go

	-- pero sin procedimiento almacenado solo como queery quiero los distritos por provincia
	-- quiero los distritos 
		 SELECT d.id, d.name, p.id, p.departments_id FROM districts d 
				JOIN provinces p  
				ON d.provinces_id = p.id 
				WHERE p.name = 'Prov. Const. del Callao';
				go

				select * from provinces;
				go

CREATE PROCEDURE spGetDistrictsByProvinceName
    @ProvinceName varchar(100)
AS
BEGIN
    SELECT d.id, d.name, p.id AS province_id, p.departments_id
    FROM districts d 
    JOIN provinces p ON d.provinces_id = p.id 
    WHERE p.name = @ProvinceName;
END;
GO

-- Para ejecutar el Stored Procedure y obtener los distritos por el nombre de la provincia:
EXEC spGetDistrictsByProvinceName @ProvinceName = 'Prov. Const. del Callao';
GO