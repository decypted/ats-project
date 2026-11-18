namespace Ats.ApplicationService.Entities;

public class Candidate
{
    public Guid CandidateId { get; set; } = Guid.CreateVersion7();
    public Guid CompanyId { get; set; }
    public Company Company { get; set; } = null!;
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Phone { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<Resume> Resumes { get; set; } = [];
    public List<Application> Applications { get; set; } = [];

}