using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOrderCancelResponse.
    /// </summary>
    public class AlipayCommerceMedicalOrderCancelResponse : AopResponse
    {
        /// <summary>
        /// 取消结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }

        /// <summary>
        /// 退款结果描述
        /// </summary>
        [XmlElement("refund_msg")]
        public string RefundMsg { get; set; }

        /// <summary>
        /// 退款单号
        /// </summary>
        [XmlElement("refund_no")]
        public string RefundNo { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }
    }
}
