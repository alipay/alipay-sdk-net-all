using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryReceiveDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryReceiveDTO : AopObject
    {
        /// <summary>
        /// 物流单id
        /// </summary>
        [XmlElement("logistics_order_id")]
        public string LogisticsOrderId { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("waybill_id")]
        public string WaybillId { get; set; }
    }
}
