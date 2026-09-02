using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsPetOrgprofileverifyMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsPetOrgprofileverifyMatchModel : AopObject
    {
        /// <summary>
        /// 商户的唯一编码，和建档接口传参保持一致
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 宠物正脸照链接
        /// </summary>
        [XmlElement("pet_face_url")]
        public string PetFaceUrl { get; set; }

        /// <summary>
        /// 宠物猫狗大类
        /// </summary>
        [XmlElement("pet_type")]
        public string PetType { get; set; }
    }
}
