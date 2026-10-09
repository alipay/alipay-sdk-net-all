using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsOrderModifyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsOrderModifyDTO : AopObject
    {
        /// <summary>
        /// 快递公司标识
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 原始物流公司标识
        /// </summary>
        [XmlElement("original_delivery_id")]
        public string OriginalDeliveryId { get; set; }

        /// <summary>
        /// 原始物流单号
        /// </summary>
        [XmlElement("original_waybill_id")]
        public string OriginalWaybillId { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("waybill_id")]
        public string WaybillId { get; set; }
    }
}
