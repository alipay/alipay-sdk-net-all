using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionFundsTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionFundsTransferModel : AopObject
    {
        /// <summary>
        /// 协议签约通知返回的授权合约号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 资金划拨的金额。单位：分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 不同的业务场景下对应不同的业务规则
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 资金划拨币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 商户内部生成的本次资金划拨请求的请求流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 表示收款方账户是对公账户还是对私账户
        /// </summary>
        [XmlElement("payee_account_type")]
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 部分资金划拨场景，且收款方为对公账户时，对应收方账户所在行的联行号
        /// </summary>
        [XmlElement("payee_contact_line")]
        public string PayeeContactLine { get; set; }

        /// <summary>
        /// 收款方账户户号
        /// </summary>
        [XmlElement("payee_participant_id")]
        public string PayeeParticipantId { get; set; }

        /// <summary>
        /// 资金划拨请求中的收方账户户名
        /// </summary>
        [XmlElement("payee_participant_name")]
        public string PayeeParticipantName { get; set; }

        /// <summary>
        /// 收款方账户类型
        /// </summary>
        [XmlElement("payee_participant_type")]
        public string PayeeParticipantType { get; set; }

        /// <summary>
        /// 付款方账户户号
        /// </summary>
        [XmlElement("payer_participant_id")]
        public string PayerParticipantId { get; set; }

        /// <summary>
        /// 付款方账户类型
        /// </summary>
        [XmlElement("payer_participant_type")]
        public string PayerParticipantType { get; set; }

        /// <summary>
        /// 特定资金划拨场景下，中间过渡户的账户户号  保证金退保至支付宝ACS账户时需要经过监管子户过桥。该场景下，当前字段需要填写 监管子户户号
        /// </summary>
        [XmlElement("relate_participant_id")]
        public string RelateParticipantId { get; set; }

        /// <summary>
        /// 资金划拨过程中，中间涉及到的过渡户的账户类型  在保证金退回场景下，需要有监管子户过桥。 当前字段必填且为「监管子户 CUSTODY_SUB_ACCOUNT 」
        /// </summary>
        [XmlElement("relate_participant_type")]
        public string RelateParticipantType { get; set; }

        /// <summary>
        /// 资金划拨请求备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 资金划拨场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
