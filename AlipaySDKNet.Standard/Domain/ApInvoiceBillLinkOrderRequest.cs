using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApInvoiceBillLinkOrderRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ApInvoiceBillLinkOrderRequest : AopObject
    {
        /// <summary>
        /// 开票金额，金额为null或为0均视为未填关联金额
        /// </summary>
        [XmlElement("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

        /// <summary>
        /// 日账单选择维度 map
        /// </summary>
        [XmlElement("daily_bill_dimension")]
        public string DailyBillDimension { get; set; }

        /// <summary>
        /// 可开票对账单号
        /// </summary>
        [XmlElement("monthly_bill_no")]
        public string MonthlyBillNo { get; set; }
    }
}
