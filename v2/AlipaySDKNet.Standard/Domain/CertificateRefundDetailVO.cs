using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateRefundDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateRefundDetailVO : AopObject
    {
        /// <summary>
        /// 支付宝平台侧凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 退款金额，单位：元
        /// </summary>
        [XmlElement("refund_cash")]
        public string RefundCash { get; set; }

        /// <summary>
        /// 描述当前次序号对应的这笔退款的执行情况
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 支付宝平台侧凭证次序号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
