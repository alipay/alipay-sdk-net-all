using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneContentCommunitySubtitleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneContentCommunitySubtitleQueryModel : AopObject
    {
        /// <summary>
        /// 10s内字幕文本，最多1000个字
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 字幕扩展字段
        /// </summary>
        [XmlElement("ext")]
        public AliveSubtitleExt Ext { get; set; }

        /// <summary>
        /// 直播ID
        /// </summary>
        [XmlElement("live_id")]
        public string LiveId { get; set; }
    }
}
