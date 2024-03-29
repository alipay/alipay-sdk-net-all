using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOrderCreateResponse.
    /// </summary>
    public class MybankPaymentTradeNormalpayOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 场景端依赖该URL，拉起网商收银台，需和支付渠道的http前缀结合
        /// </summary>
        [XmlElement("cashier_url")]
        public string CashierUrl { get; set; }

        /// <summary>
        /// 网商订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求受理时间，格式是yyyyMMddHHmmss
        /// </summary>
        [XmlElement("request_accept_time")]
        public string RequestAcceptTime { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 外部平台判断是否可重试，失败时有值，true=可重试，false=不可重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
