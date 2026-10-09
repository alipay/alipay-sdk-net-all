using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceabilityIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationCustomerFaceabilityIdentifyModel : AopObject
    {
        /// <summary>
        /// 无
        /// </summary>
        [XmlElement("ability")]
        public string Ability { get; set; }

        /// <summary>
        /// 算法版本，人脸PD定向提供
        /// </summary>
        [XmlElement("alg_ver")]
        public string AlgVer { get; set; }

        /// <summary>
        /// 活体图片encode base64 String
        /// </summary>
        [XmlElement("auth_img")]
        public string AuthImg { get; set; }

        /// <summary>
        /// 业务唯一ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 使用人脸能力所需要等拓展参数信息
        /// </summary>
        [XmlElement("ext_info")]
        public FaceAbilityExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 人脸定制分配的场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
