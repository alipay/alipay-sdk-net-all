using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InfraTemplateMoneyRuleResp Data Structure.
    /// </summary>
    [Serializable]
    public class InfraTemplateMoneyRuleResp : AopObject
    {
        /// <summary>
        /// 金额精度，即小数点后保留几位小数
        /// </summary>
        [XmlElement("decimal")]
        public long Decimal { get; set; }
    }
}
