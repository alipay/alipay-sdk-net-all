using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySalaryRefundQueryResponse.
    /// </summary>
    public class AlipayEbppIndustrySalaryRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("bank_error_code")]
        public string BankErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("bank_error_desc")]
        public string BankErrorDesc { get; set; }

        /// <summary>
        /// 聚合收单场景渠道退款单号
        /// </summary>
        [XmlElement("channel_refund_order_no")]
        public string ChannelRefundOrderNo { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 扩展信息,Map的json序列化后Base64
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部退款交易号
        /// </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 商户实际退款金额,单位为分
        /// </summary>
        [XmlElement("participant_actual_refund_amount")]
        public string ParticipantActualRefundAmount { get; set; }

        /// <summary>
        /// 退款参与方id，如果是代发商户，则填入MerchantId
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 退款参与方类型商户
        /// </summary>
        [XmlElement("participant_type")]
        public string ParticipantType { get; set; }

        /// <summary>
        /// 退款金额。币种同原交易,单位为分
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款完成时间,YYYYMMDDhhmmss
        /// </summary>
        [XmlElement("refund_finish_date")]
        public string RefundFinishDate { get; set; }

        /// <summary>
        /// 退款网商订单号
        /// </summary>
        [XmlElement("refund_order_no")]
        public string RefundOrderNo { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

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
