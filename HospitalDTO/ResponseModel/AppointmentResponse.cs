using HospitalDTO.Entity;

namespace HospitalDTO.ResponseModel;

public record AppointmentResponse : EntityBaseResponse
{
    public string Name { get; set; }
    public DateTime AppointmentDate { get; set; }
}
