using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NatrualPersonInvoiceAmountMonthly Data Structure.
    /// </summary>
    [Serializable]
    public class NatrualPersonInvoiceAmountMonthly : AopObject
    {
        /// <summary>
        /// 月累计开票总金额，单位：元
        /// </summary>
        [XmlElement("invoice_total_amount_monthly")]
        public string InvoiceTotalAmountMonthly { get; set; }

        /// <summary>
        /// 开票统计月份
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }
    }
}
