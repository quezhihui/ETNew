﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ET.Core.Infrastructure.Modules.Builder
{
    public interface IModuleConfigBuilder
    {     
        Task<ModuleConfig> BuildConfig(string filePath);
    }
}
