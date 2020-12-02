using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsassetprodPetprofilelistQueryResponse.
    /// </summary>
    public class AlipayInsSceneInsassetprodPetprofilelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 列表
        /// </summary>
        [XmlArray("pet_profiles")]
        [XmlArrayItem("pet_profiles")]
        public List<PetProfiles> PetProfiles { get; set; }
    }
}
