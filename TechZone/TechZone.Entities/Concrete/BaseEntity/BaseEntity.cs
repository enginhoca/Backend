using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechZone.Entities.Abstract;

namespace TechZone.Entities.Concrete.BaseEntity
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}