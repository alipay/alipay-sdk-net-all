using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LeasePlanOfferDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LeasePlanOfferDTO : AopObject
    {
        /// <summary>
        /// 租赁下单跳转地址
        /// </summary>
        [XmlElement("lessor_path")]
        public string LessorPath { get; set; }

        /// <summary>
        /// 租赁商pid
        /// </summary>
        [XmlElement("lessor_pid")]
        public string LessorPid { get; set; }

        /// <summary>
        /// 报价时间
        /// </summary>
        [XmlElement("offer_time")]
        public string OfferTime { get; set; }

        /// <summary>
        /// sku最低价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 规格id
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
