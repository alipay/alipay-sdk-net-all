using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTaxAdvancedStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTaxAdvancedStatusQueryModel : AopObject
    {
        /// <summary>
        /// 退税机构业务流水号，唯一，只能包含字母、数字
        /// </summary>
        [XmlElement("out_tax_refund_no")]
        public string OutTaxRefundNo { get; set; }
    }
}
