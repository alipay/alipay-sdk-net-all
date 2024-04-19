using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferAmount Data Structure.
    /// </summary>
    [Serializable]
    public class TransferAmount : AopObject
    {
        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 金额，对应币种的最小单位
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
