CREATE DATABASE [EmpDept]
CONTAINMENT = NONE
ON  PRIMARY 
( NAME = N'EmpDept', FILENAME = N'C:\Program Files\Microsoft SQL Server\
MSSQL15.SQLEXPRESS\MSSQL\DATA\EmpDept.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED,
FILEGROWTH = 65536KB )
LOG ON
( NAME = N'EmpDept_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\
MSSQL15.SQLEXPRESS\MSSQL\DATA\EmpDept_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB ,
FILEGROWTH = 65536KB )
WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EmpDept] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmpDept].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmpDept] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [EmpDept] SET ANSI_NULLS OFF
GO
ALTER DATABASE [EmpDept] SET ANSI_PADDING OFF
GO
ALTER DATABASE [EmpDept] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [EmpDept] SET ARITHABORT OFF
GO
ALTER DATABASE [EmpDept] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [EmpDept] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [EmpDept] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [EmpDept] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [EmpDept] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmpDept] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [EmpDept] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [EmpDept] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [EmpDept] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [EmpDept] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EmpDept] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [EmpDept] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [EmpDept] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [EmpDept] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [EmpDept] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [EmpDept] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [EmpDept] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [EmpDept] SET RECOVERY SIMPLE
GO
ALTER DATABASE [EmpDept] SET  MULTI_USER 
GO
ALTER DATABASE [EmpDept] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmpDept] SET DB_CHAINING OFF
GO
ALTER DATABASE [EmpDept] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
GO
ALTER DATABASE [EmpDept] SET TARGET_RECOVERY_TIME = 60 SECONDS
GO
ALTER DATABASE [EmpDept] SET DELAYED_DURABILITY = DISABLED
GO
ALTER DATABASE [EmpDept] SET QUERY_STORE = OFF
GO
USE [EmpDept]
GO
/****** Object:  Table [dbo].[Dept]    Script Date: 06-Sep-20 11:01:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dept](
[Deptno] [int] NOT NULL,
[Dname] [nvarchar](25) NULL,
[Loc] [nvarchar](25) NULL,
CONSTRAINT [Dept$PrimaryKey] PRIMARY KEY CLUSTERED
(
[Deptno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON
[PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emp]    Script Date: 06-Sep-20 11:01:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emp](
[Empno] [int] NOT NULL,
[Ename] [nvarchar](25) NULL,
[Job] [nvarchar](25) NULL,
[Mgr] [int] NULL,
[Hired] [datetime2](0) NULL,
[Sal] [money] NULL,
[Comm] [money] NULL,
[Deptno] [int] NULL,
CONSTRAINT [Emp$PrimaryKey] PRIMARY KEY CLUSTERED
(
[Empno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON
[PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Dept] ([Deptno], [Dname], [Loc]) VALUES (10, N'ACCOUNTING', N'NEW
YORK')
INSERT [dbo].[Dept] ([Deptno], [Dname], [Loc]) VALUES (20, N'RESEARCH', N'DALLAS')
INSERT [dbo].[Dept] ([Deptno], [Dname], [Loc]) VALUES (30, N'SALES', N'CHICAGO')
INSERT [dbo].[Dept] ([Deptno], [Dname], [Loc]) VALUES (40, N'OPERATIONS',
N'BOSTON')
GO
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7369, N'SMITH', N'CLERK', 7902, CAST(N'1980-12-17T00:00:00.0000000' AS DateTime2), 800.0000, NULL, 20)
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7499, N'ALLEN', N'SALESMAN', 7698, CAST(N'1981-02-20T00:00:00.0000000' AS DateTime2), 1600.0000, 300.0000, 30)
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7521, N'WARD', N'SALESMAN', 7698, CAST(N'1981-02-22T00:00:00.0000000' AS DateTime2), 1250.0000, 500.0000, 30)
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7566, N'JONES', N'MANAGER', 7839, CAST(N'1981-04-02T00:00:00.0000000' AS DateTime2), 2975.0000, NULL, 20)
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7654, N'MARTIN', N'SALESMAN', 7698, CAST(N'1981-09-28T00:00:00.0000000' AS DateTime2), 1250.0000, 1400.0000, 30)
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7698, N'BLAKE', N'MANAGER', 7839, CAST(N'1981-05-01T00:00:00.0000000' AS DateTime2), 2850.0000, NULL, 30)
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7782, N'CLARK', N'MANAGER', 7839, CAST(N'1981-06-09T00:00:00.0000000' AS DateTime2), 2450.0000, NULL, 10)
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7788, N'SCOTT', N'ANALYST', 7566, CAST(N'1982-12-09T00:00:00.0000000' AS DateTime2), 3000.0000, NULL, 20)
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7839, N'KING', N'PRESIDENT', NULL, CAST(N'1981-11-17T00:00:00.0000000' AS DateTime2), 5000.0000, NULL, 10)
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7844, N'TURNER', N'SALESMAN', 7698, CAST(N'1981-09-08T00:00:00.0000000' AS DateTime2), 1500.0000, 0.0000, 30)
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7876, N'ADAMS', N'CLERK', 7788, CAST(N'1983-01-12T00:00:00.0000000' AS DateTime2), 1100.0000, NULL, 20)
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7900, N'JAMES', N'CLERK', 7698, CAST(N'1981-12-03T00:00:00.0000000' AS DateTime2), 950.0000, NULL, 30)
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7902, N'FORD', N'ANALYST', 7566, CAST(N'1981-12-03T00:00:00.0000000' AS DateTime2), 3000.0000, NULL, 20)
INSERT [dbo].[Emp] ([Empno], [Ename], [Job], [Mgr], [Hired], [Sal], [Comm],
[Deptno]) VALUES (7934, N'MILLER', N'CLERK', 7782, CAST(N'1982-01-23T00:00:00.0000000' AS DateTime2), 1300.0000, NULL, 10)
GO
/****** Object:  Index [Emp$DeptEmp]    Script Date: 06-Sep-20 11:01:16 AM ******/
CREATE NONCLUSTERED INDEX [Emp$DeptEmp] ON [dbo].[Emp]
(
[Deptno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF,
DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON,
OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Emp]  WITH NOCHECK ADD  CONSTRAINT [Emp$DeptEmp] FOREIGN 
KEY([Deptno])
REFERENCES [dbo].[Dept] ([Deptno])
GO
ALTER TABLE [dbo].[Emp] CHECK CONSTRAINT [Emp$DeptEmp]
GO
