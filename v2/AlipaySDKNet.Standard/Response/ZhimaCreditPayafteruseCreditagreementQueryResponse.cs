using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditagreementQueryResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditagreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 开通/授权状态，VALID: 有效，INVALID: 无效
        /// </summary>
        [XmlElement("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 开通时间，agreement_status为VALID有效。
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 芝麻开通/授权协议号
        /// </summary>
        [XmlElement("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 该字段只在特殊业务场景下，根据业务方约定返回；一般业务场景下不需要消费该字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 开放ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户外部协议号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }
    }
}
