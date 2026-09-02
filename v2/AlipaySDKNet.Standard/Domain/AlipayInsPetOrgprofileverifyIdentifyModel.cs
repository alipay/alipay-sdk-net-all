using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsPetOrgprofileverifyIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsPetOrgprofileverifyIdentifyModel : AopObject
    {
        /// <summary>
        /// 外部业务单号，用于接口幂等，每次请求需保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 宠物正脸照链接
        /// </summary>
        [XmlElement("pet_face_url")]
        public string PetFaceUrl { get; set; }

        /// <summary>
        /// 建档接口返回的宠物档案唯一标识
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }
    }
}
