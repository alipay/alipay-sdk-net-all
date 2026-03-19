using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdIssuerVcconfigQueryResponse.
    /// </summary>
    public class AlipaySecurityProdIssuerVcconfigQueryResponse : AopResponse
    {
        /// <summary>
        /// 凭证中所要包含字段的schema
        /// </summary>
        [XmlElement("attribute_schema")]
        public string AttributeSchema { get; set; }

        /// <summary>
        /// 凭证安全等级 256在导入凭证时不需要验证pin码，257在导入凭证时需要验证pin码
        /// </summary>
        [XmlElement("security_level")]
        public string SecurityLevel { get; set; }

        /// <summary>
        /// 是否支持撤销 true表示支持，false表示不支持
        /// </summary>
        [XmlElement("support_revoke")]
        public bool SupportRevoke { get; set; }

        /// <summary>
        /// 是否支持选择性披露 true表示支持，false表示不支持
        /// </summary>
        [XmlElement("support_select")]
        public bool SupportSelect { get; set; }
    }
}
