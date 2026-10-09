using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryPetPictureDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryPetPictureDTO : AopObject
    {
        /// <summary>
        /// 照片类型
        /// </summary>
        [XmlElement("image_type")]
        public string ImageType { get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }
    }
}
