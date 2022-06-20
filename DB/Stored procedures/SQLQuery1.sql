USE [ResturantDBProject]
GO
/****** Object:  StoredProcedure [dbo].[AddBranch]    Script Date: 20-Jun-22 1:16:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[AddBranch]
@BranchName varchar(50),
@ID       int,
@Blocation  varchar(50),
@BranchTax int ,
@BranchSupSSN int 


as 
begin
insert into Branch
values (@BranchName,@ID,@Blocation,@BranchTax,@BranchSupSSN)
END
