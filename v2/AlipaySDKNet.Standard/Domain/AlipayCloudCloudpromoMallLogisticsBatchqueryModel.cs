using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallLogisticsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallLogisticsBatchqueryModel : AopObject
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
