using HospitalDTO.Entity;

namespace HospitalDTO.RequestModel;

public record QueueEntryRequest : EntityBaseRequest
{
    public Guid AppointmentId { get; set; }
}
