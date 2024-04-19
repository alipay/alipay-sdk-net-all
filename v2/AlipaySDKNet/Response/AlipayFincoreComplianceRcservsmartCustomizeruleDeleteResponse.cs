using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceRcservsmartCustomizeruleDeleteResponse.
    /// </summary>
    public class AlipayFincoreComplianceRcservsmartCustomizeruleDeleteResponse : AopResponse
    {
        /// <summary>
        /// 自定义规则返回体
        /// </summary>
        [XmlElement("rcsmart_common_response")]
        public RcSmartCustomizeRuleResponse RcsmartCommonResponse { get; set; }
    }
}
