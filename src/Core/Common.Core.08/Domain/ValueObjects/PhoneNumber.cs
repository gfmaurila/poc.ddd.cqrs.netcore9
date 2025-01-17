﻿namespace Common.Core._08.Domain.ValueObjects;

public class PhoneNumber : ValueObject
{
    public PhoneNumber(string phone)
        => Phone = phone.Trim().ToLowerInvariant();

    private PhoneNumber() { } // ORM

    public string Phone { get; private init; }

    public override string ToString() => Phone;

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Phone;
    }
}
