using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayAgentPaymentPrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayAgentPaymentPrecreateModel : AopObject
    {
        /// <summary>
        /// 接口付费金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 仅支持CNY
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 商品/服务名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 交易备注，用于账单备注展示，可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户自身订单号，用于幂等控制
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付截止时间，超过后禁止支付
        /// </summary>
        [XmlElement("pay_before")]
        public string PayBefore { get; set; }

        /// <summary>
        /// 按量付费注册分配的服务id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
