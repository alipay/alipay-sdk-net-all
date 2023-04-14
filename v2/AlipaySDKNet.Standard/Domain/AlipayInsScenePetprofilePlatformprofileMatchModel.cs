using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePetprofilePlatformprofileMatchModel : AopObject
    {
        /// <summary>
        /// 宠物类型：狗(2000)/猫(1000)
        /// </summary>
        [XmlElement("pet_type")]
        public string PetType { get; set; }

        /// <summary>
        /// 宠物照片列表，用于匹配宠物档案，支持鼻纹和正脸多张照片搜索
        /// </summary>
        [XmlArray("photos")]
        [XmlArrayItem("pet_photo")]
        public List<PetPhoto> Photos { get; set; }
    }
}
