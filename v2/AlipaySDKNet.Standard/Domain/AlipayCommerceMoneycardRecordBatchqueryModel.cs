using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMoneycardRecordBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMoneycardRecordBatchqueryModel : AopObject
    {
        /// <summary>
        /// 核销结束时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 分页页码，单位页，最小为1，最大为10000
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 分页查询中分页大小，单位条，最小为1，最大为100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 核销开始时间，格式 yyyy-MM-dd HH:mm:ss， 核销开始时间必须小于核销结束时间； 开始时间和结束时间不能相差超过30天； 开始时间和结束时间只能同时存在或者同时不存在
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 收单支付宝商户pid
        /// </summary>
        [XmlElement("trade_pid")]
        public string TradePid { get; set; }
    }
}
