using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DetailCommissionRoleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DetailCommissionRoleInfo : AopObject
    {
        /// <summary>
        /// 最新抽佣信息
        /// </summary>
        [XmlElement("latest_commission")]
        public LatestCommissionInfo LatestCommission { get; set; }

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
        /// 角色确认链接，角色确认阶段时才有
        /// </summary>
        [XmlElement("role_confirm_url")]
        public string RoleConfirmUrl { get; set; }

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
        /// 角色状态
        /// </summary>
        [XmlElement("role_status")]
        public string RoleStatus { get; set; }

        /// <summary>
        /// 角色类型，供应商等
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }
    }
}
