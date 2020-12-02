using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInsassetprodPetprofileQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInsassetprodPetprofileQueryModel : AopObject
    {
        /// <summary>
        /// 渠道类型
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 宠物ID
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }
    }
}
