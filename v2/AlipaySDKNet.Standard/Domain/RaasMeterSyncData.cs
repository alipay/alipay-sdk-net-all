using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RaasMeterSyncData Data Structure.
    /// </summary>
    [Serializable]
    public class RaasMeterSyncData : AopObject
    {
        /// <summary>
        /// 聚合的项
        /// </summary>
        [XmlElement("aggregate_term")]
        public string AggregateTerm { get; set; }

        /// <summary>
        /// 聚合的值
        /// </summary>
        [XmlElement("aggregate_value")]
        public string AggregateValue { get; set; }

        /// <summary>
        /// 计量项
        /// </summary>
        [XmlElement("amount_term")]
        public string AmountTerm { get; set; }

        /// <summary>
        /// 业务描述
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 计量上报的渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 计量数
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 唯一键
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 上报结束时间
        /// </summary>
        [XmlElement("gmt_end_time")]
        public string GmtEndTime { get; set; }

        /// <summary>
        /// 上报开始时间
        /// </summary>
        [XmlElement("gmt_start_time")]
        public string GmtStartTime { get; set; }

        /// <summary>
        /// 计量域的值，用于映射计费使用的
        /// </summary>
        [XmlElement("meter_domain")]
        public string MeterDomain { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 上报的站点
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 状态值
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 时间分区
        /// </summary>
        [XmlElement("time_partition")]
        public string TimePartition { get; set; }

        /// <summary>
        /// 时区
        /// </summary>
        [XmlElement("time_zone")]
        public string TimeZone { get; set; }
    }
}
