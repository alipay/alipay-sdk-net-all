using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommissionRoleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommissionRoleInfo : AopObject
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
        /// 一级/二级
        /// </summary>
        [XmlElement("role_level")]
        public string RoleLevel { get; set; }

        /// <summary>
        /// 抽佣比例
        /// </summary>
        [XmlElement("role_rate")]
        public string RoleRate { get; set; }

        /// <summary>
        /// 角色类型，供应商等
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }
    }
}
