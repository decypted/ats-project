namespace Ats.ApplicationService.Entities;

public class Resume
{
    public Guid ResumeId { get; set; } = Guid.CreateVersion7();
    public Candidate Candidate { get; set; } = null!;
    public Guid CandidateId { get; set; }
    
    public required string StorageKey { get; set; }
    public required string OriginalFileName { get; set; }
    public required string ContentType { get; set; }
    public long SizeBytes { get; set; }
    
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    public ParseStatus Status { get; set; } = ParseStatus.Pending;
    public string? ParserVersion { get; set; }
    public string? ParsedData { get; set; }
    public DateTime? ParsedAt { get; set; }

}