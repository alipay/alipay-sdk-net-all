using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionFundstransferQuerystatusResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionFundstransferQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 特定资金划拨场景下，内部分两阶段处理。当前字段表示中间过程的支付宝内部操作单号
        /// </summary>
        [XmlElement("additional_operate_no")]
        public string AdditionalOperateNo { get; set; }

        /// <summary>
        /// 当前查询的资金划拨记录的金额。单位：分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 当前资金划拨记录对应的「业务场景 biz_scene 」
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 资金划拨币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 资金划拨请求接口或者退款接口返回的支付宝内部受理生成的流水单号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 支付宝内部处理资金划拨相关操作涉及到的下游原始操作单号。目前只有特定场景存在关联
        /// </summary>
        [XmlElement("org_operate_no")]
        public string OrgOperateNo { get; set; }

        /// <summary>
        /// 在商户发起退款、资金划拨操作时请求参数中的「外部流水号 out_trade_no 」
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 交易成功时有值:
        /// </summary>
        [XmlElement("pay_finish_time")]
        public string PayFinishTime { get; set; }

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
        /// 特定资金划拨场景下，中间过渡户的账户户号 保证金退保至支付宝ACS账户时需要经过监管子户过桥。该场景下，当前字段需要填写 监管子户户号
        /// </summary>
        [XmlElement("relate_participant_id")]
        public string RelateParticipantId { get; set; }

        /// <summary>
        /// 资金划拨过程中，中间涉及到的过渡户的账户类型 在保证金退回场景下，需要有监管子户过桥。 当前字段必填且为「监管子户 CUSTODY_SUB_ACCOUNT 」
        /// </summary>
        [XmlElement("relate_participant_type")]
        public string RelateParticipantType { get; set; }

        /// <summary>
        /// 资金划拨请求备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 查询的当前划拨记录的资金划拨场景。
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 资金划拨结果描述，比如余额不足，账户被冻结
        /// </summary>
        [XmlElement("transfer_msg")]
        public string TransferMsg { get; set; }

        /// <summary>
        /// SUCCESS: 成功 FAIL: 失败 DEALING: 处理中 CLOSED: 已关闭
        /// </summary>
        [XmlElement("transfer_status")]
        public string TransferStatus { get; set; }
    }
}
