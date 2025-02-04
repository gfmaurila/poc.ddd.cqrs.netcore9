﻿using Common.Core._08.Response;
using MediatR;

namespace API.External.Person.Feature.Exemple.Commands.Delete;

public record DeleteExempleCommand(Guid Id) : IRequest<ApiResult<DeleteExempleResponse>>;


