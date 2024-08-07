using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryPetSpeciesDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryPetSpeciesDTO : AopObject
    {
        /// <summary>
        /// 宠物品种名称
        /// </summary>
        [XmlElement("pet_species")]
        public string PetSpecies { get; set; }

        /// <summary>
        /// 宠物品种编码
        /// </summary>
        [XmlElement("pet_species_code")]
        public string PetSpeciesCode { get; set; }

        /// <summary>
        /// 宠物类型
        /// </summary>
        [XmlElement("pet_type")]
        public string PetType { get; set; }
    }
}
