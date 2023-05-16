using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceSceneChannelVO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceSceneChannelVO : AopObject
    {
        /// <summary>
        /// 渠道code
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
