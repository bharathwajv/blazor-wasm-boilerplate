﻿namespace FSH.BlazorWebAssembly.Client.Infrastructure.Authentication;
public class AuthenticationHeaderHandler : DelegatingHandler
{
    private readonly ILocalStorageService _localStorage;

    public AuthenticationHeaderHandler(ILocalStorageService localStorage) => this._localStorage = localStorage;

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        if (request.Headers.Authorization?.Scheme != "Bearer")
        {
            string savedToken = await this._localStorage.GetItemAsync<string>(StorageConstants.Local.AuthToken);

            if (!string.IsNullOrWhiteSpace(savedToken))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", savedToken);
            }
        }

        return await base.SendAsync(request, cancellationToken);
    }
}