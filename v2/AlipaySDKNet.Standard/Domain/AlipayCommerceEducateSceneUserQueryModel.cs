using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSceneUserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSceneUserQueryModel : AopObject
    {
        /// <summary>
        /// 开通人绑定的支付宝openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝学校内标
        /// </summary>
        [XmlElement("alipay_school_id")]
        public string AlipaySchoolId { get; set; }

        /// <summary>
        /// 开通人绑定的支付宝UID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。{1:居民身份证；A:护照；X:学工号}
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 学生（教职工）的刷脸openId。刷脸openId与用户三要素二选一，都传优先使用刷脸openId
        /// </summary>
        [XmlElement("face_open_id")]
        public string FaceOpenId { get; set; }

        /// <summary>
        /// 学生（教职工）的刷脸UID。刷脸UID与用户三要素二选一，都传优先使用刷脸UID
        /// </summary>
        [XmlElement("face_user_id")]
        public string FaceUserId { get; set; }

        /// <summary>
        /// 刷脸用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
