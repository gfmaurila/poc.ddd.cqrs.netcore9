﻿using Common.Core._08.Response;

namespace API.External.Person.Feature.External.ExternalEmail.Create.Model;

public class CreateEmailResponse : BaseResponse
{
    public CreateEmailResponse(CreateEmailResponseModel model) => Model = model;

    public CreateEmailResponseModel Model { get; }
}
