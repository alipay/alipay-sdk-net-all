using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceTradevoiceSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceTradevoiceSendModel : AopObject
    {
        /// <summary>
        /// 播报的金额，必须大于0
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 语料资源的消息id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 间连商户id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 交易订单id,生产环境必传。 工厂验收设备的时候可不传，通过白名单管控。
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 交易类型 可选值: ALIPAY_TRADE 支付宝交易  OTHER 其他交易途径
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
