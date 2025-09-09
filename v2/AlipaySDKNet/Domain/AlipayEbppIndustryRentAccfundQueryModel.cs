using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRentAccfundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRentAccfundQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝交易订单单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
