using Microsoft.EntityFrameworkCore;

namespace SurveyTask.Model
{
    public class SurveyContext : DbContext
    {
        public SurveyContext(DbContextOptions<SurveyContext>options) : base(options)
        {
        }
        public DbSet<SurveyData> surveyData { get; set; }
    }
}
