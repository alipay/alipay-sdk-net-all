using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentProcurementDeliveryInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentProcurementDeliveryInfoVO : AopObject
    {
        /// <summary>
        /// 快递公司ID
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 快递单单号
        /// </summary>
        [XmlElement("waybill_id")]
        public string WaybillId { get; set; }
    }
}
