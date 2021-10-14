using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Enums
{
    class Enumaration
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
