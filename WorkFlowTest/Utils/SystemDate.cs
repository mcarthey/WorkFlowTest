using System;

namespace WorkFlowTest.Utils
{
    public class SystemDate : ISystemDate
    {
        public DateTime Now => DateTime.Now;
    }
}
