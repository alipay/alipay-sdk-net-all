using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PetPicData Data Structure.
    /// </summary>
    [Serializable]
    public class PetPicData : AopObject
    {
        /// <summary>
        /// 宠物照片类型，如全身照、鼻纹照
        /// </summary>
        [XmlElement("image_type")]
        public string ImageType { get; set; }

        /// <summary>
        /// 宠物照片地址
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }
    }
}
