using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentFulfillmentDeliveryInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentFulfillmentDeliveryInfoVO : AopObject
    {
        /// <summary>
        /// 快递公司ID。<a href="https://opendocs.alipay.com/mini/07hva0?pathHash=5de3c48d">快递公司ID列表</a>
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("waybill_id")]
        public string WaybillId { get; set; }
    }
}
