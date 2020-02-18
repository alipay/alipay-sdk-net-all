using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTaxOrderPayResponse.
    /// </summary>
    public class AlipayOverseasTaxOrderPayResponse : AopResponse
    {
        /// <summary>
        /// 支付宝的退税流水号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
