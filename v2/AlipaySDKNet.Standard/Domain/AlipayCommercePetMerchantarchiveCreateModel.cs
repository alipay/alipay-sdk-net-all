using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePetMerchantarchiveCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePetMerchantarchiveCreateModel : AopObject
    {
        /// <summary>
        /// 商户宠物Id
        /// </summary>
        [XmlElement("external_pet_id")]
        public string ExternalPetId { get; set; }

        /// <summary>
        /// 宠物生日
        /// </summary>
        [XmlElement("pet_birthday")]
        public string PetBirthday { get; set; }

        /// <summary>
        /// 宠物性别
        /// </summary>
        [XmlElement("pet_gender")]
        public string PetGender { get; set; }

        /// <summary>
        /// 宠物昵称
        /// </summary>
        [XmlElement("pet_nick")]
        public string PetNick { get; set; }

        /// <summary>
        /// 绝育情况
        /// </summary>
        [XmlElement("pet_no_baby")]
        public string PetNoBaby { get; set; }

        /// <summary>
        /// 宠物图片
        /// </summary>
        [XmlArray("pet_pic_list")]
        [XmlArrayItem("industry_pet_picture_d_t_o")]
        public List<IndustryPetPictureDTO> PetPicList { get; set; }

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
