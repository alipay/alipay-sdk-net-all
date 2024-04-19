using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersaleLogisticsInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AftersaleLogisticsInfoDTO : AopObject
    {
        /// <summary>
        /// 快递公司ID, 快递公司ID列表请查看：https://opendocs.alipay.com/mini/07hva0?pathHash=5de3c48d，请确认传入的值在此列表内，若发货的快递公司不在此列表内，可以传入值other
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
