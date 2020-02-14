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
    /// 任务执行日志数据访问接口
    /// </summary>
    public interface IExecuteLogDataAccess : IDataAccess<ExecuteLogEntity>
    {
    }

    /// <summary>
    /// 任务执行日志数据库接口
    /// </summary>
    public interface IExecuteLogDbAccess : IExecuteLogDataAccess
    {
    }
}
