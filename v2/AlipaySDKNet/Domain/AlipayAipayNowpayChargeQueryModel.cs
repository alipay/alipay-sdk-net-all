using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayNowpayChargeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayNowpayChargeQueryModel : AopObject
    {
        /// <summary>
        /// 商品所有者标识
        /// </summary>
        [XmlElement("external_owner_id")]
        public string ExternalOwnerId { get; set; }

        /// <summary>
        /// 观猹商品/应用标识
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }
    }
}
