using System;

namespace TechZone.Entities.Abstract;

public interface IDisplayEntity
{
    int DisplayOrder {get; set;}
    public bool IsDisplay { get; set; }
}
