using System;
using TechZone.Entities.Abstract;

namespace TechZone.Entities.Concrete.BaseEntity;

public class AuditableEntity : BaseEntity, ICreatedEntity,IUpdatedEntity
{
    public int CreatedUserId { get; set; }
    public DateTime CreatedDate { get; set; }
    public int? UpdatedUserId { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
