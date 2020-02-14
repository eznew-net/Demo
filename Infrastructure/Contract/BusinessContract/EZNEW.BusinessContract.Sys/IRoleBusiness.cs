using EZNEW.Develop.CQuery;
using EZNEW.Framework.Paging;
using EZNEW.DTO.Sys.Cmd;
using EZNEW.DTO.Sys.Query;
using EZNEW.DTO.Sys.Query.Filter;
using EZNEW.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZNEW.Framework.Response;

namespace EZNEW.BusinessContract.Sys
{
    /// <summary>
    /// 角色业务接口
    /// </summary>
    public interface IRoleBusiness
    {
        #region 保存角色

        /// <summary>
        /// 保存角色
        /// </summary>
        /// <param name="saveInfo">保存信息</param>
        /// <returns></returns>
        Result<RoleDto> SaveRole(SaveRoleCmdDto saveInfo);

        #endregion

        #region 获取角色

        /// <summary>
        /// 获取角色
        /// </summary>
        /// <param name="filter">查询对象</param>
        /// <returns></returns>
        RoleDto GetRole(RoleFilterDto filter);

        #endregion

        #region 删除角色

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="deleteInfo">删除信息</param>
        /// <returns>执行结果</returns>
        Result DeleteRole(DeleteRoleCmdDto deleteInfo);

        #endregion

        #region 获取角色列表

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="filter">查询对象</param>
        /// <returns></returns>
        List<RoleDto> GetRoleList(RoleFilterDto filter);

        #endregion

        #region 获取角色分页

        /// <summary>
        /// 获取Role分页
        /// </summary>
        /// <param name="filter">查询对象</param>
        /// <returns></returns>
        IPaging<RoleDto> GetRolePaging(RoleFilterDto filter);

        #endregion

        #region 修改角色排序

        /// <summary>
        /// 修改角色排序
        /// </summary>
        /// <param name="sortIndexInfo">排序修改信息</param>
        /// <returns></returns>
        Result ModifyRoleSortIndex(ModifyRoleSortCmdDto sortIndexInfo);

        #endregion

        #region 验证角色名称是否存在

        /// <summary>
        /// 验证角色名称是否存在
        /// </summary>
        /// <param name="existInfo">验证信息</param>
        /// <returns></returns>
        bool ExistRoleName(ExistRoleNameCmdDto existInfo);

        #endregion

        #region 根据查询条件生成查询对象

        /// <summary>
        /// 根据查询条件生成查询对象
        /// </summary>
        /// <param name="filter">查询条件</param>
        /// <returns></returns>
        IQuery CreateQueryObject(RoleFilterDto filter);

        #endregion
    }
}
