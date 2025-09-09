using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanHonorLendcalcConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanHonorLendcalcConsultModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝绑卡唯一id
        /// </summary>
        [XmlElement("bank_contract_id")]
        public string BankContractId { get; set; }

        /// <summary>
        /// 渠道侧用户id
        /// </summary>
        [XmlElement("channel_customer_id")]
        public string ChannelCustomerId { get; set; }

        /// <summary>
        /// 优惠券id
        /// </summary>
        [XmlElement("coupon_no")]
        public string CouponNo { get; set; }

        /// <summary>
        /// 借款金额，单位：分
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 借款试算是否返回协议(0不返回，1返回[默认])
        /// </summary>
        [XmlElement("need_contract")]
        public long NeedContract { get; set; }

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
        /// 借款期数
        /// </summary>
        [XmlElement("total_term")]
        public long TotalTerm { get; set; }
    }
}
