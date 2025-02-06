using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySalaryRefundApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySalaryRefundApplyModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 币种，必须同原交易
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
        /// 退款外部交易号
        /// </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 代发商户的商户号
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// ParticipantType 收款方类型，即原支付代发商户：MERCHANT
        /// </summary>
        [XmlElement("participant_type")]
        public string ParticipantType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 订单退款金额。向渠道退款金额。单位为分
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 关联网商订单号
        /// </summary>
        [XmlElement("relate_order_no")]
        public string RelateOrderNo { get; set; }

        /// <summary>
        /// 关联网商支付流水号
        /// </summary>
        [XmlElement("relate_trans_no")]
        public string RelateTransNo { get; set; }

        /// <summary>
        /// 加签xml
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }
    }
}
