using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTaxAdvancedPayResponse.
    /// </summary>
    public class AlipayOverseasTaxAdvancedPayResponse : AopResponse
    {
        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付宝退税资金订单号
        /// </summary>
        [XmlElement("tax_refund_no")]
        public string TaxRefundNo { get; set; }
    }
}
