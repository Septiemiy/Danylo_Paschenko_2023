using LiskovSubstitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class UsersRole : IWorkWithUsers
    {
        public Guid CheckRole(Guid role)
        {
            if (role != Guid.Empty) return role;

            return Guid.Empty;
        }

        public Guid CheckUser(Guid user)
        {
            return CheckRole(user);
        }
    }
}
