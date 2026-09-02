using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerPaymentsRefundQueryResponse.
    /// </summary>
    public class AlipayVoyagerPaymentsRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 退款订单
        /// </summary>
        [XmlElement("refund_order")]
        public StandardRefundOrderDTO RefundOrder { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }
    }
}
