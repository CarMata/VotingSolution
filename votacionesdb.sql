USE [votacionesdb]
GO
/****** Object:  Table [dbo].[candidato]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[candidato](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[id_municipio] [bigint] NOT NULL,
	[id_partido] [bigint] NOT NULL,
	[id_tipo_eleccion] [bigint] NOT NULL,
	[foto] [image] NOT NULL,
 CONSTRAINT [PK__candidat__3213E83F10AA17E0] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[departamento]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[departamento](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[municipio]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[municipio](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[id_departamento] [bigint] NOT NULL,
 CONSTRAINT [PK__municipi__3213E83F199D0D50] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[partido]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[partido](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[foto] [image] NULL,
 CONSTRAINT [PK__partido__3213E83F2517DC8E] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[registro_nacional]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[registro_nacional](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[primer_apellido] [varchar](50) NOT NULL,
	[segundo_apellido] [varchar](50) NOT NULL,
	[fecha_nacimiento] [datetime] NULL,
	[numero_dui] [varchar](15) NOT NULL,
	[genero] [varchar](10) NOT NULL,
	[ocupacion] [varchar](50) NOT NULL,
	[nacionalidad] [varchar](20) NOT NULL,
	[direccion] [varchar](200) NOT NULL,
	[foto] [image] NULL,
	[id_municipio] [bigint] NOT NULL,
 CONSTRAINT [PK__registro__3213E83F567D566C] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_eleccion]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_eleccion](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NULL,
	[pass] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[correo] [varchar](50) NULL,
	[id_registro_nacional] [bigint] NULL,
	[id_role] [bigint] NULL,
 CONSTRAINT [PK__usuarios__3213E83F20C1FCA9] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[votos]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[votos](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[id_candidato] [bigint] NOT NULL,
	[id_usuario] [bigint] NOT NULL,
	[voto_nulo] [bit] NOT NULL,
 CONSTRAINT [PK__votos__3213E83F8D6B45F6] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[candidato]  WITH CHECK ADD  CONSTRAINT [FK_candidato_municipio] FOREIGN KEY([id_municipio])
REFERENCES [dbo].[municipio] ([id])
GO
ALTER TABLE [dbo].[candidato] CHECK CONSTRAINT [FK_candidato_municipio]
GO
ALTER TABLE [dbo].[candidato]  WITH CHECK ADD  CONSTRAINT [FK_candidato_partido] FOREIGN KEY([id_partido])
REFERENCES [dbo].[partido] ([id])
GO
ALTER TABLE [dbo].[candidato] CHECK CONSTRAINT [FK_candidato_partido]
GO
ALTER TABLE [dbo].[candidato]  WITH CHECK ADD  CONSTRAINT [FK_candidato_tipo_eleccion] FOREIGN KEY([id_tipo_eleccion])
REFERENCES [dbo].[tipo_eleccion] ([id])
GO
ALTER TABLE [dbo].[candidato] CHECK CONSTRAINT [FK_candidato_tipo_eleccion]
GO
ALTER TABLE [dbo].[municipio]  WITH CHECK ADD  CONSTRAINT [FK_municipio_departamento] FOREIGN KEY([id_departamento])
REFERENCES [dbo].[departamento] ([id])
GO
ALTER TABLE [dbo].[municipio] CHECK CONSTRAINT [FK_municipio_departamento]
GO
ALTER TABLE [dbo].[registro_nacional]  WITH CHECK ADD  CONSTRAINT [FK_registro_nacional_municipio] FOREIGN KEY([id_municipio])
REFERENCES [dbo].[municipio] ([id])
GO
ALTER TABLE [dbo].[registro_nacional] CHECK CONSTRAINT [FK_registro_nacional_municipio]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_registro_nacional] FOREIGN KEY([id_registro_nacional])
REFERENCES [dbo].[registro_nacional] ([id])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_registro_nacional]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_roles] FOREIGN KEY([id_role])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_roles]
GO
ALTER TABLE [dbo].[votos]  WITH CHECK ADD  CONSTRAINT [FK_votos_candidato] FOREIGN KEY([id_candidato])
REFERENCES [dbo].[candidato] ([id])
GO
ALTER TABLE [dbo].[votos] CHECK CONSTRAINT [FK_votos_candidato]
GO
ALTER TABLE [dbo].[votos]  WITH CHECK ADD  CONSTRAINT [FK_votos_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuarios] ([id])
GO
ALTER TABLE [dbo].[votos] CHECK CONSTRAINT [FK_votos_usuarios]
GO
/****** Object:  StoredProcedure [dbo].[delete_Departamento]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_Departamento]
   @Id bigint
AS
BEGIN
Delete from votacionesdb.dbo.departamento
where id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[delete_Municipio]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_Municipio]
   @Id bigint
AS
BEGIN
Delete from votacionesdb.dbo.municipio
where id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[delete_Partido]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_Partido]
	 @id bigint
     
   
AS
BEGIN
DELETE
FROM partido 
WHERE  id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[delete_registroNacional]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_registroNacional]
	 @id bigint
     
   
AS
BEGIN
DELETE
FROM registro_nacional 
WHERE  id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[delete_TipoEleccion]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_TipoEleccion]
   @Id bigint
AS
BEGIN
Delete from votacionesdb.dbo.tipo_eleccion
where id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[delete_User]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_User]
	 @id bigint
   
AS
BEGIN
DELETE from votacionesdb.dbo.usuarios
where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[get_DepartamentoById]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_DepartamentoById]
     @id bigint
   
AS
BEGIN
Select * from votacionesdb.dbo.departamento
where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[get_Departamentos]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_Departamentos]
   
AS
BEGIN
Select * from votacionesdb.dbo.departamento
END
GO
/****** Object:  StoredProcedure [dbo].[get_MunicipioById]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_MunicipioById]
   @Id bigint
AS
BEGIN
select * from votacionesdb.dbo.municipio
where id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[get_Municipios]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_Municipios]
AS
BEGIN
select * from votacionesdb.dbo.municipio
END
GO
/****** Object:  StoredProcedure [dbo].[get_Partidos]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_Partidos]
   
AS
BEGIN
Select * from votacionesdb.dbo.partido
END
GO
/****** Object:  StoredProcedure [dbo].[get_PartidosByID]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_PartidosByID]
     @id bigint
   
AS
BEGIN
Select * from votacionesdb.dbo.partido
where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[get_registroNacional]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_registroNacional]
	 @id bigint
     
   
AS
BEGIN
SELECT *

FROM registro_nacional 
WHERE  id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[get_registros]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_registros]
AS
BEGIN
SELECT *

FROM registro_nacional 
END
GO
/****** Object:  StoredProcedure [dbo].[get_TipoEleccion]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_TipoEleccion]
   
AS
BEGIN
Select * from votacionesdb.dbo.tipo_eleccion
END
GO
/****** Object:  StoredProcedure [dbo].[get_TipoEleccionById]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_TipoEleccionById]
     @id bigint
   
AS
BEGIN
Select * from votacionesdb.dbo.tipo_eleccion
where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[get_UserById]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_UserById]
	 @id bigint
   
AS
BEGIN
Select * from votacionesdb.dbo.usuarios
where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[get_Users]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_Users]
   
AS
BEGIN
Select * from votacionesdb.dbo.usuarios
END
GO
/****** Object:  StoredProcedure [dbo].[get_usuarios]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[get_usuarios] as
begin
select * from usuarios;
end
GO
/****** Object:  StoredProcedure [dbo].[insert_usuario]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insert_usuario](
           @usuario varchar(50),
           @password varchar(50),
           @fecha_creacion datetime,
           @correo varchar(50),
           @id_registro_nacional bigint,
           @id_role bigint)
as
begin
insert into usuarios
      ([usuario]
           ,[pass]
           ,[fecha_creacion]
           ,[correo]
           ,[id_registro_nacional]
           ,[id_role])
       values(
       @usuario,
       @password,
           @fecha_creacion,
           @correo,
           @id_registro_nacional,
           @id_role)
end
GO
/****** Object:  StoredProcedure [dbo].[save_Departamento]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[save_Departamento]
	 @nombre varchar(50)
   
AS
BEGIN
INSERT INTO votacionesdb.dbo.departamento(
     nombre)
    VALUES (
     @nombre)
END
GO
/****** Object:  StoredProcedure [dbo].[save_Municipio]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[save_Municipio]
	 @nombre varchar(50),
	 @id_departamento bigint
   
AS
BEGIN
INSERT INTO votacionesdb.dbo.municipio(
     nombre,
	 id_departamento)
    VALUES (
     @nombre,
     @id_departamento)
END
GO
/****** Object:  StoredProcedure [dbo].[save_Partido]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[save_Partido]
	 @nombre varchar(50),
	 @foto image
   
AS
BEGIN
INSERT INTO votacionesdb.dbo.partido(
     nombre,
	 foto)
    VALUES (
     @nombre,
	 @foto)
END
GO
/****** Object:  StoredProcedure [dbo].[save_registroNacional]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[save_registroNacional]
	 @nombre varchar(50),
     @primer_apellido varchar(50),
     @segundo_apellido varchar(50),
	 @fecha_nacimiento datetime,
	 @numero_dui varchar(15),
	 @genero varchar(10),
	 @ocupacion varchar(50),
	 @nacionalidad varchar(20),
	 @direccion varchar(200),
	 @foto image,
	 @id_municipio bigint
   
AS
BEGIN
INSERT INTO votacionesdb.dbo.registro_nacional(
     nombre,
     primer_apellido,
     segundo_apellido,
	 fecha_nacimiento,
	 numero_dui,
	 genero,
	 ocupacion,
	 nacionalidad,
	 direccion,
	 foto,
	 id_municipio)
    VALUES (
     @nombre,
     @primer_apellido,
     @segundo_apellido,
	 @fecha_nacimiento,
	 @numero_dui,
	 @genero,
	 @ocupacion,
	 @nacionalidad,
	 @direccion,
	 @foto,
	 @id_municipio)
END

GO
/****** Object:  StoredProcedure [dbo].[save_TipoEleccion]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[save_TipoEleccion]
	 @nombre varchar(50)
   
AS
BEGIN
INSERT INTO votacionesdb.dbo.tipo_eleccion(
     nombre)
    VALUES (
     @nombre)
END
GO
/****** Object:  StoredProcedure [dbo].[save_User]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[save_User]
	 @usuario varchar(50),
     @pass varchar(50),
     @fecha_creacion datetime,
	 @correo varchar(50),
	 @id_registro bigint,
	 @id_role bigint
   
AS
BEGIN
INSERT INTO votacionesdb.dbo.usuarios(
     usuario,
	 pass,
	 fecha_creacion,
	 correo,
	 id_registro_nacional,
	 id_role)
    VALUES (
     @usuario,
     @pass,
     @fecha_creacion,
	 @correo,
	 @id_registro,
	 @id_role)
END
GO
/****** Object:  StoredProcedure [dbo].[update_Departamento]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_Departamento]
     @id bigint,
	 @nombre varchar(50)
   
AS
BEGIN
Update    votacionesdb.dbo.departamento  SET
	nombre = @nombre
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[update_Municipio]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_Municipio]
	@id bigint,
	 @nombre varchar(50),
	 @id_departamento bigint
   
AS
BEGIN
UPDATE votacionesdb.dbo.municipio SET
     nombre = @nombre,
	 id_departamento = @id_departamento
	 where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[update_Partido]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_Partido]
     @id bigint,
	 @nombre varchar(50),
	 @foto image
   
AS
BEGIN
UPDATE votacionesdb.dbo.partido SET
     nombre = @nombre,
	 foto = @foto

	 where id = @id
 
END
GO
/****** Object:  StoredProcedure [dbo].[update_registroNacional]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_registroNacional]
     @id bigint,
	 @nombre varchar(50),
     @primer_apellido varchar(50),
     @segundo_apellido varchar(50),
	 @fecha_nacimiento timestamp,
	 @numero_dui varchar(15),
	 @genero varchar(10),
	 @ocupacion varchar(50),
	 @nacionalidad varchar(20),
	 @direccion varchar(200),
	 @foto image,
	 @id_municipio bigint
   
AS
BEGIN
UPDATE votacionesdb.dbo.registro_nacional SET
     nombre = @nombre,
     primer_apellido = @primer_apellido,
     segundo_apellido = @segundo_apellido,
	 fecha_nacimiento = @fecha_nacimiento,
	 numero_dui = @numero_dui,
	 genero = @genero,
	 ocupacion = @ocupacion,
	 nacionalidad = @nacionalidad,
	 direccion = @direccion,
	 foto = @foto,
	 id_municipio = @id_municipio

	 where id = @id
 
END

GO
/****** Object:  StoredProcedure [dbo].[update_TipoEleccion]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_TipoEleccion]
     @id bigint,
	 @nombre varchar(50)
   
AS
BEGIN
Update    votacionesdb.dbo.tipo_eleccion  SET
	nombre = @nombre
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[update_User]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_User]
     @id bigint,
	 @usuario varchar(50),
     @pass varchar(50),
     @fecha_creacion datetime,
	 @correo varchar(50),
	 @id_registro bigint,
	 @id_role bigint
   
AS
BEGIN
Update votacionesdb.dbo.usuarios SET
     usuario = @usuario,
	 pass = @pass,
	 fecha_creacion = @fecha_creacion,
	 correo = @correo,
	 id_registro_nacional = @id_registro,
	 id_role = @id_role
	 where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[validar_dui]    Script Date: 22/5/2021 22:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[validar_dui](@numero_dui VARCHAR(50))
as
begin
select * from registro_nacional where numero_dui = @numero_dui;
end
GO
