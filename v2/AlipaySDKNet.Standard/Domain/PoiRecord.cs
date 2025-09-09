using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PoiRecord Data Structure.
    /// </summary>
    [Serializable]
    public class PoiRecord : AopObject
    {
        /// <summary>
        /// 图片
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 景点类别
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 景点名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 是否途经
        /// </summary>
        [XmlElement("via_flag")]
        public bool ViaFlag { get; set; }
    }
}
