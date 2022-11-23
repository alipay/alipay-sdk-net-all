using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PhotoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PhotoInfo : AopObject
    {
        /// <summary>
        /// 图片高度
        /// </summary>
        [XmlElement("img_height")]
        public long ImgHeight { get; set; }

        /// <summary>
        /// 图片的宽
        /// </summary>
        [XmlElement("img_width")]
        public long ImgWidth { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 图片大小
        /// </summary>
        [XmlElement("photo_size")]
        public long PhotoSize { get; set; }

        /// <summary>
        /// 图片上传后的key
        /// </summary>
        [XmlElement("photo_url")]
        public string PhotoUrl { get; set; }
    }
}
