using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultChannelResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultChannelResponse : AopObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 可用额度，单位元
        /// </summary>
        [XmlElement("channel_amount")]
        public string ChannelAmount { get; set; }
    }
}
