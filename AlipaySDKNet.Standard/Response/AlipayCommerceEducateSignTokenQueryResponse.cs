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
        /// 证件类型（"1","居民身份证"）
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 家长支付宝账户的脱敏信息
        /// </summary>
        [XmlElement("parent_logon_id")]
        public string ParentLogonId { get; set; }

        /// <summary>
        /// 家长id，如是本人开通，当前id与用户id相同
        /// </summary>
        [XmlElement("parent_user_id")]
        public string ParentUserId { get; set; }

        /// <summary>
        /// 学校内标
        /// </summary>
        [XmlElement("school_code")]
        public string SchoolCode { get; set; }

        /// <summary>
        /// 学校外标（即学校的统一信用编码）
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
