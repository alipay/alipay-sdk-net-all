using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTaxAdvancedUnfreezeResponse.
    /// </summary>
    public class AlipayOverseasTaxAdvancedUnfreezeResponse : AopResponse
    {
        /// <summary>
        /// 支付宝退税资金订单号
        /// </summary>
        [XmlElement("tax_refund_no")]
        public string TaxRefundNo { get; set; }
    }
}
