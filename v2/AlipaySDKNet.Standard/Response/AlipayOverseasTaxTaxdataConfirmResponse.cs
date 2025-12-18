using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTaxTaxdataConfirmResponse.
    /// </summary>
    public class AlipayOverseasTaxTaxdataConfirmResponse : AopResponse
    {
        /// <summary>
        /// 退税支付宝流水号
        /// </summary>
        [XmlElement("refund_order_no")]
        public string RefundOrderNo { get; set; }
    }
}
