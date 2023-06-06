using SurveyTask.Model;

namespace SurveyTask.Service
{
    public interface ISurveyService
    {
        Task<List<SurveyData>> GetDetails();

        Task<string> GenerateReport(ReportDto parameters);
    }
}
