using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcassetscenterMerchantbaseinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceRcassetscenterMerchantbaseinfoQueryModel : AopObject
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("corp_name")]
        public string CorpName { get; set; }

        /// <summary>
        /// 组织机构代码
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 页号，从1开始，默认1
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页面大小，默认10 最大50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("unified_social_credit_code")]
        public string UnifiedSocialCreditCode { get; set; }
    }
}
