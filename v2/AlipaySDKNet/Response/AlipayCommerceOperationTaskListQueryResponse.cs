using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTaskListQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTaskListQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否存在下一页
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 任务列表
        /// </summary>
        [XmlArray("task_list")]
        [XmlArrayItem("task_info")]
        public List<TaskInfo> TaskList { get; set; }

        /// <summary>
        /// 顶部卡片信息
        /// </summary>
        [XmlElement("task_title")]
        public TaskTitleInfo TaskTitle { get; set; }

        /// <summary>
        /// 总分页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
