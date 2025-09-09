using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallOrderConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallOrderConsultModel : AopObject
    {
        /// <summary>
        /// 采购单id
        /// </summary>
        [XmlElement("purchase_order_id")]
        public string PurchaseOrderId { get; set; }
    }
}
