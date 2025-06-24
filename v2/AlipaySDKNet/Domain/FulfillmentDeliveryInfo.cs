using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentDeliveryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentDeliveryInfo : AopObject
    {
        /// <summary>
        /// 请查看<a href="https://opendocs.alipay.com/mini/07hva0?pathHash=5de3c48d">快递公司ID列表</a>，请确认传入的值在此列表内，若发货的快递公司不在此列表内，可以传入值other
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 快递单单号，例如EMS的单号8125658724208
        /// </summary>
        [XmlElement("waybill_id")]
        public string WaybillId { get; set; }
    }
}
