using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceTradeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceTradeDetail : AopObject
    {
        /// <summary>
        /// 设备序列号
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 统计时间
        /// </summary>
        [XmlElement("max_dt")]
        public string MaxDt { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("pay_mode")]
        public string PayMode { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("trade_amt")]
        public string TradeAmt { get; set; }

        /// <summary>
        /// 设备交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
