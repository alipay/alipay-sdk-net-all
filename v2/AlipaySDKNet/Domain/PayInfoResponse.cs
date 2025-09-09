using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class PayInfoResponse : AopObject
    {
        /// <summary>
        /// 收单超时关单时间，单位：s
        /// </summary>
        [XmlElement("no_pay_close_time")]
        public string NoPayCloseTime { get; set; }

        /// <summary>
        /// 支付宝收单交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
