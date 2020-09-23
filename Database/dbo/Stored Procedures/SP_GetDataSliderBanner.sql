
CREATE PROCEDURE SP_GetDataSliderBanner
	@Page nvarchar(max)
AS
BEGIN
	SET NOCOUNT ON;
    select*from DataSliderBanner where name_page =@Page
END
