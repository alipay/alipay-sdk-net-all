using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankBudgetRealTimeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankBudgetRealTimeInfo : AopObject
    {
        /// <summary>
        /// 活动退款金额，单位分
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 活动剩余预算，单位分
        /// </summary>
        [XmlElement("remaining_budget")]
        public long RemainingBudget { get; set; }

        /// <summary>
        /// 优惠发放金额，单位为分，立减活动此字段为空
        /// </summary>
        [XmlElement("send_amount")]
        public long SendAmount { get; set; }

        /// <summary>
        /// 优惠发放数量，立减活动此字段为空
        /// </summary>
        [XmlElement("send_count")]
        public long SendCount { get; set; }

        /// <summary>
        /// 优惠核销金额，单位分
        /// </summary>
        [XmlElement("used_amount")]
        public long UsedAmount { get; set; }

        /// <summary>
        /// 优惠核销数量
        /// </summary>
        [XmlElement("used_count")]
        public long UsedCount { get; set; }
    }
}
