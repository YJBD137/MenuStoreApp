
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yuan Jason B. Dimayuga
-- Create date: 16/05/2023
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE addProduct
	@SHELF_NUMBER INT,
	@CONSIGNOR_ID INT,
	@SKU VARCHAR(20),
	@productNAME VARCHAR(100),
	@Size VARCHAR(20),
	@Price INT,
	@STATUS_ID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   INSERT INTO INVENTORY(
		SHELF_NUMBER,
		CONSIGNOR_ID,
		SKU,
		productNAME,
		Size,
		Price,
		STATUS_ID
	)
	VALUES(
		@SHELF_NUMBER,
		@CONSIGNOR_ID,
		@SKU,
		@productNAME,
		@Size,
		@Price,
		@STATUS_ID
	);

	SELECT *
	FROM INVENTORY

END
GO
