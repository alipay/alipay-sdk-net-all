using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupPromotionurlQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupPromotionurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 群组推广链接
        /// </summary>
        [XmlElement("promotion_url")]
        public string PromotionUrl { get; set; }
    }
}
