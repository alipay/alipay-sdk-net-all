using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockPokerChipSendResponse.
    /// </summary>
    public class AntfortuneStockPokerChipSendResponse : AopResponse
    {
        /// <summary>
        /// 筹码详情
        /// </summary>
        [XmlElement("chip")]
        public ChipDTO Chip { get; set; }
    }
}
