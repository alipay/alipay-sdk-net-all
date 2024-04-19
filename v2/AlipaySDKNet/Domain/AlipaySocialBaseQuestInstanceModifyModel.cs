using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseQuestInstanceModifyModel : AopObject
    {
        /// <summary>
        /// 小目标唯一ID
        /// </summary>
        [XmlElement("quest_id")]
        public string QuestId { get; set; }

        /// <summary>
        /// 每日打卡提醒时间范围，小目标提醒时间会在这个范围随机设定，时间格式HH-MM，开始时间和结束时间-分割。 传空表示取消提醒设置
        /// </summary>
        [XmlElement("remind_time_range")]
        public string RemindTimeRange { get; set; }

        /// <summary>
        /// 调用方标识
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 修改类型： 1 表示修改小目标提醒时间
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
