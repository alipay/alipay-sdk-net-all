using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeBusinessOrderCreateResponse.
    /// </summary>
    public class MybankPaymentTradeBusinessOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 网商银行创建的业务单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 外部平台判断是否需要重试，失败时有值，true=需要重试，false=不需要重试，是否重试可以由业务决定
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }
    }
}
