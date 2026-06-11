using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCommercialOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCommercialOrderCreateModel : AopObject
    {
        /// <summary>
        /// agent类型，当intiator_type=AGENT时必传
        /// </summary>
        [XmlElement("agent_type")]
        public string AgentType { get; set; }

        /// <summary>
        /// 本次支付关联的客户ID
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 扩展参数，JSON 格式字符串，包含企业支付等扩展信息
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 支付发起方
        /// </summary>
        [XmlElement("initiator_type")]
        public string InitiatorType { get; set; }

        /// <summary>
        /// 订单金额（单位：分），灵活定价模式下必填
        /// </summary>
        [XmlElement("order_amount")]
        public long OrderAmount { get; set; }

        /// <summary>
        /// 商品列表页code，在后台配置获取
        /// </summary>
        [XmlElement("page_code")]
        public string PageCode { get; set; }

        /// <summary>
        /// 本次支付关联的价格实例ID
        /// </summary>
        [XmlElement("price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// 订单支付成功后回跳地址
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 用户支付的收银台UI模式
        /// </summary>
        [XmlElement("ui_mode")]
        public string UiMode { get; set; }
    }
}
