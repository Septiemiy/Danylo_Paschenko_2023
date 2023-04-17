using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Owner : Administrator
    {
        public bool RoleChecking()
        {
            var role = CheckUser(new Guid());

            if (role == Guid.Empty) return false;

            return true;
        }
    }
}
