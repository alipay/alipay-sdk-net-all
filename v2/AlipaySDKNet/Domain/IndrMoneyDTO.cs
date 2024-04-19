using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrMoneyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrMoneyDTO : AopObject
    {
        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 金额最小单位遵循ISO4217标准
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
