namespace Ats.ApplicationService.Entities;

public class JobSkill
{
    public Guid JobSkillId { get; set; } = Guid.CreateVersion7();
    public JobPosting JobPosting { get; set; } = null!;
    public Guid JobPostingId { get; set; }
    public required string Name { get; set; }
    public bool IsRequired { get; set; }
    public decimal ScoreWeight { get; set; }
}