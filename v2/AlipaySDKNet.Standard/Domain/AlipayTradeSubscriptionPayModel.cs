using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSubscriptionPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSubscriptionPayModel : AopObject
    {
        /// <summary>
        /// 发起扣款的交易单据超时自动关单时间，支持m（分钟）和h（小时），默认为空时命中兜底的10m
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 扩展参数，用于订阅特殊能力的传参，使用方式详见具体场景接入指南
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 商户侧外部单号，幂等键。一致则重新唤起原单支付，不一致则重新创单。注意：支卡通金额有变化时，必须创建新的外部单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 扣款总金额，商户自定义，不超过签约时协议金额（席位单价 × 席位数），单位：分，String 格式
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 订阅id，订阅唯一标识
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
