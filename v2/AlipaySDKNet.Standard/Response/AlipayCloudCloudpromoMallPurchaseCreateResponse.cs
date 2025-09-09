using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallPurchaseCreateResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallPurchaseCreateResponse : AopResponse
    {
        /// <summary>
        /// 采购单id
        /// </summary>
        [XmlElement("purchase_order_id")]
        public string PurchaseOrderId { get; set; }
    }
}
