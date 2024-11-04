using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditInfoDTO : AopObject
    {
        /// <summary>
        /// 芝麻先享受理台用户开通成功后，商家自定义页面跳转地址
        /// </summary>
        [XmlElement("acceptance_jump_url")]
        public string AcceptanceJumpUrl { get; set; }

        /// <summary>
        /// 芝麻免押周期扣款类型，使用芝麻免押产品时该字段必传
        /// </summary>
        [XmlElement("credit_deposit_period_pay_type")]
        public string CreditDepositPeriodPayType { get; set; }

        /// <summary>
        /// 使用芝麻信用服务的产品码，不传默认使用芝麻先享服务
        /// </summary>
        [XmlElement("credit_product_code")]
        public string CreditProductCode { get; set; }

        /// <summary>
        /// 使用芝麻信用先享服务，是否不需要核身，默认false：表示需要当前订单需要核身
        /// </summary>
        [XmlElement("no_need_verify_identity")]
        public bool NoNeedVerifyIdentity { get; set; }

        /// <summary>
        /// 商户外部协议号，不同的支付宝用户需要传递不同的外部单号,使用芝麻先享能力必传
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// 传smid在芝麻侧生成的信用服务id,使用芝麻先享能力必传
        /// </summary>
        [XmlElement("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
