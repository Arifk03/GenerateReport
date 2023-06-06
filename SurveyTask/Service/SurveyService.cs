using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SurveyTask.Model;
using System.Formats.Asn1;
using System.Globalization;

namespace SurveyTask.Service
{
    public class SurveyService : ISurveyService
    {
        private readonly SurveyContext _surveyContext;
        public SurveyService(SurveyContext surveyContext)
        {
            _surveyContext = surveyContext;
        }
        public async Task<List<SurveyData>> GetDetails()
        {
            var obj = new List<SurveyData>();
            try
            {
               // var abcd = DataProvider
            }
            catch (Exception ex)
            {
                throw;
            }
            return obj;
        }




        public async Task<string> GenerateReport(ReportDto parameters)
        {
            try
            {
                var reportData =await _surveyContext.surveyData
                        .FromSqlRaw("EXEC sp_GetReport @DateRange, @State, @District, @Taluka, @Session",
                            new SqlParameter("@DateRange", parameters.DateRange),
                            new SqlParameter("@State", parameters.State),
                            new SqlParameter("@District", parameters.District),
                            new SqlParameter("@Taluka", parameters.Taluka),
                            new SqlParameter("@Session", parameters.Season))
                        .ToListAsync();

                //return reportData;

                var filePath = "C:\\MVC\\Report\\report.csv"; // Specify the desired file path for the generated CSV file

                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(reportData);
                }

                return filePath;


            }
            catch (Exception ex)
            {
                 Console.WriteLine($"An error occurred while generating the report: {ex.Message}");

                throw;
            }
        }
    }


}

