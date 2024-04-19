using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantChannelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantChannelCreateModel : AopObject
    {
        /// <summary>
        /// 渠道唯一标识
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [XmlElement("channel_name")]
        public string ChannelName { get; set; }
    }
}
