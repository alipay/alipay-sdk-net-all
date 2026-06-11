using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentProcurementOrderCancelResponse.
    /// </summary>
    public class AlipayCommerceRentProcurementOrderCancelResponse : AopResponse
    {
        /// <summary>
        /// 取消状态：APPROVING（审核中）、SUCCESS（成功）、FAIL（失败）
        /// </summary>
        [XmlElement("cancel_status")]
        public string CancelStatus { get; set; }

        /// <summary>
        /// 供应链采购单号
        /// </summary>
        [XmlElement("procurement_order_id")]
        public string ProcurementOrderId { get; set; }
    }
}
