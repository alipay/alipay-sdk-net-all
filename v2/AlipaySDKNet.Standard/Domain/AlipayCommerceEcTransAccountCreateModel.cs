using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcTransAccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcTransAccountCreateModel : AopObject
    {
        /// <summary>
        /// 账户类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 应用场景码
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
