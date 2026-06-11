using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentProcurementOrderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentProcurementOrderCancelModel : AopObject
    {
        /// <summary>
        /// 取消原因码
        /// </summary>
        [XmlElement("cancel_code")]
        public string CancelCode { get; set; }

        /// <summary>
        /// 取消原因描述
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

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
