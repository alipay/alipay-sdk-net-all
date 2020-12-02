using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PetProfiles Data Structure.
    /// </summary>
    [Serializable]
    public class PetProfiles : AopObject
    {
        /// <summary>
        /// 宠物档案列表
        /// </summary>
        [XmlArray("pet_profile_list")]
        [XmlArrayItem("pet_profile")]
        public List<PetProfile> PetProfileList { get; set; }

        /// <summary>
        /// 宠物类型，如猫、狗
        /// </summary>
        [XmlElement("pet_type")]
        public string PetType { get; set; }
    }
}
