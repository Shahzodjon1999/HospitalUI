namespace HospitalDTO.Entity;

public abstract record EntityBaseUpdateRequest
{
    public Guid Id { get; set; }
}
