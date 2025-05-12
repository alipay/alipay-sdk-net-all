using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommissionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommissionInfo : AopObject
    {
        /// <summary>
        /// 角色列表
        /// </summary>
        [XmlArray("commission_role_list")]
        [XmlArrayItem("commission_role_info")]
        public List<CommissionRoleInfo> CommissionRoleList { get; set; }

        /// <summary>
        /// 抽佣比例
        /// </summary>
        [XmlElement("isv_rate")]
        public string IsvRate { get; set; }

        /// <summary>
        /// 目标id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商家
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
