namespace WebApplication13.Models
{
    public class FormQuestion
    {
        public string ContentOfQuestion { get; set; }
        public List<string> AnswerList { get; set; }
        public List<string> CorrectAnswerList { get; set; }
        public int Duration { get; set; }
        public string TypeQuestion { get; set; }
        public int Mark { get; set; }
    }
}
