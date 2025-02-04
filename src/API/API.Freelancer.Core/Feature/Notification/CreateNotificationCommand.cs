﻿using Common.Core._08.Domain.Enumerado;
using Common.Core._08.Response;
using MediatR;

namespace API.Freelancer.Core.Feature.Notification;

public record CreateNotificationCommand(
    ENotificationType Notification, string From, string Body, string To
) : IRequest<ApiResult<CreateNotificationResponse>>;

