USE [master]
GO
/****** Object:  Database [InvestisDB]    Script Date: 6/9/2019 6:27:39 PM ******/
CREATE DATABASE [InvestisDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InvestisDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.DANIELSQLSERVER\MSSQL\DATA\InvestisDB.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'InvestisDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.DANIELSQLSERVER\MSSQL\DATA\InvestisDB_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [InvestisDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InvestisDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InvestisDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InvestisDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InvestisDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InvestisDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InvestisDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [InvestisDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InvestisDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InvestisDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InvestisDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InvestisDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InvestisDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InvestisDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InvestisDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InvestisDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InvestisDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [InvestisDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InvestisDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InvestisDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InvestisDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InvestisDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InvestisDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InvestisDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InvestisDB] SET RECOVERY FULL 
GO
ALTER DATABASE [InvestisDB] SET  MULTI_USER 
GO
ALTER DATABASE [InvestisDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InvestisDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InvestisDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InvestisDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'InvestisDB', N'ON'
GO
USE [InvestisDB]
GO
/****** Object:  Table [dbo].[tb_Banks]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Banks](
	[BankID] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tb_Banks] PRIMARY KEY CLUSTERED 
(
	[BankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Beneficiaries]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Beneficiaries](
	[BeneficiaryID] [int] IDENTITY(1,1) NOT NULL,
	[InvestorID] [int] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[PhoneNo] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[Relationship] [varchar](50) NULL,
	[AccountNo] [varchar](50) NULL,
	[AccountName] [varchar](70) NULL,
	[BankID] [int] NULL,
	[SortCode] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tb_Beneficiaries] PRIMARY KEY CLUSTERED 
(
	[BeneficiaryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_BusinessApplications]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_BusinessApplications](
	[AppID] [int] IDENTITY(1,1) NOT NULL,
	[BusinessID] [int] NULL,
	[ExpectedAmount] [varchar](50) NULL,
	[RepaymentPlan] [varchar](50) NULL,
	[DefiniteFund] [varchar](50) NULL,
	[MinFund] [varchar](50) NULL,
	[MaxFund] [varchar](50) NULL,
	[RepaymentDuration] [varchar](50) NULL,
	[MonthlyRepayment] [varchar](50) NULL,
	[AccountNo] [varchar](50) NULL,
	[BankID] [int] NULL,
	[SortCode] [varchar](50) NULL,
	[AccountName] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[IsVerified] [bit] NULL,
	[VerifierUserID] [int] NULL,
	[VerificationDetails] [varchar](50) NULL,
	[VerificationDate] [datetime] NULL,
	[IsDisbursed] [bit] NULL,
	[DisburserUserID] [int] NULL,
	[DisbursementDetails] [varchar](50) NULL,
	[DisbursementDate] [datetime] NULL,
	[IsFullyRecovered] [bit] NULL,
	[RepaymentStartDate] [datetime] NULL,
	[ExpectedRepaymentEndDate] [datetime] NULL,
	[GraceDate] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tb_BusinessApplications] PRIMARY KEY CLUSTERED 
(
	[AppID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_BusinessCategory]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_BusinessCategory](
	[BusinessCatID] [int] IDENTITY(1,1) NOT NULL,
	[BusinessCategoryName] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tb_BusinessCategory] PRIMARY KEY CLUSTERED 
(
	[BusinessCatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_BusinessOwners]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_BusinessOwners](
	[BusinessID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[RoleID] [int] NULL,
	[Email] [varchar](50) NULL,
	[Address1] [varchar](50) NULL,
	[Address2] [varchar](50) NULL,
	[Office_Phone] [varchar](50) NULL,
	[Business_Description] [varchar](500) NULL,
	[DateOfCorporation] [datetime] NULL,
	[IncorporationNo] [varchar](50) NULL,
	[AvgMonthlyIncome] [varchar](50) NULL,
	[AvgMonthlyExpensis] [varchar](50) NULL,
	[AvgMonthlyTax] [varchar](50) NULL,
	[BusinessCatID] [int] NULL,
	[CaCDocument] [varchar](500) NULL,
	[Logo] [varchar](500) NULL,
	[AccountNo] [varchar](50) NULL,
	[SortCode] [varchar](50) NULL,
	[BankID] [int] NULL,
	[AccountName] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[IsAccepted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tb_BusinessOwners] PRIMARY KEY CLUSTERED 
(
	[BusinessID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Directors]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Directors](
	[DirectorID] [int] IDENTITY(1,1) NOT NULL,
	[BusinessID] [int] NULL,
	[Dir_FullName] [varchar](50) NULL,
	[Dir_Email] [varchar](50) NULL,
	[Dir_Phone] [varchar](50) NULL,
	[Dir_Means_of_ID] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tb_Directors] PRIMARY KEY CLUSTERED 
(
	[DirectorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Disbursements]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Disbursements](
	[DisbursmentID] [int] IDENTITY(1,1) NOT NULL,
	[AppID] [int] NULL,
	[AmountDisbursed] [varchar](50) NULL,
	[AmountRemainig] [varchar](50) NULL,
	[AmountAppliedFor] [varchar](50) NULL,
	[DisbursementDate] [datetime] NULL,
	[DisbursementComment] [varchar](500) NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_tb_Disbursements] PRIMARY KEY CLUSTERED 
(
	[DisbursmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Guarantors]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Guarantors](
	[GurantorID] [int] IDENTITY(1,1) NOT NULL,
	[AppID] [int] NULL,
	[GuarantorFirstName] [varchar](50) NULL,
	[GuarantorLastName] [varchar](50) NULL,
	[GuarantorEmail] [varchar](50) NULL,
	[GuarantorPhoneNo] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[VerificationDate] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tb_Guarantors] PRIMARY KEY CLUSTERED 
(
	[GurantorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_InvestmentPackages]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_InvestmentPackages](
	[InvestmentPackageID] [int] IDENTITY(1,1) NOT NULL,
	[PackageName] [varchar](50) NULL,
	[MinInvestAmt] [varchar](50) NULL,
	[MaxInvAmt] [varchar](50) NULL,
	[MinInvestmentDuration] [varchar](50) NULL,
	[InterestPerMonth] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tb_InvestmentPackages] PRIMARY KEY CLUSTERED 
(
	[InvestmentPackageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Investments]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Investments](
	[InvestmentID] [int] IDENTITY(1,1) NOT NULL,
	[InvestmentPackageID] [int] NULL,
	[InvestmentAmt] [varchar](50) NULL,
	[InvestmentDate] [datetime] NULL,
	[ExpectedMaturityDate] [datetime] NULL,
	[Status] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[InvestorID] [int] NULL,
 CONSTRAINT [PK_tb_Investments] PRIMARY KEY CLUSTERED 
(
	[InvestmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Investors]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Investors](
	[InvestorID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[RoleID] [int] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[PhoneNo] [varchar](50) NULL,
	[Address] [varchar](100) NULL,
	[AccountNo] [varchar](50) NULL,
	[BankID] [int] NULL,
	[SortCode] [varchar](50) NULL,
	[AccountName] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tb_Investors_1] PRIMARY KEY CLUSTERED 
(
	[InvestorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Repayments]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Repayments](
	[RepaymentID] [int] IDENTITY(1,1) NOT NULL,
	[AppID] [int] NULL,
	[RepaymentDate] [datetime] NULL,
	[CurrentRepayment] [varchar](50) NULL,
	[TotalRepaid] [varchar](50) NULL,
	[AmountRemaining] [varchar](50) NULL,
	[TotalMoney] [varchar](50) NULL,
	[ExpectedRepaymentEndDate] [datetime] NULL,
	[RepaymentComment] [varchar](500) NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_tb_Repayments] PRIMARY KEY CLUSTERED 
(
	[RepaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Role]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[Role] [varchar](500) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tb_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Users]    Script Date: 6/9/2019 6:27:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](500) NULL,
	[HashPassword] [varchar](500) NULL,
	[FullName] [varchar](500) NULL,
	[Role] [varchar](50) NULL,
	[RoleID] [int] NULL,
	[Mobile] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tb_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Index [IX_FK_tb_Users_tb_Users]    Script Date: 6/9/2019 6:27:40 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_tb_Users_tb_Users] ON [dbo].[tb_Users]
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_Beneficiaries]  WITH CHECK ADD  CONSTRAINT [FK_tb_Beneficiaries_tb_Banks] FOREIGN KEY([BankID])
REFERENCES [dbo].[tb_Banks] ([BankID])
GO
ALTER TABLE [dbo].[tb_Beneficiaries] CHECK CONSTRAINT [FK_tb_Beneficiaries_tb_Banks]
GO
ALTER TABLE [dbo].[tb_Beneficiaries]  WITH CHECK ADD  CONSTRAINT [FK_tb_Beneficiaries_tb_Investors] FOREIGN KEY([InvestorID])
REFERENCES [dbo].[tb_Investors] ([InvestorID])
GO
ALTER TABLE [dbo].[tb_Beneficiaries] CHECK CONSTRAINT [FK_tb_Beneficiaries_tb_Investors]
GO
ALTER TABLE [dbo].[tb_BusinessApplications]  WITH CHECK ADD  CONSTRAINT [FK_tb_BusinessApplications_tb_Banks] FOREIGN KEY([BankID])
REFERENCES [dbo].[tb_Banks] ([BankID])
GO
ALTER TABLE [dbo].[tb_BusinessApplications] CHECK CONSTRAINT [FK_tb_BusinessApplications_tb_Banks]
GO
ALTER TABLE [dbo].[tb_BusinessApplications]  WITH CHECK ADD  CONSTRAINT [FK_tb_BusinessApplications_tb_BusinessOwners] FOREIGN KEY([BusinessID])
REFERENCES [dbo].[tb_BusinessOwners] ([BusinessID])
GO
ALTER TABLE [dbo].[tb_BusinessApplications] CHECK CONSTRAINT [FK_tb_BusinessApplications_tb_BusinessOwners]
GO
ALTER TABLE [dbo].[tb_BusinessApplications]  WITH CHECK ADD  CONSTRAINT [FK_tb_BusinessApplications_tb_Users] FOREIGN KEY([VerifierUserID])
REFERENCES [dbo].[tb_Users] ([UserID])
GO
ALTER TABLE [dbo].[tb_BusinessApplications] CHECK CONSTRAINT [FK_tb_BusinessApplications_tb_Users]
GO
ALTER TABLE [dbo].[tb_BusinessApplications]  WITH CHECK ADD  CONSTRAINT [FK_tb_BusinessApplications_tb_Users1] FOREIGN KEY([DisburserUserID])
REFERENCES [dbo].[tb_Users] ([UserID])
GO
ALTER TABLE [dbo].[tb_BusinessApplications] CHECK CONSTRAINT [FK_tb_BusinessApplications_tb_Users1]
GO
ALTER TABLE [dbo].[tb_BusinessOwners]  WITH CHECK ADD  CONSTRAINT [FK_tb_BusinessOwners_tb_Banks] FOREIGN KEY([BankID])
REFERENCES [dbo].[tb_Banks] ([BankID])
GO
ALTER TABLE [dbo].[tb_BusinessOwners] CHECK CONSTRAINT [FK_tb_BusinessOwners_tb_Banks]
GO
ALTER TABLE [dbo].[tb_BusinessOwners]  WITH CHECK ADD  CONSTRAINT [FK_tb_BusinessOwners_tb_BusinessCategory] FOREIGN KEY([BusinessCatID])
REFERENCES [dbo].[tb_BusinessCategory] ([BusinessCatID])
GO
ALTER TABLE [dbo].[tb_BusinessOwners] CHECK CONSTRAINT [FK_tb_BusinessOwners_tb_BusinessCategory]
GO
ALTER TABLE [dbo].[tb_BusinessOwners]  WITH CHECK ADD  CONSTRAINT [FK_tb_BusinessOwners_tb_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[tb_Role] ([RoleID])
GO
ALTER TABLE [dbo].[tb_BusinessOwners] CHECK CONSTRAINT [FK_tb_BusinessOwners_tb_Role]
GO
ALTER TABLE [dbo].[tb_BusinessOwners]  WITH CHECK ADD  CONSTRAINT [FK_tb_BusinessOwners_tb_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[tb_Users] ([UserID])
GO
ALTER TABLE [dbo].[tb_BusinessOwners] CHECK CONSTRAINT [FK_tb_BusinessOwners_tb_Users]
GO
ALTER TABLE [dbo].[tb_Directors]  WITH CHECK ADD  CONSTRAINT [FK_tb_Directors_tb_BusinessOwners] FOREIGN KEY([BusinessID])
REFERENCES [dbo].[tb_BusinessOwners] ([BusinessID])
GO
ALTER TABLE [dbo].[tb_Directors] CHECK CONSTRAINT [FK_tb_Directors_tb_BusinessOwners]
GO
ALTER TABLE [dbo].[tb_Disbursements]  WITH CHECK ADD  CONSTRAINT [FK_tb_Disbursements_tb_BusinessApplications] FOREIGN KEY([AppID])
REFERENCES [dbo].[tb_BusinessApplications] ([AppID])
GO
ALTER TABLE [dbo].[tb_Disbursements] CHECK CONSTRAINT [FK_tb_Disbursements_tb_BusinessApplications]
GO
ALTER TABLE [dbo].[tb_Guarantors]  WITH CHECK ADD  CONSTRAINT [FK_tb_Guarantors_tb_BusinessApplications] FOREIGN KEY([AppID])
REFERENCES [dbo].[tb_BusinessApplications] ([AppID])
GO
ALTER TABLE [dbo].[tb_Guarantors] CHECK CONSTRAINT [FK_tb_Guarantors_tb_BusinessApplications]
GO
ALTER TABLE [dbo].[tb_Investments]  WITH CHECK ADD  CONSTRAINT [FK_tb_Investments_tb_Investments] FOREIGN KEY([InvestmentPackageID])
REFERENCES [dbo].[tb_InvestmentPackages] ([InvestmentPackageID])
GO
ALTER TABLE [dbo].[tb_Investments] CHECK CONSTRAINT [FK_tb_Investments_tb_Investments]
GO
ALTER TABLE [dbo].[tb_Investments]  WITH CHECK ADD  CONSTRAINT [FK_tb_Investments_tb_Investors] FOREIGN KEY([InvestorID])
REFERENCES [dbo].[tb_Investors] ([InvestorID])
GO
ALTER TABLE [dbo].[tb_Investments] CHECK CONSTRAINT [FK_tb_Investments_tb_Investors]
GO
ALTER TABLE [dbo].[tb_Investors]  WITH CHECK ADD  CONSTRAINT [FK_tb_Investors_tb_Banks] FOREIGN KEY([BankID])
REFERENCES [dbo].[tb_Banks] ([BankID])
GO
ALTER TABLE [dbo].[tb_Investors] CHECK CONSTRAINT [FK_tb_Investors_tb_Banks]
GO
ALTER TABLE [dbo].[tb_Investors]  WITH CHECK ADD  CONSTRAINT [FK_tb_Investors_tb_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[tb_Role] ([RoleID])
GO
ALTER TABLE [dbo].[tb_Investors] CHECK CONSTRAINT [FK_tb_Investors_tb_Role]
GO
ALTER TABLE [dbo].[tb_Investors]  WITH CHECK ADD  CONSTRAINT [FK_tb_Investors_tb_Users] FOREIGN KEY([InvestorID])
REFERENCES [dbo].[tb_Users] ([UserID])
GO
ALTER TABLE [dbo].[tb_Investors] CHECK CONSTRAINT [FK_tb_Investors_tb_Users]
GO
ALTER TABLE [dbo].[tb_Repayments]  WITH CHECK ADD  CONSTRAINT [FK_tb_Repayments_tb_BusinessApplications] FOREIGN KEY([AppID])
REFERENCES [dbo].[tb_BusinessApplications] ([AppID])
GO
ALTER TABLE [dbo].[tb_Repayments] CHECK CONSTRAINT [FK_tb_Repayments_tb_BusinessApplications]
GO
ALTER TABLE [dbo].[tb_Users]  WITH CHECK ADD  CONSTRAINT [FK_tb_Users_tb_Users] FOREIGN KEY([RoleID])
REFERENCES [dbo].[tb_Role] ([RoleID])
GO
ALTER TABLE [dbo].[tb_Users] CHECK CONSTRAINT [FK_tb_Users_tb_Users]
GO
USE [master]
GO
ALTER DATABASE [InvestisDB] SET  READ_WRITE 
GO
