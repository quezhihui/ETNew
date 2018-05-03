
using ET.Core.Infrastructure.Modules;
using System.Collections.Generic;
using System.Reflection;

namespace ET.Core.Common
{
  public interface IAssemblyProvider
  {
    IEnumerable<Assembly> GetAssemblies(string path);

    IEnumerable<ModuleInfo> GetModules(string path);
    }
}