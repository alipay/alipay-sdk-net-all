using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeBusinessOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeBusinessOrderQueryModel : AopObject
    {
        /// <summary>
        /// 网商交易订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 下单的外部订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
