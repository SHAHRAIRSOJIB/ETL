USE [ExelTechLtdDb]
GO

/****** Object:  Table [dbo].[Allergies_Details]    Script Date: 2/11/2024 3:37:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Allergies_Details](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NOT NULL,
	[Allergy_Id] [int] NOT NULL,
 CONSTRAINT [PK_Allergies_Details] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Allergies_Details]  WITH CHECK ADD  CONSTRAINT [FK_Allergies_Details_Patients_PatientId] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([PId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Allergies_Details] CHECK CONSTRAINT [FK_Allergies_Details_Patients_PatientId]
GO


