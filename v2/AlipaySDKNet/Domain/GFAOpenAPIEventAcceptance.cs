using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GFAOpenAPIEventAcceptance Data Structure.
    /// </summary>
    [Serializable]
    public class GFAOpenAPIEventAcceptance : AopObject
    {
        /// <summary>
        /// 代收付参与者信息
        /// </summary>
        [XmlElement("agent_participant")]
        public GFAOpenAPIParticipantInfo AgentParticipant { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 应该付金额
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 金额币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 受理的事件码
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 业务的触发时间（毫秒时间戳）
        /// </summary>
        [XmlElement("gmt_biz_trigger")]
        public string GmtBizTrigger { get; set; }

        /// <summary>
        /// 高精度账单金额
        /// </summary>
        [XmlElement("high_precision_bill_amount")]
        public string HighPrecisionBillAmount { get; set; }

        /// <summary>
        /// 未付金额
        /// </summary>
        [XmlElement("nonpayment_amount")]
        public string NonpaymentAmount { get; set; }

        /// <summary>
        /// 收款参与者信息
        /// </summary>
        [XmlElement("payee_participant")]
        public GFAOpenAPIParticipantInfo PayeeParticipant { get; set; }

        /// <summary>
        /// 付款参与者信息
        /// </summary>
        [XmlElement("payer_participant")]
        public GFAOpenAPIParticipantInfo PayerParticipant { get; set; }

        /// <summary>
        /// 业财事件受理参数
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 已付金额
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 服务量
        /// </summary>
        [XmlElement("service_amount")]
        public long ServiceAmount { get; set; }

        /// <summary>
        /// 结算参与者信息
        /// </summary>
        [XmlElement("settle_participant")]
        public GFAOpenAPIParticipantInfo SettleParticipant { get; set; }

        /// <summary>
        /// 签约参与者信息
        /// </summary>
        [XmlElement("sign_participant")]
        public GFAOpenAPIParticipantInfo SignParticipant { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("system_origin")]
        public string SystemOrigin { get; set; }

        /// <summary>
        /// 税收金额
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 事件触发模式，默认为SYN，长度必须小于等于16
        /// </summary>
        [XmlElement("trigger_pattern")]
        public string TriggerPattern { get; set; }
    }
}
