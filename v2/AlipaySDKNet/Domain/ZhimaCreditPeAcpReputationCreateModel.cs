using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeAcpReputationCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeAcpReputationCreateModel : AopObject
    {
        /// <summary>
        /// 交易发起方智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 交易参与方智能体id
        /// </summary>
        [XmlElement("relate_agent_id")]
        public string RelateAgentId { get; set; }

        /// <summary>
        /// 商家侧的交易id
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }
    }
}
