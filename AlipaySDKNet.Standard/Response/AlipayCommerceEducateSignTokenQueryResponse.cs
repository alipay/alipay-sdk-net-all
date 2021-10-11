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
        /// 需要将该字段返回给学校
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。{1:居民身份证；A:护照；X:学工号}
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 家长支付宝账户的脱敏信息
        /// </summary>
        [XmlElement("parent_logon_id")]
        public string ParentLogonId { get; set; }

        /// <summary>
        /// 家长uid。其为当前开通的支付宝会员id，用于支付，与刷脸uid不同（历史原因，部分学生和教职工本人开通，其刷脸uid与当前uid一致）
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
        /// 学校外标（即学校的统一信用编码）
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 用户uid。用于扫脸和刷脸支付
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
