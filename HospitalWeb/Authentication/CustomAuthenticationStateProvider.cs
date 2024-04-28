using Blazored.SessionStorage;
using HospitalDTO.Auth;
using HospitalWeb.Extentions;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace HospitalWeb.Authentication;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly ISessionStorageService _sessionStorage;

    private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

    public CustomAuthenticationStateProvider(ISessionStorageService sessionStorage)
    {
        _sessionStorage = sessionStorage;
    }
    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        try
        {
            var userSession = await _sessionStorage.ReadEncryptedItemAsync<AuthSessionToken>("UserSession");
            if (userSession == null)
                return await Task.FromResult(new AuthenticationState(_anonymous));
            var claimsPrinciple = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.Name, userSession.Role),
                new Claim(ClaimTypes.Role, userSession.Role)
            }, "JwtAuth"));

            return await Task.FromResult(new AuthenticationState(claimsPrinciple));
        }
        catch
        {
            return await Task.FromResult(new AuthenticationState(_anonymous));
        }
    }

    public async Task UpdateAuthenticationState(AuthSessionToken? userSession)
    {
        ClaimsPrincipal claimsPrincipal;
        if (userSession != null)
        {
            claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
        {
            new Claim(ClaimTypes.Name, userSession.RefreshToken),
            new Claim(ClaimTypes.Role, userSession.Role)
        }));
            //userSession.ExpiryTimeStamp = DateTime.Now.AddSeconds(userSession.ExpiresIn);
            await _sessionStorage.SaveItemEncryptedAsnc("UserSession", userSession);
        }
        else
        {
            claimsPrincipal = _anonymous;
            await _sessionStorage.RemoveItemAsync("UserSession");
        }
        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
    }

    public async Task<string> GetToken()
    {
        var result = string.Empty;
        try
        {
            var userSession = await _sessionStorage.ReadEncryptedItemAsync<AuthSessionToken>("UserSession");
            if (userSession != null)
            {
                result = userSession.AccessToken;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return result;
    }
}
