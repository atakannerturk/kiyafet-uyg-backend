using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kiyafet_uyg_backend.Enums
{
    public class Enumaration
    {
        public enum UserType
        {
            SuperAdmin,
            Admin,
            Users,
        }

        public enum UserState
        {
            WaitingActivation,
            Active,
            Passive
        }
    }
}

