﻿using API.HR.Core.Feature.Domain.Exemple.Models;
using API.HR.Core.Feature.Exemple.Commands.Update;

namespace API.HR.Core.Feature.Domain.Exemple.Events.Messaging;

/// <summary>
/// Represents an event triggered when an Exemple entity is updated.
/// </summary>
public class ExempleUpdateEvent : ExempleBaseEvent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExempleUpdateEvent"/> class.
    /// </summary>
    /// <param name="id">The unique identifier of the updated Exemple entity.</param>
    /// <param name="request">The command containing the updated data of the Exemple entity.</param>
    /// <param name="model">The model containing audit information for the update.</param>
    public ExempleUpdateEvent(Guid id,
                              UpdateExempleCommand request,
                              AuthExempleCreateUpdateDeleteModel model)
        : base(id, request.FirstName, request.LastName, request.Gender, request.Notification, request.Email, request.Phone, request.Role, request.Status, model)
    {
        AggregateId = Guid.NewGuid();
        MessageType = nameof(ExempleUpdateEvent);
    }
}
