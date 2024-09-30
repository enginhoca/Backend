using System;
using TechZone.DataAccess.Abstract;
using TechZone.DataAccess.Concrete.Context;
using TechZone.Entities.Concrete;

namespace TechZone.DataAccess.Concrete.EntityFramework;

public class EfUserDal : EfBaseRepository<User,TechZoneAPIContext>, IUserDal
{

}
