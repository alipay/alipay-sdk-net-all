using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSignTokenQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSignTokenQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务场景类型标识
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

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
        /// 刷脸用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 家长支付宝账户的脱敏信息（特例：特殊标识"ALREADY_RELEASED"，须通过技术支持反馈来关闭开通记录）
        /// </summary>
        [XmlElement("parent_logon_id")]
        public string ParentLogonId { get; set; }

        /// <summary>
        /// 用于开通一脸通行的支付宝账户 openId。如果是父母为孩子开通，则为父母支付宝 openId；如果是用户为本人开通，则为本人支付宝 openId。
        /// </summary>
        [XmlElement("parent_open_id")]
        public string ParentOpenId { get; set; }

        /// <summary>
        /// 用于开通一脸通行的支付宝账户 uid。如果是父母为孩子开通，则为父母支付宝 uid；如果是用户为本人开通，则为本人支付宝 uid。
        /// </summary>
        [XmlElement("parent_user_id")]
        public string ParentUserId { get; set; }

        /// <summary>
        /// 学校内标
        /// </summary>
        [XmlElement("school_code")]
        public string SchoolCode { get; set; }

        /// <summary>
        /// 校园一脸通行开通状态。OPEN：开通，CLOSE：关闭
        /// </summary>
        [XmlElement("school_face_pass_status")]
        public string SchoolFacePassStatus { get; set; }

        /// <summary>
        /// 校园一脸通行刷脸支付开通状态。OPEN：开通，CLOSE：关闭
        /// </summary>
        [XmlElement("school_face_payment_status")]
        public string SchoolFacePaymentStatus { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 刷脸用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
