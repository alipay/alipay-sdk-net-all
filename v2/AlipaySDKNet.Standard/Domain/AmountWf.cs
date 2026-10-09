using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmountWf Data Structure.
    /// </summary>
    [Serializable]
    public class AmountWf : AopObject
    {
        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 分
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
