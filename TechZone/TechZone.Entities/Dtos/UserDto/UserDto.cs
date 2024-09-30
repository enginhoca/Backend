using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechZone.Entities.Abstract;

namespace TechZone.Entities.Dtos.UserDto
{
    public class UserDto:IDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public bool gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
    }
}