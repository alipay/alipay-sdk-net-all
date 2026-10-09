using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePetprofilePlatformprofileCheckModel : AopObject
    {
        /// <summary>
        /// 文件上传后获取的ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 宠物照片类型  NOSE("nose", "鼻纹照"),FACE("face", "正脸照");
        /// </summary>
        [XmlElement("pet_photo_type")]
        public string PetPhotoType { get; set; }

        /// <summary>
        /// 宠物类型，狗(2000)/猫(1000)
        /// </summary>
        [XmlElement("pet_type")]
        public string PetType { get; set; }
    }
}
