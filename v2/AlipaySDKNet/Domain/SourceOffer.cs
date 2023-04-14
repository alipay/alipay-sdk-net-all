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
        /// offerId，根据offer类型对应不同ID。支持小程序的APPID/小程序服务的服务编码/优惠券的活动ID
        /// </summary>
        [XmlElement("offer_id")]
        public string OfferId { get; set; }

        /// <summary>
        /// offer类型。目前仅支持小程序（mini_app/service）、小程序服务（subservice）、营销活动（voucher）、商品(goods)。 注意：其中“小程序”offer类型，在发布接口请用mini_app，查询接口返回为service
        /// </summary>
        [XmlElement("offer_type")]
        public string OfferType { get; set; }
    }
}
