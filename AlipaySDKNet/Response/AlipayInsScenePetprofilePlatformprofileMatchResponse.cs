using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileMatchResponse.
    /// </summary>
    public class AlipayInsScenePetprofilePlatformprofileMatchResponse : AopResponse
    {
        /// <summary>
        /// 匹配到的宠物档案列表，匹配程度由高到低。
        /// </summary>
        [XmlArray("pet_profiles")]
        [XmlArrayItem("platform_pet_profile")]
        public List<PlatformPetProfile> PetProfiles { get; set; }
    }
}
