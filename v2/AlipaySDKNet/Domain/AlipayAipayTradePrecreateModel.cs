using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayTradePrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayTradePrecreateModel : AopObject
    {
        /// <summary>
        /// 研发平台分配的智能体ID。 如果是开发者自研则自定义传入
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 智能体名称
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 订单总金额。 单位为元，精确到小数点后两位，取值范围[0.01,100000000]，金额不能为0
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商户外部订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 请求渠道来源，如mcp_1.0.0
        /// </summary>
        [XmlElement("request_channel_source")]
        public string RequestChannelSource { get; set; }
    }
}
