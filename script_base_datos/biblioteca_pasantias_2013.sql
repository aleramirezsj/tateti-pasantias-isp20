USE [biblioteca_pasantias_2013]
GO
/****** Object:  Table [dbo].[libros]    Script Date: 09/05/2013 15:22:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[libros](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](80) NOT NULL,
	[paginas] [smallint] NOT NULL,
	[isbn] [varchar](20) NOT NULL,
 CONSTRAINT [PK_libros] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[libros] ON
INSERT [dbo].[libros] ([id], [nombre], [paginas], [isbn]) VALUES (1, N'MI PLANTA', 345, N'676-323-223')
INSERT [dbo].[libros] ([id], [nombre], [paginas], [isbn]) VALUES (3, N'ALGO', 33, N'aa bb')
INSERT [dbo].[libros] ([id], [nombre], [paginas], [isbn]) VALUES (4, N'C# Avanzado', 180, N'222-222-222')
INSERT [dbo].[libros] ([id], [nombre], [paginas], [isbn]) VALUES (5, N'probando2', 2222, N'222-222--2222')
SET IDENTITY_INSERT [dbo].[libros] OFF
/****** Object:  StoredProcedure [dbo].[modificar_libro]    Script Date: 09/05/2013 15:22:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[modificar_libro] 
	-- Add the parameters for the stored procedure here
	@id_mod int, @nom VARCHAR(80), @pag SMALLINT, @isb VARCHAR(20) 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE libros 
	SET nombre=@nom, paginas=@pag, isbn=@isb
	where id=@id_mod
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_libro]    Script Date: 09/05/2013 15:22:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[insertar_libro]
(@nom VARCHAR(80), @pag SMALLINT, @isb VARCHAR(20))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO libros (nombre,paginas,isbn)
	VALUES (@nom,@pag,@isb)
END
GO
/****** Object:  StoredProcedure [dbo].[eliminar_libro]    Script Date: 09/05/2013 15:22:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_libro] 
	-- Add the parameters for the stored procedure here
	(@id_eli int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM libros Where id=@id_eli
END
GO
