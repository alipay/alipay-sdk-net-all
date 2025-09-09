using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePetSpeciesQueryResponse.
    /// </summary>
    public class AlipayCommercePetSpeciesQueryResponse : AopResponse
    {
        /// <summary>
        /// 宠物品种列表
        /// </summary>
        [XmlArray("species")]
        [XmlArrayItem("industry_pet_species_d_t_o")]
        public List<IndustryPetSpeciesDTO> Species { get; set; }
    }
}
