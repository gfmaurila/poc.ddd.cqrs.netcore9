﻿using API.External.Person.Feature.Domain.Common;
using API.External.Person.Infrastructure.Messaging;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace API.External.Person.Feature.Exemple.Commands.Delete.Events.Messaging.Subscribe;

/// <summary>
/// Background service that subscribes to a RabbitMQ queue and processes Exemple deletion events.
/// </summary>
public class DeleteExempleSubscribe : BackgroundService
{
    private readonly IConnection _connection;
    private readonly IConfiguration _configuration;
    private readonly IModel _channel;

    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteExempleSubscribe"/> class.
    /// </summary>
    /// <param name="servicesProvider">Service provider instance for dependency injection.</param>
    /// <param name="configuration">Configuration instance for retrieving RabbitMQ settings.</param>
    public DeleteExempleSubscribe(IServiceProvider servicesProvider, IConfiguration configuration)
    {
        _configuration = configuration;

        var factory = new ConnectionFactory
        {
            HostName = _configuration.GetValue<string>(MessagingConsts.Hostname),
            Port = Convert.ToInt32(_configuration.GetValue<string>(MessagingConsts.Port)),
            UserName = _configuration.GetValue<string>(MessagingConsts.Username),
            Password = _configuration.GetValue<string>(MessagingConsts.Password)
        };

        _connection = factory.CreateConnection();
        _channel = _connection.CreateModel();

        _channel.QueueDeclare(
            queue: ExempleEventConstants.EventExempleDelete,
            durable: false,
            exclusive: false,
            autoDelete: false,
            arguments: null);
    }

    /// <summary>
    /// Executes the RabbitMQ consumer, listening for incoming messages asynchronously.
    /// </summary>
    /// <param name="stoppingToken">Cancellation token to handle graceful shutdown.</param>
    /// <returns>A completed task.</returns>
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var consumer = new EventingBasicConsumer(_channel);
        consumer.Received += async (sender, eventArgs) =>
        {
            var infoBytes = eventArgs.Body.ToArray();
            var infoJson = Encoding.UTF8.GetString(infoBytes);
            var info = JsonSerializer.Deserialize<ExempleConsumer>(infoJson);

            await SendNotification(info);

            _channel.BasicAck(eventArgs.DeliveryTag, false);
        };

        _channel.BasicConsume(ExempleEventConstants.EventExempleDelete, false, consumer);

        return Task.CompletedTask;
    }

    /// <summary>
    /// Processes the received event by handling the Exemple entity deletion notification.
    /// </summary>
    /// <param name="dto">The received event data.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task SendNotification(ExempleConsumer dto)
    {
        // Implement the logic for handling the received deletion event.
    }
}
