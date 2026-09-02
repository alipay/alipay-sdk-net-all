using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeAgentDelegationPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeAgentDelegationPayModel : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务单号列表，单笔支付场景塞一个业务单号值。 合并支付场景塞多笔订单，英文逗号分割。
        /// </summary>
        [XmlElement("biz_order_no")]
        public string BizOrderNo { get; set; }

        /// <summary>
        /// 代买委托id
        /// </summary>
        [XmlElement("delegation_id")]
        public string DelegationId { get; set; }

        /// <summary>
        /// 传阶段号out_relation_id的值。  如果不传，则用交易号作为本次请求号，意味着是整笔订单支付。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 预下单ID，通过请求alipay.trade.order.prepay接口获取预下单ID
        /// </summary>
        [XmlElement("prepay_id")]
        public string PrepayId { get; set; }
    }
}
