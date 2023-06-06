using SurveyTask.Model;

namespace SurveyTask.Service
{
    public interface ISurveyService
    {
        Task<string> GenerateReport(ReportDto parameters);
    }
}
