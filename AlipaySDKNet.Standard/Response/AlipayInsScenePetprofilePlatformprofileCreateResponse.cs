using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileCreateResponse.
    /// </summary>
    public class AlipayInsScenePetprofilePlatformprofileCreateResponse : AopResponse
    {
        /// <summary>
        /// 宠物ID，唯一标记一份档案。
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }
    }
}
