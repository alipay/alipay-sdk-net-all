using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinksTemplateData Data Structure.
    /// </summary>
    [Serializable]
    public class LinksTemplateData : AopObject
    {
        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 调整地址
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 链接标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
