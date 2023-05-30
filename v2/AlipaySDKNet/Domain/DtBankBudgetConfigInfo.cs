using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankBudgetConfigInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankBudgetConfigInfo : AopObject
    {
        /// <summary>
        /// 每日预算类型
        /// </summary>
        [XmlElement("daily_budget_type")]
        public string DailyBudgetType { get; set; }

        /// <summary>
        /// 每日预算值。例如1000，当total_budget为MONEY时，单位为分，表示每日预算为10.00元；当total_budget为COUNT时，表示每日预算为1000份。
        /// </summary>
        [XmlElement("daily_budget_value")]
        public long DailyBudgetValue { get; set; }

        /// <summary>
        /// 活动最小发放数量，立减活动此参数为空。
        /// </summary>
        [XmlElement("min_send_count")]
        public long MinSendCount { get; set; }

        /// <summary>
        /// 活动总预算，单位为分，例如10000表示总预算为100.00元
        /// </summary>
        [XmlElement("total_budget")]
        public long TotalBudget { get; set; }
    }
}
