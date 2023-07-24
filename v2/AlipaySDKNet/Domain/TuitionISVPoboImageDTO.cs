using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVPoboImageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVPoboImageDTO : AopObject
    {
        /// <summary>
        /// 图片格式
        /// </summary>
        [XmlElement("image_format")]
        public string ImageFormat { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }
    }
}
