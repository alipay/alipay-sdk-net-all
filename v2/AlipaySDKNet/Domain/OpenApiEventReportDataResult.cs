using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiEventReportDataResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiEventReportDataResult : AopObject
    {
        /// <summary>
        /// 在接口返回时,如果syncQueryResultValid为false,那么这是一个异步查询，请根据asyncQueryId和asyncQueryStatus继续查询
        /// </summary>
        [XmlElement("async_query_id")]
        public string AsyncQueryId { get; set; }

        /// <summary>
        /// 异步查询时，轮训结果的状态，只有SUCCESS时才有数据
        /// </summary>
        [XmlElement("async_query_status")]
        public string AsyncQueryStatus { get; set; }

        /// <summary>
        /// 事件的具体数据,包含事件的维度属性和指标数值
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("open_api_event_report_item_v_o")]
        public List<OpenApiEventReportItemVO> Items { get; set; }

        /// <summary>
        /// 同步查询结果可用 如果这个值为true, 那么这是一次同步查询, 如果为false,那么这是一个异步查询，请根据asyncQueryId继续查询
        /// </summary>
        [XmlElement("sync_query_result_valid")]
        public bool SyncQueryResultValid { get; set; }
    }
}
