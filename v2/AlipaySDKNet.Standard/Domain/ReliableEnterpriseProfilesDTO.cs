using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReliableEnterpriseProfilesDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ReliableEnterpriseProfilesDTO : AopObject
    {
        /// <summary>
        /// 企业注册来源渠道
        /// </summary>
        [XmlElement("access_channel")]
        public string AccessChannel { get; set; }

        /// <summary>
        /// 企业在来源渠道（如钉钉）的活跃度
        /// </summary>
        [XmlElement("activity_level")]
        public string ActivityLevel { get; set; }

        /// <summary>
        /// 企业在来源渠道（如钉钉）的认证类型
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 企业营业执照编码，适用于未三证合一的企业
        /// </summary>
        [XmlElement("biz_license_no")]
        public string BizLicenseNo { get; set; }

        /// <summary>
        /// 企业在来源渠道（如钉钉）的营业执照照片URL
        /// </summary>
        [XmlElement("biz_license_url")]
        public string BizLicenseUrl { get; set; }

        /// <summary>
        /// 企业当前的员工数规模区间
        /// </summary>
        [XmlElement("count_employee")]
        public string CountEmployee { get; set; }

        /// <summary>
        /// 企业法人的身份证号码
        /// </summary>
        [XmlElement("legal_person_cert_no")]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// 企业在来源渠道（如钉钉）的注册时间
        /// </summary>
        [XmlElement("platform_gmt_create")]
        public string PlatformGmtCreate { get; set; }

        /// <summary>
        /// 企业纳税人识别号，适用于未三证合一的企业
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 用于标识企业入驻链路
        /// </summary>
        [XmlElement("utm_chain")]
        public string UtmChain { get; set; }

        /// <summary>
        /// 具体流量内容区分，如推荐码、推荐人、推荐服务商名称等。由渠道侧自定义
        /// </summary>
        [XmlElement("utm_content")]
        public string UtmContent { get; set; }

        /// <summary>
        /// 渠道侧流量来源，由渠道侧自定义
        /// </summary>
        [XmlElement("utm_source")]
        public string UtmSource { get; set; }
    }
}
