USE [MedicalApp]
GO
/****** Object:  Table [dbo].[CitasMedicas]    Script Date: 12/10/2023 20:56:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CitasMedicas](
	[IdCita] [int] IDENTITY(1,1) NOT NULL,
	[ProfesionalSalud] [varchar](50) NULL,
	[Especialidad] [varchar](50) NULL,
	[Sede] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Fecha] [date] NULL,
	[Hora] [varchar](50) NULL,
	[CodigoCita] [nvarchar](50) NULL,
	[Asistencia] [bit] NULL,
	[Observaciones] [varchar](max) NULL,
	[PacienteDocumento] [int] NULL,
 CONSTRAINT [PK_CitasMedicas] PRIMARY KEY CLUSTERED 
(
	[IdCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 12/10/2023 20:56:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[IdClient] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellidos] [varchar](50) NOT NULL,
	[NumeroDocumento] [int] NOT NULL,
	[TipDocumento] [int] NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
	[FechaCreacion] [date] NOT NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[IdClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProfesionalSalud]    Script Date: 12/10/2023 20:56:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfesionalSalud](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumeroDocumento] [int] NULL,
	[Nombres] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[TipoDocumento] [int] NULL,
	[Especialidad] [varchar](50) NULL,
	[Estado] [bit] NULL,
	[FecharCreacion] [date] NULL,
	[NumeroLicencia] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProfesionalSalud] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sedes]    Script Date: 12/10/2023 20:56:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sedes](
	[IdSede] [int] IDENTITY(1,1) NOT NULL,
	[NombreSede] [varchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [int] NULL,
	[EstadoSede] [bit] NULL,
	[FechaCreacion] [date] NULL,
	[Email] [nvarchar](50) NULL,
	[CodigoSede] [int] NULL,
 CONSTRAINT [PK_Sedes] PRIMARY KEY CLUSTERED 
(
	[IdSede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
