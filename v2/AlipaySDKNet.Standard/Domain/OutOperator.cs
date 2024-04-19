using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutOperator Data Structure.
    /// </summary>
    [Serializable]
    public class OutOperator : AopObject
    {
        /// <summary>
        /// 已经授权的权限码列表
        /// </summary>
        [XmlArray("authed_role_codes")]
        [XmlArrayItem("string")]
        public List<string> AuthedRoleCodes { get; set; }

        /// <summary>
        /// 联系邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        [XmlElement("logon_name")]
        public string LogonName { get; set; }

        /// <summary>
        /// 操作员Id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 账号id
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }
    }
}
