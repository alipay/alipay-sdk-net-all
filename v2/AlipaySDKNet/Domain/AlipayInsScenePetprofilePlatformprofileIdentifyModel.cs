using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePetprofilePlatformprofileIdentifyModel : AopObject
    {
        /// <summary>
        /// 宠物ID
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }

        /// <summary>
        /// 宠物照片列表，正脸和鼻纹都不能为空
        /// </summary>
        [XmlArray("photos")]
        [XmlArrayItem("pet_photo")]
        public List<PetPhoto> Photos { get; set; }
    }
}
