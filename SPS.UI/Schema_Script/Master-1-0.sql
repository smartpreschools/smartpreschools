
GO
/****** Object:  Table [dbo].[SPS_tblTalukaMaster]    Script Date: 11/20/2021 21:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPS_tblTalukaMaster](
	[TalukaID] [int] IDENTITY(1,1) NOT NULL,
	[CountryID] [int] NOT NULL,
	[StateID] [int] NOT NULL,
	[DistrictID] [int] NOT NULL,
	[TalukaName] [varchar](150) NOT NULL,
	[TalukaDesc] [varchar](250) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[ModifiedOn] [datetime] NULL,
	[TalukaStatus] [bit] NULL,
 CONSTRAINT [PK_SPS_tblTalukaMaster] PRIMARY KEY CLUSTERED 
(
	[TalukaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPS_tblStateMaster]    Script Date: 11/20/2021 21:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPS_tblStateMaster](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[CountryID] [int] NOT NULL,
	[StateName] [varchar](150) NOT NULL,
	[StateDesc] [varchar](250) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[ModifiedOn] [datetime] NULL,
	[StateStatus] [bit] NULL,
 CONSTRAINT [PK_SPS_tblStateMaster] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPS_tblDistrictMaster]    Script Date: 11/20/2021 21:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPS_tblDistrictMaster](
	[DistrictID] [int] IDENTITY(1,1) NOT NULL,
	[CountryID] [int] NOT NULL,
	[StateID] [int] NOT NULL,
	[DistrictName] [varchar](150) NOT NULL,
	[DistrictDesc] [varchar](250) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[ModifiedOn] [datetime] NULL,
	[DistrictStatus] [bit] NULL,
 CONSTRAINT [PK_SPS_tblDistrictMaster] PRIMARY KEY CLUSTERED 
(
	[DistrictID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPS_tblCountryMaster]    Script Date: 11/20/2021 21:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPS_tblCountryMaster](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [varchar](150) NOT NULL,
	[CountryDesc] [varchar](250) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[ModifiedOn] [datetime] NULL,
	[CountryStatus] [bit] NULL,
 CONSTRAINT [PK_SPS_tblCountryMaster] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPS_tblCityMaster]    Script Date: 11/20/2021 21:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPS_tblCityMaster](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CountryID] [int] NOT NULL,
	[StateID] [int] NOT NULL,
	[DistrictID] [int] NOT NULL,
	[TalukaID] [int] NOT NULL,
	[CityName] [varchar](150) NOT NULL,
	[CityDesc] [varchar](250) NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[ModifiedOn] [datetime] NULL,
	[CityStatus] [bit] NULL,
 CONSTRAINT [PK_SPS_tblCityMaster] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcUpdateTaluka]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 13 April 2021
-- Description:	Update District
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcUpdateTaluka]
	-- Add the parameters for the stored procedure here
	@V_CountryID varchar(500),
	@V_StateID varchar(500),
	@V_DistrictID varchar(500),
	@V_TalukaID varchar(500),
	@V_TalukaName varchar(500),
	@V_TalukaDesc varchar(500),
	@V_ModifiedBy varchar(500),
	@V_TalukaStatus bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 update SPS_tblTalukaMaster set CountryID=@V_CountryID,StateID=@V_StateID,DistrictId=@V_DistrictID,
			    TalukaName=@V_TalukaName,
				TalukaDesc=@V_TalukaDesc,
				ModifiedBy=@V_ModifiedBy,
				ModifiedOn=getdate(),
				TalukaStatus=@V_TalukaStatus
				where TalukaID = @V_TalukaID
	
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcUpdateState]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 11 April 2021
-- Description:	Update State
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcUpdateState]
	-- Add the parameters for the stored procedure here
	@V_CountryID varchar(500),
	@V_StateID varchar(500),
	@V_StateName varchar(500),
	@V_StateDesc varchar(500),
	@V_ModifiedBy varchar(500),
	@V_StateStatus bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 update SPS_tblStateMaster set CountryID=@V_CountryID,
			    StateName=@V_StateName,
				StateDesc=@V_StateDesc,
				ModifiedBy=@V_ModifiedBy,
				ModifiedOn=getdate(),
				StateStatus=@V_StateStatus
				where StateID=@V_StateID
	
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcUpdateDistrict]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 13 April 2021
-- Description:	Update District
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcUpdateDistrict]
	-- Add the parameters for the stored procedure here
	@V_CountryID varchar(500),
	@V_StateID varchar(500),
	@V_DistrictID varchar(500),
	@V_DistrictName varchar(500),
	@V_DistrictDesc varchar(500),
	@V_ModifiedBy varchar(500),
	@V_DistrictStatus bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 update SPS_tblDistrictMaster set CountryID=@V_CountryID,StateID=@V_StateID,
			    DistrictName=@V_DistrictName,
				DistrictDesc=@V_DistrictDesc,
				ModifiedBy=@V_ModifiedBy,
				ModifiedOn=getdate(),
				DistrictStatus=@V_DistrictStatus
				where DistrictID=@V_DistrictID
	
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcUpdateCountry]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 11 April 2021
-- Description:	Update Country
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcUpdateCountry]
	-- Add the parameters for the stored procedure here
	@V_CountryID varchar(500),
	@V_CountryName varchar(500),
	@V_CountryDesc varchar(500),
	@V_ModifiedBy varchar(500),
	@V_CountryStatus bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 update SPS_tblCountryMaster set CountryName=@V_CountryName,
				CountryDesc=@V_CountryDesc,
				ModifiedBy=@V_ModifiedBy,
				ModifiedOn=getdate(),
				CountryStatus=@V_CountryStatus
				where CountryID=@V_CountryID
	
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcUpdateCity]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 14 April 2021
-- Description:	Update City
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcUpdateCity]
	-- Add the parameters for the stored procedure here
	@V_CountryID varchar(500),
	@V_StateID varchar(500),
	@V_DistrictID varchar(500),
	@V_TalukaID varchar(500),
	@V_CityID varchar(500),
	@V_CityName varchar(500),
	@V_CityDesc varchar(500),
	@V_ModifiedBy varchar(500),
	@V_CityStatus bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 update SPS_tblCityMaster set CountryID=@V_CountryID,StateID=@V_StateID,DistrictId=@V_DistrictID,TalukaID=@V_TalukaID,
			    CityName=@V_CityName,
				CityDesc=@V_CityDesc,
				ModifiedBy=@V_ModifiedBy,
				ModifiedOn=getdate(),
				CityStatus=@V_CityStatus
				where CityID = @V_CityID
	
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetTalukaList]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 13 April 2021
-- Description:	return all active Taluka list
-- =============================================
CREATE PROCEDURE [dbo].[SPS_ProcGetTalukaList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select TM.TalukaId,TM.TalukaName,TM.TalukaDesc,TM.TalukaStatus ,
	CM.CountryName as CountryId,
	SM.stateName as StateID,
	DM.DistrictName as DistrictID
	from SPS_tblTalukaMaster TM
	Left Outer Join SPS_tblCountryMaster CM
	on TM.CountryId = CM.CountryID
	Left Outer Join SPS_tblStateMaster SM
	on TM.StateId = SM.StateID
	Left Outer Join SPS_tblDistrictMaster DM
	on TM.DistrictID = DM.DistrictID
	
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetTalukaById]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 13 April 2021
-- Description:	To return Single Taluka based on Taluka ID
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcGetTalukaById]
	-- Add the parameters for the stored procedure here
	@V_TalukaID varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from SPS_tblTalukaMaster where TalukaId=@V_TalukaID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetStateList]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 14 April 2021
-- Description:	return all active State list
-- =============================================
CREATE PROCEDURE [dbo].[SPS_ProcGetStateList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select SM.StateID,SM.StateName,SM.StateDesc,SM.StateStatus,
	CM.CountryName as CountryID,
	SM.stateName as StateID
	from SPS_tblStateMaster SM
	Left Outer Join SPS_tblCountryMaster CM
	on SM.CountryId = CM.CountryID
	
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetStateById]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 11 April 2021
-- Description:	To return Single Country based on State ID
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcGetStateById]
	-- Add the parameters for the stored procedure here
	@V_StateID varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from SPS_tblStateMaster where StateId=@V_StateID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetDistrictList]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 13 April 2021
-- Description:	return all active District list
-- =============================================
CREATE PROCEDURE [dbo].[SPS_ProcGetDistrictList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select DM.DistrictId,DM.DistrictName,DM.DistrictDesc,DM.DistrictStatus,
	CM.CountryName as CountryId,
	SM.stateName as StateID
	from SPS_tblDistrictMaster DM
	Left Outer Join SPS_tblCountryMaster CM
	on DM.CountryId = CM.CountryID
	Left Outer Join SPS_tblStateMaster SM
	on DM.StateId = SM.StateID
	
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetDistrictById]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 13 April 2021
-- Description:	To return Single District based on District ID
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcGetDistrictById]
	-- Add the parameters for the stored procedure here
	@V_DistrictID varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from SPS_tblDistrictMaster where DistrictId=@V_DistrictID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetCountryList]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 14 April 2021
-- Description:	return all active Country list
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcGetCountryList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from SPS_tblCountryMaster
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetCountryById]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 11 April 2021
-- Description:	To return Single Country based on Country ID
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcGetCountryById]
	-- Add the parameters for the stored procedure here
	@V_CountryID varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from SPS_tblCountryMaster where CountryId=@V_CountryID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetCityList]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 13 April 2021
-- Description:	return all active City list
-- =============================================
CREATE PROCEDURE [dbo].[SPS_ProcGetCityList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select CM.CityId,CM.CityName,CM.CityDesc,CM.CityStatus,
	TCM.CountryName as CountryId,
	SM.stateName as StateID,
	DM.DistrictName as DistrictID,
	TM.TalukaName as TalukaID
	from SPS_tblCityMaster CM
	Left Outer Join SPS_tblCountryMaster TCM
	on CM.CountryId = CM.CountryID
	Left Outer Join SPS_tblStateMaster SM
	on CM.StateId = SM.StateID
	Left Outer Join SPS_tblDistrictMaster DM
	on CM.DistrictID = DM.DistrictID
	Left Outer Join SPS_tblTalukaMaster TM
	on CM.TalukaID = TM.TalukaID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetCityById]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 13 April 2021
-- Description:	To return Single City based on City ID
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcGetCityById]
	-- Add the parameters for the stored procedure here
	@V_CityID varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from SPS_tblCityMaster where CityId=@V_CityID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetActiveTaluka]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		sourabh Raut
-- Create date: 13 April 2021
-- Description:	Actiive Taluka list for binding dropdown
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcGetActiveTaluka] 
	-- Add the parameters for the stored procedure here
	@V_DistrictID Varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select TalukaID as DataID,TalukaName as DataName from SPS_tblTalukaMaster where TalukaStatus=1 and DistrictID=@V_DistrictID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetActiveState]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		sourabh Raut
-- Create date: 13 April 2021
-- Description:	Actiive State list for binding dropdown
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcGetActiveState] 
	-- Add the parameters for the stored procedure here
	@V_CountryID Varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select StateID as DataID,StateName as DataName from SPS_tblStateMaster where StateStatus=1 and CountryID=@V_CountryID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetActiveDistrict]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		sourabh Raut
-- Create date: 13 April 2021
-- Description:	Actiive State list for binding dropdown
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcGetActiveDistrict] 
	-- Add the parameters for the stored procedure here
	@V_StateID Varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select DistrictID as DataID,DistrictName as DataName from SPS_tblDistrictMaster where DistrictStatus=1 and StateID=@V_StateID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetActiveCountry]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		sourabh Raut
-- Create date: 14 April 2021
-- Description:	Actiive Country list for binding dropdown
-- =============================================
CREATE PROCEDURE [dbo].[SPS_ProcGetActiveCountry] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select CountryID as DataID,CountryName as DataName from SPS_tblCountryMaster where CountryStatus=1
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcGetActiveCity]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		sourabh Raut
-- Create date: 13 April 2021
-- Description:	Actiive City list for binding dropdown
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcGetActiveCity] 
	-- Add the parameters for the stored procedure here
	@V_TalukaID Varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select CityID as DataID,CityName as DataName from SPS_tblCityMaster where CityStatus=1 and TalukaID=@V_TalukaID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcDeleteTaluka]    Script Date: 11/20/2021 21:40:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 13 April 2021
-- Description:	for deleting Taluka
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcDeleteTaluka]
	-- Add the parameters for the stored procedure here
	@V_TalukaID varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from SPS_tblTalukaMaster where TalukaID=@V_TalukaID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcDeleteState]    Script Date: 11/20/2021 21:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 14 April 2021
-- Description:	for deleting State
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcDeleteState]
	-- Add the parameters for the stored procedure here
	@V_StateID varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from SPS_tblStateMaster where StateID=@V_StateID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcDeleteDistrict]    Script Date: 11/20/2021 21:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 13 April 2021
-- Description:	for deleting District
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcDeleteDistrict]
	-- Add the parameters for the stored procedure here
	@V_DistrictID varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from SPS_tblDistrictMaster where DistrictID=@V_DistrictID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcDeleteCountry]    Script Date: 11/20/2021 21:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 14 April 2021
-- Description:	for deleting Country
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcDeleteCountry]
	-- Add the parameters for the stored procedure here
	@V_CountryID varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from SPS_tblCountryMaster where CountryID=@V_CountryID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcDeleteCity]    Script Date: 11/20/2021 21:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 14 April 2021
-- Description:	for deleting City
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcDeleteCity]
	-- Add the parameters for the stored procedure here
	@V_CityID varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from SPS_tblCityMaster where CityID=@V_CityID
END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcAddTaluka]    Script Date: 11/20/2021 21:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 13 Apri 2021
-- Description:	create new Taluka
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcAddTaluka] 
	-- Add the parameters for the stored procedure here
	@V_CountryID int,
	@V_StateID int,
	@V_DistrictID int,
	@V_TalukaName varchar(500),
	@V_TalukaDesc varchar(500),
	@V_CreatedBy varchar(500),
	@V_TalukaStatus bit
AS

	BEGIN
	
	 IF NOT EXISTS (SELECT * FROM SPS_tblTalukaMaster 
                   WHERE TalukaName = @V_TalukaName and CountryID= @V_CountryID and StateID = @V_StateID and DistrictID = @V_DistrictID)
		   BEGIN
			   INSERT INTO SPS_tblTalukaMaster (CountryId,StateID,DistrictID,TalukaName,TalukaDesc,CreatedBy,CreatedOn,TalukaStatus)
				VALUES(@V_CountryID,@V_StateID,@V_DistrictID,@V_TalukaName,@V_TalukaDesc,@V_CreatedBy,getdate(),@V_TalukaStatus)
		   END
	END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcAddState]    Script Date: 11/20/2021 21:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 14 Apri 2021
-- Description:	create new State
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcAddState] 
	-- Add the parameters for the stored procedure here
	@V_CountryID int,
	@V_StateName varchar(500),
	@V_StateDesc varchar(500),
	@V_CreatedBy varchar(500),
	@V_StateStatus bit
AS

	BEGIN
	
	 IF NOT EXISTS (SELECT * FROM SPS_tblStateMaster 
                   WHERE StateName = @V_StateName and CountryID= @V_CountryID)
		   BEGIN
			   INSERT INTO SPS_tblStateMaster (CountryId,StateName,StateDesc,CreatedBy,CreatedOn,StateStatus)
				VALUES(@V_CountryID,@V_StateName,@V_StateDesc,@V_CreatedBy,getdate(),@V_StateStatus)
		   END
	END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcAddDistrict]    Script Date: 11/20/2021 21:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 13 Apri 2021
-- Description:	create new District
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcAddDistrict] 
	-- Add the parameters for the stored procedure here
	@V_CountryID int,
	@V_StateID int,
	@V_DistrictName varchar(500),
	@V_DistrictDesc varchar(500),
	@V_CreatedBy varchar(500),
	@V_DistrictStatus bit
AS

	BEGIN
	
	 IF NOT EXISTS (SELECT * FROM SPS_tblDistrictMaster 
                   WHERE DistrictName = @V_DistrictName and CountryID= @V_CountryID and StateID = @V_StateID)
		   BEGIN
			   INSERT INTO SPS_tblDistrictMaster (CountryId,StateID,DistrictName,DistrictDesc,CreatedBy,CreatedOn,DistrictStatus)
				VALUES(@V_CountryID,@V_StateID,@V_DistrictName,@V_DistrictDesc,@V_CreatedBy,getdate(),@V_DistrictStatus)
		   END
	END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcAddCountry]    Script Date: 11/20/2021 21:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 14 Apri 2021
-- Description:	create new Country
-- =============================================
CREATE PROCEDURE [dbo].[SPS_ProcAddCountry] 
	-- Add the parameters for the stored procedure here
	@V_CountryName varchar(500),
	@V_CountryDesc varchar(500),
	@V_CreatedBy varchar(500),
	@V_CountryStatus bit
AS

	BEGIN
	
	 IF NOT EXISTS (SELECT * FROM SPS_tblCountryMaster 
                   WHERE CountryName = @V_CountryName)
		   BEGIN
			   INSERT INTO SPS_tblCountryMaster (CountryName,CountryDesc,CreatedBy,CreatedOn,CountryStatus)
				VALUES(@V_CountryName,@V_CountryDesc,@V_CreatedBy,getdate(),@V_CountryStatus)
		   END
	END
GO
/****** Object:  StoredProcedure [dbo].[SPS_ProcAddCity]    Script Date: 11/20/2021 21:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sourabh Raut
-- Create date: 14 Apri 2021
-- Description:	create new City
-- =============================================
Create PROCEDURE [dbo].[SPS_ProcAddCity] 
	-- Add the parameters for the stored procedure here
	@V_CountryID int,
	@V_StateID int,
	@V_DistrictID int,
	@V_TalukaID int,
	@V_CityName varchar(500),
	@V_CityDesc varchar(500),
	@V_CreatedBy varchar(500),
	@V_CityStatus bit
AS

	BEGIN
	
	 IF NOT EXISTS (SELECT * FROM SPS_tblCityMaster 
                   WHERE CityName = @V_CityName and CountryID= @V_CountryID and StateID = @V_StateID and DistrictID = @V_DistrictID and TalukaID = @V_TalukaID)
		   BEGIN
			   INSERT INTO SPS_tblCityMaster (CountryId,StateID,DistrictID,TalukaID,CityName,CityDesc,CreatedBy,CreatedOn,CityStatus)
				VALUES(@V_CountryID,@V_StateID,@V_DistrictID,@V_TalukaID,@V_CityName,@V_CityDesc,@V_CreatedBy,getdate(),@V_CityStatus)
		   END
	END
GO
