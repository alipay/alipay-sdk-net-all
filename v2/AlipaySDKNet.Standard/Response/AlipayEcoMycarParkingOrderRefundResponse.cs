using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderRefundResponse.
    /// </summary>
    public class AlipayEcoMycarParkingOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 代扣时返回的支付宝支付交易流水号，系统唯一
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部申请退款请求流水，ISV唯一
        /// </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 本次退款金额，保留小数点后两位
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 支付宝退款流水
        /// </summary>
        [XmlElement("refund_no")]
        public string RefundNo { get; set; }
    }
}
