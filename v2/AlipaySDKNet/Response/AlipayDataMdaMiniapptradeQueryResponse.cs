using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaMiniapptradeQueryResponse.
    /// </summary>
    public class AlipayDataMdaMiniapptradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 今日告警趋势、响应趋势
        /// </summary>
        [XmlElement("resp_alarm_trend")]
        public string RespAlarmTrend { get; set; }

        /// <summary>
        /// 告警响应率
        /// </summary>
        [XmlElement("trade_alarm_response_rate")]
        public string TradeAlarmResponseRate { get; set; }

        /// <summary>
        /// 调用平均耗时
        /// </summary>
        [XmlElement("trade_avg_cost")]
        public string TradeAvgCost { get; set; }

        /// <summary>
        /// 支付接口调用成功率
        /// </summary>
        [XmlElement("trade_success_rate")]
        public string TradeSuccessRate { get; set; }

        /// <summary>
        /// 支付接口调用成功量
        /// </summary>
        [XmlElement("trade_today_interface_success")]
        public long TradeTodayInterfaceSuccess { get; set; }

        /// <summary>
        /// 今日累计成功量
        /// </summary>
        [XmlElement("trade_today_total_success")]
        public long TradeTodayTotalSuccess { get; set; }

        /// <summary>
        /// 今日累计告警次数
        /// </summary>
        [XmlElement("trade_total_fault")]
        public long TradeTotalFault { get; set; }

        /// <summary>
        /// 今日累计告警响应
        /// </summary>
        [XmlElement("trade_total_resp_count")]
        public long TradeTotalRespCount { get; set; }
    }
}
