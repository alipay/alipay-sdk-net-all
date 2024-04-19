using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApiContractGoal Data Structure.
    /// </summary>
    [Serializable]
    public class ApiContractGoal : AopObject
    {
        /// <summary>
        /// 完成时间
        /// </summary>
        [XmlElement("complete_date")]
        public string CompleteDate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 当前目标值
        /// </summary>
        [XmlElement("goal_current_value")]
        public long GoalCurrentValue { get; set; }

        /// <summary>
        /// 标的key
        /// </summary>
        [XmlElement("goal_key")]
        public string GoalKey { get; set; }

        /// <summary>
        /// cancel
        /// </summary>
        [XmlElement("goal_status")]
        public string GoalStatus { get; set; }

        /// <summary>
        /// time、amount、subject
        /// </summary>
        [XmlElement("goal_type")]
        public string GoalType { get; set; }

        /// <summary>
        /// 标的目标值
        /// </summary>
        [XmlElement("goal_value")]
        public long GoalValue { get; set; }

        /// <summary>
        /// 事项号
        /// </summary>
        [XmlElement("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 最后一次完成时间
        /// </summary>
        [XmlElement("last_complete_date")]
        public string LastCompleteDate { get; set; }
    }
}
