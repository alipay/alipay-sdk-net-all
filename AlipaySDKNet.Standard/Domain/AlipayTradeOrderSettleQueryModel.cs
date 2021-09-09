using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeOrderSettleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeOrderSettleQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝分账请求单号
        /// </summary>
        [XmlElement("settle_no")]
        public string SettleNo { get; set; }
    }
}
