namespace Ats.ApplicationService.Entities;

public class JobPosting
{
    public Guid JobPostingId { get; set; } = Guid.CreateVersion7();
    public Guid CompanyId { get; set; }
    public Company Company { get; set; } = null!;
    public required string JobTitle { get; set; }
    public JobPostingStatus Status { get; set; } = JobPostingStatus.Open;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public required string Description { get; set; }
    public List<JobSkill> JobSkills { get; set; } = [];
    public List<Application> Applications { get; set; } = [];
}