using System.Collections.Generic;

namespace Domain.Metadata
{
    public class SurveyMetadataBase
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public List<Question> Variables { get; set; } = new List<Question>();
        public int InterviewCount { get; set; }
    }
}
