﻿using API.Exemple.Core._08.Feature.Domain.Exemple.Events;
using API.Exemple.Core._08.Feature.Domain.Exemple.Models;
using API.Exemple.Core._08.Feature.Exemple.Get;
using API.Exemple.Core._08.Infrastructure.Database.Repositories.Interfaces;
using Common.Core._08.Interface;
using MediatR;

namespace API.Exemple.Core._08.Feature.Exemple.Create.Events;

public class ExempleCreateEventHandler : INotificationHandler<ExempleCreatedEvent>
{
    private readonly ILogger<ExempleCreateEventHandler> _logger;
    private readonly IExempleRepository _repo;
    private readonly IRedisCacheService<List<ExempleQueryModel>> _cacheService;
    public ExempleCreateEventHandler(ILogger<ExempleCreateEventHandler> logger,
                                      IExempleRepository repo,
                                      IRedisCacheService<List<ExempleQueryModel>> cacheService)
    {
        _logger = logger;
        _repo = repo;
        _cacheService = cacheService;
    }

    public async Task Handle(ExempleCreatedEvent notification, CancellationToken cancellationToken)
    {
        const string cacheKey = nameof(GetExempleQuery);
        await _cacheService.DeleteAsync(cacheKey);
        await _cacheService.GetOrCreateAsync(cacheKey, _repo.GetAllAsync, TimeSpan.FromHours(2));
    }
}