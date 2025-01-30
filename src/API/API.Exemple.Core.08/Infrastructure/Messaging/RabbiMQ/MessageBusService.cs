﻿using API.Exemple1.Core._08.Infrastructure.Messaging;
using Common.Core._08.Interface;
using RabbitMQ.Client;

namespace API.Exemple.Core._08.Infrastructure.Messaging.RabbiMQ;

public class MessageBusService : IMessageBusService
{
    private readonly ConnectionFactory _connectionFactory;
    private readonly IConfiguration _configuration;

    public MessageBusService(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionFactory = new ConnectionFactory
        {
            HostName = _configuration.GetValue<string>(MessagingConsts.Hostname),
            Port = Convert.ToInt32(_configuration.GetValue<string>(MessagingConsts.Port)),
            UserName = _configuration.GetValue<string>(MessagingConsts.Username),
            Password = _configuration.GetValue<string>(MessagingConsts.Password)
        };
    }

    public void Publish(string queue, byte[] message)
    {
        using var connection = _connectionFactory.CreateConnection();
        using var channel = connection.CreateModel();
        channel.QueueDeclare(
                queue: queue,
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

        channel.BasicPublish(
            exchange: "",
            routingKey: queue,
            basicProperties: null,
            body: message);
    }
}
