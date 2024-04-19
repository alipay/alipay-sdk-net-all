using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePetFileQueryResponse.
    /// </summary>
    public class AlipayCommercePetFileQueryResponse : AopResponse
    {
        /// <summary>
        /// 宠物生日
        /// </summary>
        [XmlElement("birth_date")]
        public string BirthDate { get; set; }

        /// <summary>
        /// 宠物品种
        /// </summary>
        [XmlElement("breed")]
        public string Breed { get; set; }

        /// <summary>
        /// 宠物品类(CAT/DOG/OTHER)
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 是否驱虫（YES/NO）
        /// </summary>
        [XmlElement("expelled_flag")]
        public string ExpelledFlag { get; set; }

        /// <summary>
        /// 宠物档案id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 宠物名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 宠物证
        /// </summary>
        [XmlElement("pet_certify")]
        public string PetCertify { get; set; }

        /// <summary>
        /// 宠物照片，List<String>
        /// </summary>
        [XmlArray("photo")]
        [XmlArrayItem("string")]
        public List<string> Photo { get; set; }

        /// <summary>
        /// 宠物性别（MALE/FEMALE）
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 是否绝育（YES/NO）
        /// </summary>
        [XmlElement("sterilization_flag")]
        public string SterilizationFlag { get; set; }

        /// <summary>
        /// 是否接种疫苗（YES/NO）
        /// </summary>
        [XmlElement("vaccines_flag")]
        public string VaccinesFlag { get; set; }
    }
}
