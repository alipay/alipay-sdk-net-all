using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelList Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelList : AopObject
    {
        /// <summary>
        /// 用户来源
        /// </summary>
        [XmlElement("new_user_source")]
        public string NewUserSource { get; set; }

        /// <summary>
        /// 核算OU
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 渠道code
        /// </summary>
        [XmlElement("sell_channel_code")]
        public string SellChannelCode { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [XmlElement("sell_channel_name")]
        public string SellChannelName { get; set; }
    }
}
