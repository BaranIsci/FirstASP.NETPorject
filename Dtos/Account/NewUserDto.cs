using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASP.NETPorject.Dtos.Account
{
    public class NewUserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string token { get; set; }
        
    }
}