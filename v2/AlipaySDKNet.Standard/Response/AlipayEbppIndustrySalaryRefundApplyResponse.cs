using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySalaryRefundApplyResponse.
    /// </summary>
    public class AlipayEbppIndustrySalaryRefundApplyResponse : AopResponse
    {
        /// <summary>
        /// 退款交易号
        /// </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 退款参与方id  对于代发商户，则填对应的MerchantId
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 退款参与方类型
        /// </summary>
        [XmlElement("participant_type")]
        public string ParticipantType { get; set; }

        /// <summary>
        /// 退款网商订单号
        /// </summary>
        [XmlElement("refund_order_no")]
        public string RefundOrderNo { get; set; }

        /// <summary>
        /// 关联网商订单号
        /// </summary>
        [XmlElement("relate_order_no")]
        public string RelateOrderNo { get; set; }

        /// <summary>
        /// 响应收付通加签的xml，通过base64Encode编码
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }
    }
}
