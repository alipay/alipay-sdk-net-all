using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionAccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionAccountCreateModel : AopObject
    {
        /// <summary>
        /// 1:  支持异名打款 自动退  0: 不支持 。 默认为 1
        /// </summary>
        [XmlElement("auto_refund")]
        public string AutoRefund { get; set; }

        /// <summary>
        /// 不同的业务场景走不同业务规则
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 企业支付宝账户uid 对应open_id 用于获取企业账户信息，创建对应的监管子户
        /// </summary>
        [XmlElement("merchant_alipay_open_id")]
        public string MerchantAlipayOpenId { get; set; }

        /// <summary>
        /// 企业支付宝账户uid。用于获取企业账户信息，创建对应的监管子户
        /// </summary>
        [XmlElement("merchant_alipay_uid")]
        public string MerchantAlipayUid { get; set; }

        /// <summary>
        /// 外部用户id。专款钱包场景下，根据当前字段创建对应唯一的子户账户户号。根据业务诉求，可以传入调用方自己维护的冻资订单单号或者调用方自己维护的用户id
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 协会、商户在银行侧自行创建的结算户账户户名，创建子户时由服务商调用接口传入
        /// </summary>
        [XmlElement("parent_ext_account_name")]
        public string ParentExtAccountName { get; set; }

        /// <summary>
        /// 协会、商户在银行侧自行创建的结算户账户户号
        /// </summary>
        [XmlElement("parent_ext_account_no")]
        public string ParentExtAccountNo { get; set; }

        /// <summary>
        /// 业务场景为专款钱包 SPECIAL_FUNDS 场景下，收款方客户类型对公账户需要填入收款方账户联行号
        /// </summary>
        [XmlElement("payee_account_type")]
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 业务场景为专款钱包 SPECIAL_FUNDS 场景下，当收款方账户为对公账户，则需要填入收款方账户联行号
        /// </summary>
        [XmlElement("payee_contact_line")]
        public string PayeeContactLine { get; set; }

        /// <summary>
        /// 业务场景为专款钱包 SPECIAL_FUNDS 场景下。转入子户时的收款方账户户号
        /// </summary>
        [XmlElement("payee_participant_id")]
        public string PayeeParticipantId { get; set; }

        /// <summary>
        /// 业务场景为专款钱包 SPECIAL_FUNDS 场景下。子户转出时的收款方账户户名。
        /// </summary>
        [XmlElement("payee_participant_name")]
        public string PayeeParticipantName { get; set; }

        /// <summary>
        /// 业务场景为专款钱包 SPECIAL_FUNDS 场景下。子户转出时的收款方账户类型
        /// </summary>
        [XmlElement("payee_participant_type")]
        public string PayeeParticipantType { get; set; }

        /// <summary>
        /// 业务场景为专款钱包 SPECIAL_FUNDS 场景下。后续资金转入子户时的付款方账户户号
        /// </summary>
        [XmlElement("payer_participant_id")]
        public string PayerParticipantId { get; set; }

        /// <summary>
        /// 业务场景为专款钱包 SPECIAL_FUNDS 场景下。转入子户时的付款方账户户名,在后续资金划拨请求中会校验资金划拨请求中的收方账户户名是否是本次开户请求的收款方账户户名或者是付款方账户户名
        /// </summary>
        [XmlElement("payer_participant_name")]
        public string PayerParticipantName { get; set; }

        /// <summary>
        /// 业务场景为专款钱包 SPECIAL_FUNDS 场景下。转入子户时的付款方账户类型
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

        /// <summary>
        /// 本次在银行侧创建的子户账户类型。根据业务诉求选择对应账户类型
        /// </summary>
        [XmlElement("sub_account_type")]
        public string SubAccountType { get; set; }
    }
}
