using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePetSpeciesQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePetSpeciesQueryModel : AopObject
    {
        /// <summary>
        /// 宠物类型
        /// </summary>
        [XmlElement("pet_type")]
        public string PetType { get; set; }
    }
}
