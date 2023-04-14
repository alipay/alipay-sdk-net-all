using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenCertifyIdentityParam Data Structure.
    /// </summary>
    [Serializable]
    public class OpenCertifyIdentityParam : AopObject
    {
        /// <summary>
        /// cert_digest： 身份信息摘要
        /// </summary>
        [XmlElement("cert_digest")]
        public string CertDigest { get; set; }

        /// <summary>
        /// cert_name： 填入真实姓名
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// cert_no： 填入姓名相匹配的证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// cert_type： 1、若为身份证，填IDENTITY_CARD； 2、若为港澳居民来往内地通行证，填HOME_VISIT_PERMIT_HK_MC； 3、若为台湾居民来往内地通行证，填HOME_VISIT_PERMIT_TAIWAN； 4、若为港澳居民居住证，填RESIDENCE_PERMIT_HK_MC； 5、若为台湾居民居住证，填RESIDENCE_PERMIT_TAIWAN；
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// facial_picture_front： 活体人脸图片base64串，主要用于离线人脸比对
        /// </summary>
        [XmlElement("facial_picture_front")]
        public string FacialPictureFront { get; set; }

        /// <summary>
        /// identity_type 1.若本人验证，使用CERT_INFO； 2.若代他人验证，使用AGENT_CERT_INFO；
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// open_id： 开放平台用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// phone_no： 填写姓名相匹配的手机号
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// user_id： 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
