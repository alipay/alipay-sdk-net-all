using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileQueryResponse.
    /// </summary>
    public class AlipayInsScenePetprofilePlatformprofileQueryResponse : AopResponse
    {
        /// <summary>
        /// 宠物档案
        /// </summary>
        [XmlElement("pet_profile")]
        public PlatformPetProfile PetProfile { get; set; }
    }
}
