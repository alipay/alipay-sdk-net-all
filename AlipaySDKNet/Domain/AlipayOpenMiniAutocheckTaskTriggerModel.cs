using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAutocheckTaskTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAutocheckTaskTriggerModel : AopObject
    {
        /// <summary>
        /// 用例ID
        /// </summary>
        [XmlElement("case_id")]
        public string CaseId { get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [XmlElement("strategy_id")]
        public string StrategyId { get; set; }

        /// <summary>
        /// 任务执行人，传工号
        /// </summary>
        [XmlElement("trigger")]
        public string Trigger { get; set; }
    }
}
