using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignInPrizeConfig Data Structure.
    /// </summary>
    [Serializable]
    public class SignInPrizeConfig : AopObject
    {
        /// <summary>
        /// 中奖频率限制
        /// </summary>
        [XmlElement("frequency_count")]
        public string FrequencyCount { get; set; }

        /// <summary>
        /// 频次限制的类型
        /// </summary>
        [XmlElement("frequency_type")]
        public string FrequencyType { get; set; }

        /// <summary>
        /// 奖品价值(定额时有值)
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 奖品对客信息表达
        /// </summary>
        [XmlElement("prize_custom_display_info")]
        public PrizeCustomDisplayInfo PrizeCustomDisplayInfo { get; set; }

        /// <summary>
        /// 奖品结束时间
        /// </summary>
        [XmlElement("prize_end_time")]
        public string PrizeEndTime { get; set; }

        /// <summary>
        /// 奖品ID
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品开始时间
        /// </summary>
        [XmlElement("prize_start_time")]
        public string PrizeStartTime { get; set; }

        /// <summary>
        /// 奖品类型
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }
    }
}
