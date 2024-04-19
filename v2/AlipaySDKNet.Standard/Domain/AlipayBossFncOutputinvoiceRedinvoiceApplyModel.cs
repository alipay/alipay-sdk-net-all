using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncOutputinvoiceRedinvoiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncOutputinvoiceRedinvoiceApplyModel : AopObject
    {
        /// <summary>
        /// 国际发票红冲申请模型
        /// </summary>
        [XmlElement("output_invoice_red_apply")]
        public OutputInvoiceRedApplyVO OutputInvoiceRedApply { get; set; }
    }
}
