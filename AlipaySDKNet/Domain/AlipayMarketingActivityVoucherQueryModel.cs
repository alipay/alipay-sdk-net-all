using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityVoucherQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityVoucherQueryModel : AopObject
    {
        /// <summary>
        /// 活动 id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 商户接入模式。
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }
    }
}
