CREATE PROC sp_GetReport    
 @DateRange VARCHAR(100),    
 @State VARCHAR(50),    
 @District VARCHAR(50),    
 @Taluka VARCHAR(50),    
 @Season VARCHAR(50)    
AS    
BEGIN    
 SELECT * FROM SurveyData as sd    
 WHERE    
  (@DateRange IS NULL OR sd.uploaded_date LIKE '%' + @DateRange + '%')    
  AND (@State IS NULL OR sd.[state] LIKE '%' + @State + '%')    
  AND (@District IS NULL OR sd.dist LIKE '%' + @District + '%')    
  AND (@Taluka IS NULL OR sd.taluka LIKE '%' + @Taluka + '%')    
  AND (@Season IS NULL OR sd.season LIKE '%' + @Season + '%')    
END