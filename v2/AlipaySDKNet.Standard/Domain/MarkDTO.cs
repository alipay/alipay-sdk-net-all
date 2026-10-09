using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MarkDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MarkDTO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("pic_urls")]
        [XmlArrayItem("string")]
        public List<string> PicUrls { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("video_card_vo")]
        [XmlArrayItem("string")]
        public List<string> VideoCardVo { get; set; }
    }
}
