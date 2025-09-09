using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupGiftVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupGiftVO : AopObject
    {
        /// <summary>
        /// 营销活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 入群有礼渠道枚举。默认渠道:"DEFAULT"，用户从任何渠道入群都将展示该福利。目前所有渠道有以下：支付有礼（支付宝支付后推荐的主渠道）、小程序快窗（小程序快窗可投放入群）、小程序组件（商家小程序可嵌入入群官方组件）。
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [XmlElement("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 入群有礼结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 入群有礼状态。valid：生效中，suspend：已暂停，init：未生效，invalid：已失效，expire：已过期。
        /// </summary>
        [XmlElement("gift_status")]
        public string GiftStatus { get; set; }

        /// <summary>
        /// 入群有礼开始时间。
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
