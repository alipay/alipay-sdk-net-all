using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SignUserInfo : AopObject
    {
        /// <summary>
        /// 数据的创建时间
        /// </summary>
        [XmlElement("agreement_gmt_create")]
        public string AgreementGmtCreate { get; set; }

        /// <summary>
        /// 协议id
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 协议链接
        /// </summary>
        [XmlElement("agreement_url")]
        public string AgreementUrl { get; set; }

        /// <summary>
        /// 协议版本
        /// </summary>
        [XmlElement("agreement_version")]
        public string AgreementVersion { get; set; }

        /// <summary>
        /// 人脸核验ID
        /// </summary>
        [XmlElement("face_verification_id")]
        public string FaceVerificationId { get; set; }

        /// <summary>
        /// 人脸核验平台
        /// </summary>
        [XmlElement("face_verification_platform")]
        public string FaceVerificationPlatform { get; set; }

        /// <summary>
        /// 人脸核验时间
        /// </summary>
        [XmlElement("face_verification_time")]
        public string FaceVerificationTime { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [XmlElement("sign_datetime")]
        public string SignDatetime { get; set; }
    }
}
