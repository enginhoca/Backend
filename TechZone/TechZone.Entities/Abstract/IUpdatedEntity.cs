using System;

namespace TechZone.Entities.Abstract;

public interface IUpdatedEntity
{
public int? UpdatedUserId { get; set; }
public DateTime? UpdatedDate { get; set; }
}
