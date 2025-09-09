using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePetPictureCheckavailableModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePetPictureCheckavailableModel : AopObject
    {
        /// <summary>
        /// 文件Id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 照片类型
        /// </summary>
        [XmlElement("image_type")]
        public string ImageType { get; set; }

        /// <summary>
        /// 宠物类型
        /// </summary>
        [XmlElement("pet_type")]
        public string PetType { get; set; }
    }
}
