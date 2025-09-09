using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LendInstallment Data Structure.
    /// </summary>
    [Serializable]
    public class LendInstallment : AopObject
    {
        /// <summary>
        /// 分期结束时间
        /// </summary>
        [XmlElement("installment_end_date")]
        public string InstallmentEndDate { get; set; }

        /// <summary>
        /// 分期期次
        /// </summary>
        [XmlElement("installment_no")]
        public long InstallmentNo { get; set; }

        /// <summary>
        /// 分期结清时间
        /// </summary>
        [XmlElement("settle_time")]
        public string SettleTime { get; set; }

        /// <summary>
        /// 该期次贷款状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 该期剩余应还利息，单位元，保留两位小数
        /// </summary>
        [XmlElement("unpaid_interest")]
        public string UnpaidInterest { get; set; }

        /// <summary>
        /// 该期剩余应还罚息
        /// </summary>
        [XmlElement("unpaid_penalty")]
        public string UnpaidPenalty { get; set; }

        /// <summary>
        /// 该期剩余应还本金
        /// </summary>
        [XmlElement("unpaid_principal")]
        public string UnpaidPrincipal { get; set; }
    }
}
