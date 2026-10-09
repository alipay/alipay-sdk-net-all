using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiEventReportCommRequest Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiEventReportCommRequest : AopObject
    {
        /// <summary>
        /// 由于自定义报表分析接口数据查询较大，如果查询的入参时间跨度较大，接口返回容易超时，故会返回此字段，用于带入下一次的同接口查询。
        /// </summary>
        [XmlElement("async_query_id")]
        public string AsyncQueryId { get; set; }

        /// <summary>
        /// 结束日期，不传默认取当前日期的前一天（T-1）的日期，比如今天20240102，则取值 20240101
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 事件名称，用于对事件概况数据的过滤
        /// </summary>
        [XmlArray("events")]
        [XmlArrayItem("string")]
        public List<string> Events { get; set; }

        /// <summary>
        /// 默认取当前操作的支付宝app_id，数据的主体依据条件，在查询其他端小程序数据的时候传入multi_app_id
        /// </summary>
        [XmlElement("multi_app_id")]
        public string MultiAppId { get; set; }

        /// <summary>
        /// 属性名列表，用于过滤和筛选事件分析详情数据,该参数目前仅用于事件分析详情接口
        /// </summary>
        [XmlArray("properties")]
        [XmlArrayItem("string")]
        public List<string> Properties { get; set; }

        /// <summary>
        /// 数据查询的开始时间，默认不传取最近一周的日期,根据endDate往前倒推7天取值
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
