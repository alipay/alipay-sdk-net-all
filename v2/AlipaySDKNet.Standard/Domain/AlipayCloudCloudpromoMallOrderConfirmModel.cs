using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallOrderConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallOrderConfirmModel : AopObject
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 采购单号
        /// </summary>
        [XmlElement("purchase_order_id")]
        public string PurchaseOrderId { get; set; }
    }
}
