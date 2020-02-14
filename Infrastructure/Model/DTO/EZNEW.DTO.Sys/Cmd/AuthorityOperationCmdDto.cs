using EZNEW.Application.Identity.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.DTO.Sys.Cmd
{
    /// <summary>
    /// 授权操作命令信息
    /// </summary>
    public class AuthorityOperationCmdDto
    {
        #region	属性

        /// <summary>
        /// 主键编号
        /// </summary>
        public long SysNo
        {
            get;
            set;
        }

        /// <summary>
        /// 控制器
        /// </summary>
        public string ControllerCode
        {
            get;
            set;
        }

        /// <summary>
        /// 操作方法
        /// </summary>
        public string ActionCode
        {
            get;
            set;
        }

        /// <summary>
        /// 操作类型
        /// </summary>
        public AuthorityOperationMethod Method
        {
            get;
            set;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 状态
        /// </summary>
        public AuthorityOperationStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort
        {
            get;
            set;
        }

        /// <summary>
        /// 操作分组
        /// </summary>
        public AuthorityOperationGroupCmdDto Group
        {
            get;
            set;
        }

        /// <summary>
        /// 授权类型
        /// </summary>
        public AuthorityOperationAuthorizeType AuthorizeType
        {
            get;
            set;
        }

        /// <summary>
        /// 方法描述
        /// </summary>
        public string Remark
        {
            get;
            set;
        }

        #endregion
    }
}
