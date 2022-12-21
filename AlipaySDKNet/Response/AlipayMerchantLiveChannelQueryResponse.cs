using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantLiveChannelQueryResponse.
    /// </summary>
    public class AlipayMerchantLiveChannelQueryResponse : AopResponse
    {
        /// <summary>
        /// 渠道内容，包含主播、文章的上游信息。字符串内容为Map，需要转换
        /// </summary>
        [XmlElement("channel_content")]
        public string ChannelContent { get; set; }

        /// <summary>
        /// 渠道业务标识
        /// </summary>
        [XmlElement("channel_identity")]
        public string ChannelIdentity { get; set; }

        /// <summary>
        /// 渠道密文
        /// </summary>
        [XmlElement("channel_secret")]
        public string ChannelSecret { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }
    }
}
