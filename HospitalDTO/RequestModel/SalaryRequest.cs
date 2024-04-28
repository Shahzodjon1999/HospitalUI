using HospitalDTO.Entity;

namespace HospitalDTO.RequestModel;

public record SalaryRequest : EntityBaseRequest
{
    public double Amount { get; set; }

    public double Bonus { get; set; }

    public Guid WorkerId { get; set; }
}
