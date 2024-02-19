using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShareCodeCreateExtendParam Data Structure.
    /// </summary>
    [Serializable]
    public class ShareCodeCreateExtendParam : AopObject
    {
        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
