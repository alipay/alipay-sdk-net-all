using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SourceOffer Data Structure.
    /// </summary>
    [Serializable]
    public class SourceOffer : AopObject
    {
        /// <summary>
        /// offerId，根据offer类型对应不同ID。目前支持小程序APPID、营销活动活动编码ID
        /// </summary>
        [XmlElement("offer_id")]
        public string OfferId { get; set; }

        /// <summary>
        /// offer类型。目前仅支持小程序（mini_app/service）、营销活动（voucher）两类。 注意：小程序在发布接口请用mini_app，查询接口返回为service
        /// </summary>
        [XmlElement("offer_type")]
        public string OfferType { get; set; }
    }
}
