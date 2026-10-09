using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingRefundQueryResponse.
    /// </summary>
    public class AlipayEcoMycarParkingRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务失败详细错误码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务返回码描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部退款订单号
        /// </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 支付宝停车平台订单号
        /// </summary>
        [XmlElement("parking_order_no")]
        public string ParkingOrderNo { get; set; }

        /// <summary>
        /// 支付宝停车平台退款订单号
        /// </summary>
        [XmlElement("parking_refund_no")]
        public string ParkingRefundNo { get; set; }

        /// <summary>
        /// 退款状态，"DOING":"处理中"; "SUCCESS":"成功"; "FAIL":"失败"
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }
    }
}
