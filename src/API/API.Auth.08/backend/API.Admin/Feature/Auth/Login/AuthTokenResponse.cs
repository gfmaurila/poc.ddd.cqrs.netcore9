﻿using Common.Net8;

namespace API.Auth.Net08.Feature.Auth.Login;

public class AuthTokenResponse : BaseResponse
{
    public AuthTokenResponse(string token)
    {
        Token = token;
    }
    public string Token { get; }
}
