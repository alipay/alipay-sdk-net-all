using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditUserRoleQueryResponse.
    /// </summary>
    public class MybankCreditUserRoleQueryResponse : AopResponse
    {
        /// <summary>
        /// 证件名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，100：身份证；201：全国法人营业执照；2011：全国法人营业执照(多证合一)
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 客户IP_ID
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 客户的IP_ROLE_ID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 参与者类型；1：自然人，2：企业，3：金融机构，4：其它组织
        /// </summary>
        [XmlElement("ip_type")]
        public string IpType { get; set; }

        /// <summary>
        /// 站点会员
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点登录ID
        /// </summary>
        [XmlElement("site_login_id")]
        public string SiteLoginId { get; set; }

        /// <summary>
        /// 站点的会员ID
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
