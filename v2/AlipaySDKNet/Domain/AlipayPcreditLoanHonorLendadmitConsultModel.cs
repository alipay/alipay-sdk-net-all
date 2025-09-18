using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanHonorLendadmitConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanHonorLendadmitConsultModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 联合建模模型分（JSON格式）
        /// </summary>
        [XmlElement("api_model_score_map")]
        public string ApiModelScoreMap { get; set; }

        /// <summary>
        /// 用户标签（JSON格式）
        /// </summary>
        [XmlElement("api_user_tag_map")]
        public string ApiUserTagMap { get; set; }

        /// <summary>
        /// 渠道侧借款申请订单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 支付宝绑卡Id
        /// </summary>
        [XmlElement("bank_card_id")]
        public string BankCardId { get; set; }

        /// <summary>
        /// 渠道侧用户id
        /// </summary>
        [XmlElement("channel_customer_id")]
        public string ChannelCustomerId { get; set; }

        /// <summary>
        /// 借款优惠券id
        /// </summary>
        [XmlElement("coupon_no")]
        public string CouponNo { get; set; }

        /// <summary>
        /// 借款金额，单位：分
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 借款用途，枚举值： RCXF-个人日常消费 ZX-房屋装修 LY-旅游出行 JX-在职深造 JKYL-健康医疗 Others-其他消费
        /// </summary>
        [XmlElement("loan_use")]
        public string LoanUse { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部traceId
        /// </summary>
        [XmlElement("out_trace_id")]
        public string OutTraceId { get; set; }

        /// <summary>
        /// 渠道产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 还款方式，枚举值： 1-等额本息(灵活还)， 2-等额本金(灵活还)， 3-先息后本(灵活还)， 4-等额本息(按期还)
        /// </summary>
        [XmlElement("repay_method")]
        public long RepayMethod { get; set; }

        /// <summary>
        /// 请求来源 CUSTOMER-C端对应用户发起、SCHEDULER-调度发起、BACKDOOR-小二对应后台用户调用
        /// </summary>
        [XmlElement("request_source")]
        public string RequestSource { get; set; }

        /// <summary>
        /// 安全必要参数（JSON格式）
        /// </summary>
        [XmlElement("risk_info")]
        public string RiskInfo { get; set; }

        /// <summary>
        /// 协议曝光情况(0-未曝光，1-已曝光[默认])
        /// </summary>
        [XmlElement("sign_flag")]
        public long SignFlag { get; set; }

        /// <summary>
        /// 借款期数
        /// </summary>
        [XmlElement("total_term")]
        public long TotalTerm { get; set; }

        /// <summary>
        /// 借款试算咨询id
        /// </summary>
        [XmlElement("trial_serial_no")]
        public string TrialSerialNo { get; set; }

        /// <summary>
        /// 核身结束跳转的渠道侧URL
        /// </summary>
        [XmlElement("verify_callback_url")]
        public string VerifyCallbackUrl { get; set; }
    }
}
