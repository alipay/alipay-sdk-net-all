using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalItemPic Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalItemPic : AopObject
    {
        /// <summary>
        /// 图片说明
        /// </summary>
        [XmlElement("pic_desc")]
        public string PicDesc { get; set; }

        /// <summary>
        /// 图片标记
        /// </summary>
        [XmlElement("pic_mark")]
        public string PicMark { get; set; }

        /// <summary>
        /// 图片类型
        /// </summary>
        [XmlElement("pic_type")]
        public string PicType { get; set; }

        /// <summary>
        /// 图片排序
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("source_url")]
        public string SourceUrl { get; set; }
    }
}
