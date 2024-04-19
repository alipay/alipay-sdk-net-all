using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankBudgetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankBudgetInfo : AopObject
    {
        /// <summary>
        /// 活动预算配置信息
        /// </summary>
        [XmlElement("budget_config_info")]
        public DtBankBudgetConfigInfo BudgetConfigInfo { get; set; }

        /// <summary>
        /// 活动预算实时信息，发布之后的活动有值，已创建未发布的活动为空
        /// </summary>
        [XmlElement("budget_real_time_info")]
        public DtBankBudgetRealTimeInfo BudgetRealTimeInfo { get; set; }
    }
}
