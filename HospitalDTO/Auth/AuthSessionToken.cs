﻿namespace HospitalDTO.Auth;

public record AuthSessionToken
{
    public string AccessToken { get; set; } = string.Empty;

    public string Role { get; set; } = string.Empty;

    public string RefreshToken { get; set; } = string.Empty;
}
