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
        /// 业务场景 + 关联账户号 + 待开通子户类型。 三个唯一确定一个最终开通的子户账号
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
        /// 外部用户id，专款钱包场景下，根据当前字段创建对应专款钱包账户。
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 待开子户对关联账户名
        /// </summary>
        [XmlElement("parent_ext_account_name")]
        public string ParentExtAccountName { get; set; }

        /// <summary>
        /// 待开子户的关联账户号。 驾校在网商申请的最终结算户。
        /// </summary>
        [XmlElement("parent_ext_account_no")]
        public string ParentExtAccountNo { get; set; }

        /// <summary>
        /// 专款钱包场景下钱包子户的收方客户类型， 对公账户需要填入收方账户联行号
        /// </summary>
        [XmlElement("payee_account_type")]
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 专款钱包场景下，当收方账户为对公账户，则需要填入收方账户联行号
        /// </summary>
        [XmlElement("payee_contact_line")]
        public string PayeeContactLine { get; set; }

        /// <summary>
        /// 专款钱包场景下钱包子户的收方账户ID
        /// </summary>
        [XmlElement("payee_participant_id")]
        public string PayeeParticipantId { get; set; }

        /// <summary>
        /// 收方账户名
        /// </summary>
        [XmlElement("payee_participant_name")]
        public string PayeeParticipantName { get; set; }

        /// <summary>
        /// 专款钱包场景下钱包子户的收方账户类型
        /// </summary>
        [XmlElement("payee_participant_type")]
        public string PayeeParticipantType { get; set; }

        /// <summary>
        /// 专款钱包场景下钱包子户的付方账户ID
        /// </summary>
        [XmlElement("payer_participant_id")]
        public string PayerParticipantId { get; set; }

        /// <summary>
        /// 专款钱包场景下钱包子户的付方账户名
        /// </summary>
        [XmlElement("payer_participant_name")]
        public string PayerParticipantName { get; set; }

        /// <summary>
        /// 专款钱包场景下钱包子户的付方账户类型
        /// </summary>
        [XmlElement("payer_participant_type")]
        public string PayerParticipantType { get; set; }

        /// <summary>
        /// 专款资金金额，整数，单位：分  资金划拨时根据本次输入金额进行划付校验
        /// </summary>
        [XmlElement("special_funds_amount")]
        public long SpecialFundsAmount { get; set; }

        /// <summary>
        /// 币种，默认 CNY。目前只支持CNY
        /// </summary>
        [XmlElement("special_funds_currency")]
        public string SpecialFundsCurrency { get; set; }

        /// <summary>
        /// 业务场景+ 待开子户关联账户+待开通子户类型 biz_scene + parent_ext_account_no +sub_account_type  最终申请出唯一的对应子户。
        /// </summary>
        [XmlElement("sub_account_type")]
        public string SubAccountType { get; set; }
    }
}
