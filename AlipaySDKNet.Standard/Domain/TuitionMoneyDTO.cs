using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionMoneyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionMoneyDTO : AopObject
    {
        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 金额最小单位
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
