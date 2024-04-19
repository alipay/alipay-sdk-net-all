using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskOperationQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskOperationQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 操作记录列表
        /// </summary>
        [XmlArray("task_operation_logs")]
        [XmlArrayItem("task_template_operation_log_d_t_o")]
        public List<TaskTemplateOperationLogDTO> TaskOperationLogs { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
