using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrISVImageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrISVImageDTO : AopObject
    {
        /// <summary>
        /// 图片格式，如JPG
        /// </summary>
        [XmlElement("image_format")]
        public string ImageFormat { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 图片类型
        /// </summary>
        [XmlElement("image_type")]
        public string ImageType { get; set; }
    }
}
