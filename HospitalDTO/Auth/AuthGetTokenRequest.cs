using HospitalDTO.Entity;
using System.ComponentModel.DataAnnotations;

namespace HospitalDTO.Auth;

public record AuthGetTokenRequest:EntityBaseRequest
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Login")]
    public string? Username { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Password")]
    public string? Password { get; set; }
}
