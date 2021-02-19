using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskContentDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskContentDetectModel : AopObject
    {
        /// <summary>
        /// 需要识别的文本。 注意：请勿传入包含特殊字符及双引号等，可能引起 json 格式化错误问题的字符。
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
