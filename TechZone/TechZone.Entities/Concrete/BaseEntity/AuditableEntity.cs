using System;
using TechZone.Entities.Abstract;

namespace TechZone.Entities.Concrete.BaseEntity;

public class AuditableEntity : BaseEntity, ICreatedEntity,IUpdatedEntity
{
    public int CreatedUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int? UpdatedUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DateTime? UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
