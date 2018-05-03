using Microsoft.AspNetCore.Routing;
using ET.Core.Infrastructure.Plugins.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ET.Core.Infrastructure.Plugins
{
    public class PluginRoutes : IPluginRoutes
    {
        private IRouteBuilder _routeBuilder;

        public PluginRoutes(IRouteBuilder routeBuilder)
        {
            _routeBuilder = routeBuilder;
        }

        public IRouteBuilder RouteBuider
        {
            get
            {
                return _routeBuilder;
            }
        }
    }
}
