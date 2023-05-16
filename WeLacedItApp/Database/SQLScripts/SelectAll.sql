SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yuan Jason B. Dimayuga
-- Create date: 16/05/2023
-- Description:	Displays all Tables
-- =============================================
CREATE PROCEDURE SelectAll(@a int)
AS
BEGIN
	
	SET NOCOUNT ON;
	
		Select *
		FROM EMPLOYEE

		Select *
		FROM POSITION

		Select *
		FROM INVENTORY

		Select *
		FROM CONSIGNORS

		Select *
		FROM PayMETHOD

		Select *
		FROM SALES

		Select *
		FROM STATUS

		Select *
		FROM FINANCES

END
GO
