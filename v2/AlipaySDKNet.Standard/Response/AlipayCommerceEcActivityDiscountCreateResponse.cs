using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcActivityDiscountCreateResponse.
    /// </summary>
    public class AlipayCommerceEcActivityDiscountCreateResponse : AopResponse
    {
        /// <summary>
        /// 企业码立减活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
