using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LeaseSkuOfferDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LeaseSkuOfferDTO : AopObject
    {
        /// <summary>
        /// 租赁商下单跳转地址
        /// </summary>
        [XmlElement("lessor_path")]
        public string LessorPath { get; set; }

        /// <summary>
        /// 租赁商skuid
        /// </summary>
        [XmlElement("lessor_sku_id")]
        public string LessorSkuId { get; set; }

        /// <summary>
        /// 出价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 规格ID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 状态 Confirmed、Unconfirmed
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
