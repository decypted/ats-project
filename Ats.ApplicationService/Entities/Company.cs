namespace Ats.ApplicationService.Entities;

public class Company
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public required string Name { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<JobPosting> JobPostings { get; set; } = [];
    public List<Candidate> Candidates { get; set; } = [];

}