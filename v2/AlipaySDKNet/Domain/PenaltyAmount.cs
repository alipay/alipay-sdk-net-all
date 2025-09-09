using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PenaltyAmount Data Structure.
    /// </summary>
    [Serializable]
    public class PenaltyAmount : AopObject
    {
        /// <summary>
        /// 当前币种下的罚金金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种类型
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }
    }
}
