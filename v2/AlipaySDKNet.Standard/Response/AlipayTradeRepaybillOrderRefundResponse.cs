using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeRepaybillOrderRefundResponse.
    /// </summary>
    public class AlipayTradeRepaybillOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 支付宝还款账单编号，和请求入参保持一致
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 支付宝系统资金处理成功时间，格式为"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 本次退款请求的外部请求号，和请求入参保持一致
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
