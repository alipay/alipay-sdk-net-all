using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CancelCommissionRoleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CancelCommissionRoleInfo : AopObject
    {
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
    }
}
