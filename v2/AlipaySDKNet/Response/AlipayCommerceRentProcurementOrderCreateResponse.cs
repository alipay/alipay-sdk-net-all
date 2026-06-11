using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentProcurementOrderCreateResponse.
    /// </summary>
    public class AlipayCommerceRentProcurementOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 商户外部采购单号
        /// </summary>
        [XmlElement("out_procurement_order_id")]
        public string OutProcurementOrderId { get; set; }

        /// <summary>
        /// 平台供应链采购单号
        /// </summary>
        [XmlElement("procurement_order_id")]
        public string ProcurementOrderId { get; set; }
    }
}
