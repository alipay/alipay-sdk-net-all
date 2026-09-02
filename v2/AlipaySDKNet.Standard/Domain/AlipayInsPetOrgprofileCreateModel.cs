using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsPetOrgprofileCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsPetOrgprofileCreateModel : AopObject
    {
        /// <summary>
        /// 商户的唯一编码，可以取平台自己的商家唯一标识
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 创建档案的外部业务单号，用于接口幂等。可以使用平台自己的宠物档案id
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 宠物生日
        /// </summary>
        [XmlElement("pet_birthday")]
        public string PetBirthday { get; set; }

        /// <summary>
        /// 宠物品种编码，需要使用与蚂蚁宠物确认好的品种库
        /// </summary>
        [XmlElement("pet_breed_code")]
        public string PetBreedCode { get; set; }

        /// <summary>
        /// 宠物品种名称
        /// </summary>
        [XmlElement("pet_breed_name")]
        public string PetBreedName { get; set; }

        /// <summary>
        /// 宠物正脸照链接
        /// </summary>
        [XmlElement("pet_face_url")]
        public string PetFaceUrl { get; set; }

        /// <summary>
        /// 宠物性别
        /// </summary>
        [XmlElement("pet_gender")]
        public string PetGender { get; set; }

        /// <summary>
        /// 宠物的昵称
        /// </summary>
        [XmlElement("pet_nick")]
        public string PetNick { get; set; }

        /// <summary>
        /// 宠物绝育状态
        /// </summary>
        [XmlElement("pet_no_baby")]
        public string PetNoBaby { get; set; }

        /// <summary>
        /// 宠物的猫狗大类
        /// </summary>
        [XmlElement("pet_type")]
        public string PetType { get; set; }
    }
}
