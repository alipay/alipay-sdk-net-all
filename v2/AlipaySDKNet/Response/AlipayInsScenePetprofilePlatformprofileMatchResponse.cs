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
        /// 用于返回匹配宠物的匹配值分数，类型为List，每一个对象的属性是，宠物petid，和score，分数从0到100整数字符串，分数越高，匹配度越高
        /// </summary>
        [XmlArray("match_scores")]
        [XmlArrayItem("pet_match_scores")]
        public List<PetMatchScores> MatchScores { get; set; }

        /// <summary>
        /// 匹配到的宠物档案列表，匹配程度由高到低。
        /// </summary>
        [XmlArray("pet_profiles")]
        [XmlArrayItem("platform_pet_profile")]
        public List<PlatformPetProfile> PetProfiles { get; set; }
    }
}
