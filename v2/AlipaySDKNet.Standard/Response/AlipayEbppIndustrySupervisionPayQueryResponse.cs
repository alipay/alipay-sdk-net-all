using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionPayQueryResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionPayQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付单金额，单位:分  示例: 100元则传入 "10000"
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 币种 "CNY"
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 外部流水号，本次创建支付单的请求id，重复请求幂等返回
        /// </summary>
        [XmlElement("out_flow_id")]
        public string OutFlowId { get; set; }

        /// <summary>
        /// 外部订单号，本次发起支付关联的冻资单id
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付单状态: INIT: 待处理;DEALING: 处理中;SUCCESS: 成功;FAIL: 失败;CLOSED: 已关闭;RETURN: 退回
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 收银台展示的支付标题
        /// </summary>
        [XmlElement("pay_title")]
        public string PayTitle { get; set; }

        /// <summary>
        /// 收款方主体信息，结构字符串BASE64加密
        /// </summary>
        [XmlElement("payee_participant_info")]
        public string PayeeParticipantInfo { get; set; }

        /// <summary>
        /// 付款方主体信息，结构字符串BASE64加密
        /// </summary>
        [XmlElement("payer_participant_info")]
        public string PayerParticipantInfo { get; set; }

        /// <summary>
        /// 账单侧显示备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 支付宝创建的内部支付单号。后续后续根据流水号或者外部订单号查询。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
