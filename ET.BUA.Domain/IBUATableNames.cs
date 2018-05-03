/*******************************************************************************
* 命名空间: ET.BUA.Domain
*
* 功 能： N/A
* 类 名： ICoreTableNames
*
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2016/12/13 12:20:49 疯狂蚂蚁 初版
*
* Copyright (c) 2016 SimpleFramework 版权所有
* Description: SimpleFramework快速开发平台
* Website：http://www.mayisite.com
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ET.BUA.Domain
{
    public interface IBUATableNames
    {
        string ApplicationTableName { get; }
    }
}
