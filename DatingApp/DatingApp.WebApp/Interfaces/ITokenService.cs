using DatingApp.WebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.WebApp.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
