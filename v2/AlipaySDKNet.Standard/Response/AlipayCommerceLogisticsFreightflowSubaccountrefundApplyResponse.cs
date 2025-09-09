using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowSubaccountrefundApplyResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowSubaccountrefundApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请是否成功
        /// </summary>
        [XmlElement("accepted_refund")]
        public bool AcceptedRefund { get; set; }
    }
}
