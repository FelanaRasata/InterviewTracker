namespace FrontOffice.Models
{
    public class Job
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required bool Status { get; set; } = false;
        public DateTime DateLimit { get; set; } = DateTime.Now.AddMonths(1);
    }
}
