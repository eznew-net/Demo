using EZNEW.Application.Identity.Auth;
using System;
using Microsoft.AspNetCore.Mvc;

namespace EZNEW.ViewModel.Sys.Response
{
    /// <summary>
    /// 授权操作
    /// </summary>
    public class AuthorityOperationViewModel
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
        [Remote("CheckAuthorityOperationName", "Sys", AdditionalFields = "SysNo,Application.Code", ErrorMessage = "方法名已存在", HttpMethod = "Post")]
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
        public AuthorityOperationGroupViewModel Group
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