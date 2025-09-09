using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskJointdecisionTradeSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskJointdecisionTradeSendModel : AopObject
    {
        /// <summary>
        /// 外部交易号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 01：暂停发货；02：延迟结算；03：关停账户；04：暂停发货+关停账户；05：延迟结算+关停账户；06：订单拦截中；07：订单已退款；08：订单已履约交付无法退款；09：其他
        /// </summary>
        [XmlElement("risk_trade_feedback")]
        public string RiskTradeFeedback { get; set; }

        /// <summary>
        /// 风险交易处置时间,格式YYYYMMDD
        /// </summary>
        [XmlElement("risk_trade_feedback_time")]
        public string RiskTradeFeedbackTime { get; set; }

        /// <summary>
        /// 场景号 01联合决策交易处理结果回传 02商家主动感知风险交易推送 03联合决策客诉处理结果回传 04潜在风险交易预警处理结果回传
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 二级商户id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 投诉id（案件号）,场景编码为03时必传
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
