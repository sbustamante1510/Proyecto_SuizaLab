USE [DB_REGISTRO]
GO
SET IDENTITY_INSERT [dbo].[LISTADO_CITAS] ON 

INSERT [dbo].[LISTADO_CITAS] ([IdCita], [NroDocumento], [Nombres], [Especialidad]) VALUES (1, N'75698884', N'Sebastian Bustamante', N'Cardiologia')
INSERT [dbo].[LISTADO_CITAS] ([IdCita], [NroDocumento], [Nombres], [Especialidad]) VALUES (2, N'06192805', N'Lily Caldero', N'Traumatologia')
INSERT [dbo].[LISTADO_CITAS] ([IdCita], [NroDocumento], [Nombres], [Especialidad]) VALUES (3, N'45784852', N'Kevin Suarez', N'Urologia')
INSERT [dbo].[LISTADO_CITAS] ([IdCita], [NroDocumento], [Nombres], [Especialidad]) VALUES (4, N'74528954', N'Micaela Flores', N'Odontologia')

SET IDENTITY_INSERT [dbo].[USUARIO] OFF