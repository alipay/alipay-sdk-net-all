using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DriverTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DriverTradeInfo : AopObject
    {
        /// <summary>
        /// 交易日期
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 支付宝司机open_id
        /// </summary>
        [XmlElement("driver_open_id")]
        public string DriverOpenId { get; set; }

        /// <summary>
        /// 支付宝司机uid
        /// </summary>
        [XmlElement("driver_user_id")]
        public string DriverUserId { get; set; }

        /// <summary>
        /// Y-风控，N-不风控，null或空代表不风控
        /// </summary>
        [XmlElement("risk_control")]
        public string RiskControl { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 订单金额(单位分)
        /// </summary>
        [XmlElement("trade_total_amount")]
        public string TradeTotalAmount { get; set; }
    }
}
