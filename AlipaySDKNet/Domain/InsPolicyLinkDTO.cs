using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsPolicyLinkDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsPolicyLinkDTO : AopObject
    {
        /// <summary>
        /// 授权token
        /// </summary>
        [XmlElement("authed_token")]
        public string AuthedToken { get; set; }

        /// <summary>
        /// 已授权的保单url
        /// </summary>
        [XmlElement("authed_url")]
        public string AuthedUrl { get; set; }

        /// <summary>
        /// url过期时间
        /// </summary>
        [XmlElement("expiration")]
        public string Expiration { get; set; }

        /// <summary>
        /// 保单状态
        /// </summary>
        [XmlElement("policy_status")]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品图标
        /// </summary>
        [XmlElement("product_icon")]
        public string ProductIcon { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 产品方案id
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }
    }
}
