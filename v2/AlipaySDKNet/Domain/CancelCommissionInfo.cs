using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CancelCommissionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CancelCommissionInfo : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("commission_role_list")]
        [XmlArrayItem("cancel_commission_role_info")]
        public List<CancelCommissionRoleInfo> CommissionRoleList { get; set; }

        /// <summary>
        /// 是否修改服务商规则
        /// </summary>
        [XmlElement("modify_isv_rule")]
        public bool ModifyIsvRule { get; set; }

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
