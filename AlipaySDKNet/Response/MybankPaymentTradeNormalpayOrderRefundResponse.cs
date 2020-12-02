using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOrderRefundResponse.
    /// </summary>
    public class MybankPaymentTradeNormalpayOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 网商受理退款操作返回的流水号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

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
        /// 外部平台是否需要原单重试，失败时有值
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }
    }
}
