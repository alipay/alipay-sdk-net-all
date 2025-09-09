using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentCommercialDemoInitSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentCommercialDemoInitSendModel : AopObject
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 玩法token
        /// </summary>
        [XmlElement("biztoken")]
        public string Biztoken { get; set; }

        /// <summary>
        /// 消息唯一id，幂等消费
        /// </summary>
        [XmlElement("msgid")]
        public string Msgid { get; set; }

        /// <summary>
        /// 毫秒级时间戳
        /// </summary>
        [XmlElement("timestamp_ms")]
        public string TimestampMs { get; set; }
    }
}
