using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ListCallDetailRecordsRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ListCallDetailRecordsRequest : AopObject
    {
        /// <summary>
        /// 坐席ID
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 通话ID
        /// </summary>
        [XmlElement("contact_id")]
        public string ContactId { get; set; }

        /// <summary>
        /// 通话类型
        /// </summary>
        [XmlElement("contact_type")]
        public string ContactType { get; set; }

        /// <summary>
        /// 历史通话数据的结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [XmlElement("order_by_field")]
        public string OrderByField { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 单页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 排序方式
        /// </summary>
        [XmlElement("sort_order")]
        public string SortOrder { get; set; }

        /// <summary>
        /// 历史通话数据的起始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
