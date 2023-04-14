using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeBusinessOrderCloseResponse.
    /// </summary>
    public class MybankPaymentTradeBusinessOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 网商订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 创建的外部平台的单据号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 外部平台是否需要原单重试，失败时有值
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }
    }
}
