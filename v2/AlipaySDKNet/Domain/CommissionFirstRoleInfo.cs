using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommissionFirstRoleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommissionFirstRoleInfo : AopObject
    {
        /// <summary>
        /// 合作伙伴支付宝账号名称
        /// </summary>
        [XmlElement("role_account_name")]
        public string RoleAccountName { get; set; }

        /// <summary>
        /// 合作伙伴支付宝账号
        /// </summary>
        [XmlElement("role_alipay_account")]
        public string RoleAlipayAccount { get; set; }

        /// <summary>
        /// 角色抽佣比例，无单位。如0.0400表示为4%的抽佣比例
        /// </summary>
        [XmlElement("role_rate")]
        public string RoleRate { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }
    }
}
