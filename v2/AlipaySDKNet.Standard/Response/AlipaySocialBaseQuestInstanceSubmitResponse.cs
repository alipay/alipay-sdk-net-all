using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceSubmitResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstanceSubmitResponse : AopResponse
    {
        /// <summary>
        /// 今日打卡次数
        /// </summary>
        [XmlElement("daily_count")]
        public long DailyCount { get; set; }

        /// <summary>
        /// 打卡总天数
        /// </summary>
        [XmlElement("mark_amount")]
        public long MarkAmount { get; set; }

        /// <summary>
        /// 打卡时间戳
        /// </summary>
        [XmlElement("mark_time")]
        public long MarkTime { get; set; }

        /// <summary>
        /// 打卡成功文案
        /// </summary>
        [XmlElement("mark_tip")]
        public string MarkTip { get; set; }
    }
}
