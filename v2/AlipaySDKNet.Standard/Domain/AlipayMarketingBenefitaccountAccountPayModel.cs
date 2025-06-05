using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingBenefitaccountAccountPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingBenefitaccountAccountPayModel : AopObject
    {
        /// <summary>
        /// 充值金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 权益账户号
        /// </summary>
        [XmlElement("benefit_account_no")]
        public string BenefitAccountNo { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 业务当本次充值唯一号，用于幂等
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 扩展字段，用于风控参数透传
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 出资账号用户ID
        /// </summary>
        [XmlElement("fund_user_id")]
        public string FundUserId { get; set; }

        /// <summary>
        /// 创建人用户ID
        /// </summary>
        [XmlElement("publisher_user_id")]
        public string PublisherUserId { get; set; }

        /// <summary>
        /// 支付成功跳转url
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
