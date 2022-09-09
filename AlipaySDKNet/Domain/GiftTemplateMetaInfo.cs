using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftTemplateMetaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GiftTemplateMetaInfo : AopObject
    {
        /// <summary>
        /// 视觉资源链接，使用于红包详情页
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 展示文案
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 视觉资源所属类型，值为image时表示图片，值为video时表示视频
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
