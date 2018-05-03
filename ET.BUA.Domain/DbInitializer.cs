using System;
using System.Linq;

namespace ET.BUA.Domain
{
    public static class DbInitializer
    {
        public static void Initialize(BUAContext context)
        {
            context.Database.EnsureCreated();

            if (context.app.Any())
            {
                return;
            }
        }
    }
}