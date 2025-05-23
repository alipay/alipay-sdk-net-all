using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InfraTemplateEnumRuleOptionResp Data Structure.
    /// </summary>
    [Serializable]
    public class InfraTemplateEnumRuleOptionResp : AopObject
    {
        /// <summary>
        /// 元素可选值编码,非自定义错误码,非枚举类型
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 元素可选值编码描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }
    }
}
