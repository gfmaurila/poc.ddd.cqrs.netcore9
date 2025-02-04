﻿namespace API.Exemple1.Core._08.Feature.Domain;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    // Relacionamento
    public ICollection<Feature> Features { get; set; }
}
