using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace FirstASP.NETPorject.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}