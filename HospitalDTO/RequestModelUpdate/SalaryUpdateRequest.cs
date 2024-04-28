using HospitalDTO.Entity;

namespace HospitalDTO.RequestModelUpdate;

public record SalaryUpdateRequest : EntityBaseUpdateRequest
{
    public double Amount { get; set; }

    public double Bonus { get; set; }

    public Guid WorkerId { get; set; }
}
