using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaxiOrderDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TaxiOrderDetail : AopObject
    {
        /// <summary>
        /// 订单金额-元
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 风控原因（未触发发奖时给出，触发发奖时为空）
        /// </summary>
        [XmlElement("risk_control_reason")]
        public string RiskControlReason { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }

        /// <summary>
        /// 是否触发激励发奖 true false
        /// </summary>
        [XmlElement("triggered_award")]
        public bool TriggeredAward { get; set; }
    }
}
