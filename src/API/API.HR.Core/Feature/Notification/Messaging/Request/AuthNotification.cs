﻿namespace API.HR.Core.Feature.Notification.Messaging.Request;

public class AuthNotification
{
    public string AccountSid { get; set; }
    public string AuthToken { get; set; }
    public string From { get; set; }
}
