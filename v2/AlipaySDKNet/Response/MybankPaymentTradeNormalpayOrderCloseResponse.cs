using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOrderCloseResponse.
    /// </summary>
    public class MybankPaymentTradeNormalpayOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 网商订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 创建订单时的请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 外部平台是否可重试，失败时有值，true=可重试，false=不可重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
