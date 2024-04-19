using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Amount Data Structure.
    /// </summary>
    [Serializable]
    public class Amount : AopObject
    {
        /// <summary>
        /// 3位币种Code，遵循ISO 4217
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 表示在最小货币单位中代表多少费用的正整数。
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
