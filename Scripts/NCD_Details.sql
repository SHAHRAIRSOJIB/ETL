USE [ExelTechLtdDb]
GO

/****** Object:  Table [dbo].[NCD_Details]    Script Date: 2/11/2024 3:39:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NCD_Details](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NOT NULL,
	[NCDId] [int] NOT NULL,
 CONSTRAINT [PK_NCD_Details] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[NCD_Details]  WITH CHECK ADD  CONSTRAINT [FK_NCD_Details_Patients_PatientId] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([PId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[NCD_Details] CHECK CONSTRAINT [FK_NCD_Details_Patients_PatientId]
GO


