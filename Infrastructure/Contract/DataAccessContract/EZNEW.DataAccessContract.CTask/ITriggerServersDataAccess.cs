﻿using EZNEW.Develop.DataAccess;
using EZNEW.Entity.CTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.DataAccessContract.CTask
{
    /// <summary>
    /// 服务节点执行计划数据访问接口
    /// </summary>
    public interface ITriggerServerDataAccess : IDataAccess<TriggerServerEntity>
    {
    }

    /// <summary>
    /// 服务节点执行计划数据库接口
    /// </summary>
    public interface ITriggerServerDbAccess : ITriggerServerDataAccess
    {
    }
}
