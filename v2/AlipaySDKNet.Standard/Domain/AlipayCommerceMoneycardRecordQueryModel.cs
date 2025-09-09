using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMoneycardRecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMoneycardRecordQueryModel : AopObject
    {
        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
