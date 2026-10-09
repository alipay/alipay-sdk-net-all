using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePetprofilePlatformprofileQueryModel : AopObject
    {
        /// <summary>
        /// 宠物ID
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }
    }
}
