using HospitalDTO.Entity;

namespace HospitalDTO.RequestModel;

public record AuthRequest : EntityBaseRequest
{
    public string Login { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public bool IsBlocked { get; set; }

    public Guid WorkerId { get; set; }
}
