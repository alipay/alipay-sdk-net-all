using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PricingMode Data Structure.
    /// </summary>
    [Serializable]
    public class PricingMode : AopObject
    {
        /// <summary>
        /// 计费模式
        /// </summary>
        [XmlElement("billing_mode")]
        public string BillingMode { get; set; }

        /// <summary>
        /// 初始化时可为空，单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// QUANTITY 必填：COUNT/POINT
        /// </summary>
        [XmlElement("quota_unit")]
        public string QuotaUnit { get; set; }
    }
}
