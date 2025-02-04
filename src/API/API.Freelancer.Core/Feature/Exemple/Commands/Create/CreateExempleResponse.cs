﻿using Common.Core._08.Response;

namespace API.Freelancer.Core.Feature.Exemple.Commands.Create;


public class CreateExempleResponse : BaseResponse
{
    public CreateExempleResponse(Guid id) => Id = id;

    public Guid Id { get; }
}

