using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneServiceOrderQueryResponse.
    /// </summary>
    public class AlipayInsSceneServiceOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 服务止期
        /// </summary>
        [XmlElement("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 服务起期
        /// </summary>
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }
    }
}
