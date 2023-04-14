using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneContentCommunitySubtitleQueryResponse.
    /// </summary>
    public class AntfortuneContentCommunitySubtitleQueryResponse : AopResponse
    {
        /// <summary>
        /// 纠偏后的结果
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 字幕部分透传的字段
        /// </summary>
        [XmlElement("ext")]
        public AliveSubtitleExt Ext { get; set; }

        /// <summary>
        /// 直播Id
        /// </summary>
        [XmlElement("live_id")]
        public string LiveId { get; set; }
    }
}
