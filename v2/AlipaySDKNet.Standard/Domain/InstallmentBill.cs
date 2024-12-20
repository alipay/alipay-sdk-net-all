using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstallmentBill Data Structure.
    /// </summary>
    [Serializable]
    public class InstallmentBill : AopObject
    {
        /// <summary>
        /// 合并分期到期日
        /// </summary>
        [XmlElement("installment_end_date")]
        public string InstallmentEndDate { get; set; }

        /// <summary>
        /// 分期信息
        /// </summary>
        [XmlArray("installment_list")]
        [XmlArrayItem("installment_v_o")]
        public List<InstallmentVO> InstallmentList { get; set; }

        /// <summary>
        /// 分期状态，NEW - 正常 OVERDUE - 逾期 SETTLED - 结清
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

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
        /// 应还本金
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
