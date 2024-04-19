using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTaxAdvancedUnfreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTaxAdvancedUnfreezeModel : AopObject
    {
        /// <summary>
        /// 支付宝退税资金订单号
        /// </summary>
        [XmlElement("tax_refund_no")]
        public string TaxRefundNo { get; set; }
    }
}
