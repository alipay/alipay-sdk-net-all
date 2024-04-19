using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseQuestInstanceAddModel : AopObject
    {
        /// <summary>
        /// 目标ID
        /// </summary>
        [XmlElement("quest_id")]
        public string QuestId { get; set; }

        /// <summary>
        /// 每日打卡提醒时间范围，小目标提醒时间会在这个范围随机设定，时间格式HH-MM，开始时间和结束时间-分割。
        /// </summary>
        [XmlElement("remind_time_range")]
        public string RemindTimeRange { get; set; }

        /// <summary>
        /// 调用方标识
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
