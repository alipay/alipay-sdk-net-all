using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentProcurementOrderModifyResponse.
    /// </summary>
    public class AlipayCommerceRentProcurementOrderModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改状态
        /// </summary>
        [XmlElement("modify_status")]
        public string ModifyStatus { get; set; }

        /// <summary>
        /// 平台采购订单ID
        /// </summary>
        [XmlElement("procurement_order_id")]
        public string ProcurementOrderId { get; set; }
    }
}
