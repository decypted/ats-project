namespace Ats.ApplicationService.Entities;

public class Application
{
    public Guid ApplicationId { get; set; } = Guid.CreateVersion7();

    public Guid CandidateId { get; set; }
    public Candidate Candidate { get; set; } = null!;

    public Guid JobPostingId { get; set; }
    public JobPosting JobPosting { get; set; } = null!;

    public Guid ResumeId { get; set; }
    public Resume Resume { get; set; } = null!;

    public ApplicationStatus Status { get; set; } = ApplicationStatus.Applied;

    // Filled in by screening — null until then
    public decimal? Score { get; set; }
    public string? RulesVersion { get; set; }
    public string? RejectionReason { get; set; }

    public DateTime AppliedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public List<ApplicationStatusHistory> StatusHistory { get; set; } = [];
}