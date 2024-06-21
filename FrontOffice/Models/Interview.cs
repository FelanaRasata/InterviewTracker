namespace FrontOffice.Models
{
    public class Interview
    {
        public int Id { get; set; }
        public required int JobId { get; set; }
        public required Job Job { get; set; }
        public required int ApplicantId { get; set; }
        public required User Applicant { get; set; }
        public DateTime Date { get; set; } = DateTime.Now.AddDays(5);
        public bool Status { get; set; } = false;
    }
}
