using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssistantCompanySimpleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssistantCompanySimpleInfo : AopObject
    {
        /// <summary>
        /// 企业的完整名称，后续会根据名称获取企业信息，会优先使用统一社会信用代码，若无统一社会信用代码，则使用名称。若名称也无法匹配，则不会对当前在进行处理。
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 企业的统一社会信用代码
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }
    }
}
