using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SyncVoiceVO Data Structure.
    /// </summary>
    [Serializable]
    public class SyncVoiceVO : AopObject
    {
        /// <summary>
        /// 播报的金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 合并播报开关，默认为0。设置为1后用于短时间内同时发生多笔播报时，优化播报提示内容。如支付宝到账1元、2元、3元
        /// </summary>
        [XmlElement("merge_switch")]
        public long MergeSwitch { get; set; }

        /// <summary>
        /// 金额播报开关。置为0则只会播报到账提示音，不会播报具体金额。
        /// </summary>
        [XmlElement("money_switch")]
        public long MoneySwitch { get; set; }

        /// <summary>
        /// 支付的渠道类型
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 交易id
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }
    }
}
