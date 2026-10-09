using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceComplianceCheckResult Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceComplianceCheckResult : AopObject
    {
        /// <summary>
        /// 发票和账单匹配的合规检查结果： 0 - 模糊匹配 1 - 精准匹配
        /// </summary>
        [XmlElement("match_result_type")]
        public string MatchResultType { get; set; }
    }
}
