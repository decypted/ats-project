namespace Ats.ApplicationService.Entities;

public class ApplicationStatusHistory
{
    public Guid ApplicationStatusHistoryId { get; set; } = Guid.CreateVersion7();

    public Guid ApplicationId { get; set; }
    public Application Application { get; set; } = null!;

    public ApplicationStatus? FromStatus { get; set; }
    public required ApplicationStatus ToStatus { get; set; }
    public string? Reason { get; set; }

    public DateTime ChangedAt { get; set; } = DateTime.UtcNow;
}