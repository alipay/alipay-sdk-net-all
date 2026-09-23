using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayNowpayQuotaRefreshModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayNowpayQuotaRefreshModel : AopObject
    {
        /// <summary>
        /// 权益受益人
        /// </summary>
        [XmlElement("external_buyer_id")]
        public string ExternalBuyerId { get; set; }

        /// <summary>
        /// 商品所有者
        /// </summary>
        [XmlElement("external_owner_id")]
        public string ExternalOwnerId { get; set; }

        /// <summary>
        /// 商品/应用标识
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// 核销幂等号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
