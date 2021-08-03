using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceBillLinkOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceBillLinkOrderDTO : AopObject
    {
        /// <summary>
        /// 账单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 关联金额
        /// </summary>
        [XmlElement("relate_amount")]
        public MultiCurrencyMoneyOpenApi RelateAmount { get; set; }

        /// <summary>
        /// 关联到账单上的税额
        /// </summary>
        [XmlElement("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }
    }
}
