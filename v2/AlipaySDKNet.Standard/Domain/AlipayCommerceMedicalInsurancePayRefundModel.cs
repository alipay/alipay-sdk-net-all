using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsurancePayRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsurancePayRefundModel : AopObject
    {
        /// <summary>
        /// 申请单号，快赔时必填
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 业务类型，1：快赔退款，2：差额追偿
        /// </summary>
        [XmlElement("biz_type")]
        public long BizType { get; set; }

        /// <summary>
        /// 理赔案件号，当业务类型为快赔退款时必填
        /// </summary>
        [XmlElement("claim_order_no")]
        public string ClaimOrderNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部支付单号
        /// </summary>
        [XmlElement("out_pay_order_no")]
        public string OutPayOrderNo { get; set; }

        /// <summary>
        /// 请求来源，固定值，由支付宝侧统一定义给出，标识用户请求来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
