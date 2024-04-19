using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceAmountLimitDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceAmountLimitDTO : AopObject
    {
        /// <summary>
        /// 单张发票限额
        /// </summary>
        [XmlElement("amount_limit")]
        public string AmountLimit { get; set; }

        /// <summary>
        /// 发票类型，可选值：电子发票：0，纸质普票：1，纸质专票：2
        /// </summary>
        [XmlElement("invoice_kind")]
        public long InvoiceKind { get; set; }

        /// <summary>
        /// 月发票限额
        /// </summary>
        [XmlElement("month_amount_limit")]
        public string MonthAmountLimit { get; set; }
    }
}
