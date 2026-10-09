using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionAccountModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionAccountModifyModel : AopObject
    {
        /// <summary>
        /// 待修改属性的子户账户户号。对应「政务监管账户创建」接口返回的 「子户账户户号 merchant_account_no 」
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 不同的业务场景下对应不同的业务规则
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 企业支付宝账户uid对应OpenID
        /// </summary>
        [XmlElement("merchant_alipay_open_id")]
        public string MerchantAlipayOpenId { get; set; }

        /// <summary>
        /// 企业支付宝账户uid
        /// </summary>
        [XmlElement("merchant_alipay_uid")]
        public string MerchantAlipayUid { get; set; }

        /// <summary>
        /// 专款钱包场景下钱包子户的收方客户类型， 对公账户需要填入收方账户联行号
        /// </summary>
        [XmlElement("payee_account_type")]
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 当收方账户为对公账户，则需要填入收方账户联行号
        /// </summary>
        [XmlElement("payee_contact_line")]
        public string PayeeContactLine { get; set; }

        /// <summary>
        /// 资金划拨支付的收款方账户户号
        /// </summary>
        [XmlElement("payee_participant_id")]
        public string PayeeParticipantId { get; set; }

        /// <summary>
        /// 资金划拨支付的收款方账户户名
        /// </summary>
        [XmlElement("payee_participant_name")]
        public string PayeeParticipantName { get; set; }

        /// <summary>
        /// 资金划拨支付的收款方账户类型
        /// </summary>
        [XmlElement("payee_participant_type")]
        public string PayeeParticipantType { get; set; }

        /// <summary>
        /// 资金转入子户时的付款方账户户号
        /// </summary>
        [XmlElement("payer_participant_id")]
        public string PayerParticipantId { get; set; }

        /// <summary>
        /// 资金转入子户时的付款方账户户名
        /// </summary>
        [XmlElement("payer_participant_name")]
        public string PayerParticipantName { get; set; }

        /// <summary>
        /// 资金转入子户时的付款方账户类型
        /// </summary>
        [XmlElement("payer_participant_type")]
        public string PayerParticipantType { get; set; }

        /// <summary>
        /// 专款资金金额，整数，单位：分
        /// </summary>
        [XmlElement("special_funds_amount")]
        public long SpecialFundsAmount { get; set; }

        /// <summary>
        /// 币种，默认 CNY。目前只支持CNY
        /// </summary>
        [XmlElement("special_funds_currency")]
        public string SpecialFundsCurrency { get; set; }
    }
}
