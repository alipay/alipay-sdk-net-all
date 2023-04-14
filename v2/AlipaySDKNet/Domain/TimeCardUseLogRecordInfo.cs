using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimeCardUseLogRecordInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TimeCardUseLogRecordInfo : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 次卡id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 记录id
        /// </summary>
        [XmlElement("log_id")]
        public string LogId { get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [XmlElement("log_time")]
        public string LogTime { get; set; }

        /// <summary>
        /// 记录类型
        /// </summary>
        [XmlElement("log_type")]
        public string LogType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 次卡简单细心你
        /// </summary>
        [XmlElement("time_card_info")]
        public TimeCardSimpleItemInfo TimeCardInfo { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
