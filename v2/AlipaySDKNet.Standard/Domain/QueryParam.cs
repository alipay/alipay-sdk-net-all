using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryParam Data Structure.
    /// </summary>
    [Serializable]
    public class QueryParam : AopObject
    {
        /// <summary>
        /// 刷脸ftoken
        /// </summary>
        [XmlElement("ftoken")]
        public string Ftoken { get; set; }

        /// <summary>
        /// 小程序页面文案信息
        /// </summary>
        [XmlElement("show_text")]
        public ShowText ShowText { get; set; }

        /// <summary>
        /// 支付宝交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
