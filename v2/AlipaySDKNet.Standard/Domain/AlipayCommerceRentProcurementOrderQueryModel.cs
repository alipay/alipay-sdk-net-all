using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentProcurementOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentProcurementOrderQueryModel : AopObject
    {
        /// <summary>
        /// 商户外部采购单号（与procurement_order_id二选一）
        /// </summary>
        [XmlElement("out_procurement_order_id")]
        public string OutProcurementOrderId { get; set; }

        /// <summary>
        /// 供应链采购单号（与out_procurement_order_id二选一）
        /// </summary>
        [XmlElement("procurement_order_id")]
        public string ProcurementOrderId { get; set; }
    }
}
