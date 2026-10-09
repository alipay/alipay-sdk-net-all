using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayNowpayChargeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayNowpayChargeModifyModel : AopObject
    {
        /// <summary>
        /// 修改类型，ENABLE/DISABLE
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

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
    }
}
