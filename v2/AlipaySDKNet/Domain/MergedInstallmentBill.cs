using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MergedInstallmentBill Data Structure.
    /// </summary>
    [Serializable]
    public class MergedInstallmentBill : AopObject
    {
        /// <summary>
        /// 会计日
        /// </summary>
        [XmlElement("accounting_date")]
        public string AccountingDate { get; set; }

        /// <summary>
        /// 合并账单的还款日。到期、未来期的时候需要返回（格式yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("installment_end_date")]
        public string InstallmentEndDate { get; set; }

        /// <summary>
        /// 应还利息，单位元，保留两位小数
        /// </summary>
        [XmlElement("unpaid_interest")]
        public string UnpaidInterest { get; set; }

        /// <summary>
        /// 应还罚息，单位元，保留2位小数
        /// </summary>
        [XmlElement("unpaid_penalty")]
        public string UnpaidPenalty { get; set; }

        /// <summary>
        /// 应还本金，单位元，保留小数点后两位
        /// </summary>
        [XmlElement("unpaid_principal")]
        public string UnpaidPrincipal { get; set; }

        /// <summary>
        /// 应还总金额，单位元，保留小数点后两位
        /// </summary>
        [XmlElement("unpaid_total_amount")]
        public string UnpaidTotalAmount { get; set; }
    }
}
