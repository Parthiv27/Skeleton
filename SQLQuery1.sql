USE [p2723373]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblUsers_FindUsernamePW]
		@Username = N'Parthiv1',
		@Password = N'Parthiv123'

SELECT	@return_value as 'Return Value'

GO
