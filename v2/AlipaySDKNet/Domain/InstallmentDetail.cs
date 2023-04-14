using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstallmentDetail Data Structure.
    /// </summary>
    [Serializable]
    public class InstallmentDetail : AopObject
    {
        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 结清状态，SETTLED - 结清；NOT_SETTLE - 未结清
        /// </summary>
        [XmlElement("is_settle")]
        public string IsSettle { get; set; }

        /// <summary>
        /// 分期期次
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 减免利息
        /// </summary>
        [XmlElement("reduce_interest")]
        public long ReduceInterest { get; set; }

        /// <summary>
        /// 减免复利
        /// </summary>
        [XmlElement("reduce_interest_penalty")]
        public long ReduceInterestPenalty { get; set; }

        /// <summary>
        /// 减免罚息
        /// </summary>
        [XmlElement("reduce_penalty")]
        public long ReducePenalty { get; set; }

        /// <summary>
        /// 已还利息 - 该期累计实还利息
        /// </summary>
        [XmlElement("repaid_interest_amount")]
        public long RepaidInterestAmount { get; set; }

        /// <summary>
        /// 已还复利 - 该期累计实还复利
        /// </summary>
        [XmlElement("repaid_interest_penalty_amount")]
        public long RepaidInterestPenaltyAmount { get; set; }

        /// <summary>
        /// 已还罚息 - 该期累计实还罚息
        /// </summary>
        [XmlElement("repaid_penalty_amount")]
        public long RepaidPenaltyAmount { get; set; }

        /// <summary>
        /// 已还本金 - 该期累计实还本金
        /// </summary>
        [XmlElement("repaid_principal_amount")]
        public long RepaidPrincipalAmount { get; set; }

        /// <summary>
        /// 剩余利息 - 该期剩余应还利息
        /// </summary>
        [XmlElement("rest_interest")]
        public long RestInterest { get; set; }

        /// <summary>
        /// 剩余复利 - 该期剩余应还复利
        /// </summary>
        [XmlElement("rest_interest_penalty")]
        public long RestInterestPenalty { get; set; }

        /// <summary>
        /// 剩余罚息 - 该期剩余应还罚息
        /// </summary>
        [XmlElement("rest_penalty")]
        public long RestPenalty { get; set; }

        /// <summary>
        /// 剩余本金 - 该期剩余应还本金
        /// </summary>
        [XmlElement("rest_principal")]
        public long RestPrincipal { get; set; }
    }
}
