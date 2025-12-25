using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowCloudfundrefundQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowCloudfundrefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 退款付方id，即原支付单收方  如果是商户，则填入merchantId； 如果是平台，则填入isvOrgId； 如果是子户，则填入子户外标(子户号)
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 退款付方类型，即原支付单收方
        /// </summary>
        [XmlElement("participant_type")]
        public string ParticipantType { get; set; }

        /// <summary>
        /// 退款金额,单位：分
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 发起退款申请时的业务流水号
        /// </summary>
        [XmlElement("refund_biz_no")]
        public string RefundBizNo { get; set; }

        /// <summary>
        /// 错误码,退款失败时透出
        /// </summary>
        [XmlElement("refund_error_code")]
        public string RefundErrorCode { get; set; }

        /// <summary>
        /// 错误描述,退款失败时透出
        /// </summary>
        [XmlElement("refund_error_desc")]
        public string RefundErrorDesc { get; set; }

        /// <summary>
        /// 退款完成时间,格式：YYYYMMDDhhmmss
        /// </summary>
        [XmlElement("refund_finish_date")]
        public string RefundFinishDate { get; set; }

        /// <summary>
        /// 发起退款后银行返回的退款订单号
        /// </summary>
        [XmlElement("refund_order_no")]
        public string RefundOrderNo { get; set; }

        /// <summary>
        /// 退款结果
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }
    }
}
