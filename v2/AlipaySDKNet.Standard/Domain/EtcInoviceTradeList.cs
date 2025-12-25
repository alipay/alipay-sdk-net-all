using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcInoviceTradeList Data Structure.
    /// </summary>
    [Serializable]
    public class EtcInoviceTradeList : AopObject
    {
        /// <summary>
        /// 税额（可抵扣金额）单位：分
        /// </summary>
        [XmlElement("allowance_amount")]
        public long AllowanceAmount { get; set; }

        /// <summary>
        /// 消费类型
        /// </summary>
        [XmlElement("consumer_trans_type")]
        public string ConsumerTransType { get; set; }

        /// <summary>
        /// 出口收费站
        /// </summary>
        [XmlElement("end_station_name")]
        public string EndStationName { get; set; }

        /// <summary>
        /// 出站时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 开票状态
        /// </summary>
        [XmlElement("invoice_progress_status")]
        public string InvoiceProgressStatus { get; set; }

        /// <summary>
        /// 入口收费站
        /// </summary>
        [XmlElement("start_station_name")]
        public string StartStationName { get; set; }

        /// <summary>
        /// 进站时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 交易金额单位,分
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }
    }
}
