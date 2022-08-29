using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityQueryModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 商户接入模式。
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 商户PID,默认为当前接口调用商户。
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
