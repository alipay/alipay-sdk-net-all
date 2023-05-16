using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayChannelPromoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PayChannelPromoInfo : AopObject
    {
        /// <summary>
        /// 渠道扩展信息
        /// </summary>
        [XmlElement("channel_balance")]
        public string ChannelBalance { get; set; }

        /// <summary>
        /// 渠道唯一索引
        /// </summary>
        [XmlElement("channel_index")]
        public string ChannelIndex { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [XmlElement("channel_name")]
        public string ChannelName { get; set; }
    }
}
