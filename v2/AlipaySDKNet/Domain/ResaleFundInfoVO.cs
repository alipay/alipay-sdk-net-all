using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResaleFundInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ResaleFundInfoVO : AopObject
    {
        /// <summary>
        /// 支付金额（元）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 外部资金id
        /// </summary>
        [XmlElement("out_request_id")]
        public string OutRequestId { get; set; }

        /// <summary>
        /// 支付说明
        /// </summary>
        [XmlElement("trade_memo")]
        public string TradeMemo { get; set; }

        /// <summary>
        /// 关联交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 资金属性
        /// </summary>
        [XmlElement("trade_prop")]
        public string TradeProp { get; set; }

        /// <summary>
        /// 支付状态
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 资金子类型
        /// </summary>
        [XmlElement("trade_sub_type")]
        public string TradeSubType { get; set; }

        /// <summary>
        /// 交易完成时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }

        /// <summary>
        /// 付款、分账、结算、退款
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
