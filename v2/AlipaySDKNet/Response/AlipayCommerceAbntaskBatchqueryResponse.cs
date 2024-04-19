using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAbntaskBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceAbntaskBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码，不传默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数据量，正整数，不传默认为1000，超过1000也认定为1000
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 任务信息列表
        /// </summary>
        [XmlArray("task_list")]
        [XmlArrayItem("abn_task_info")]
        public List<AbnTaskInfo> TaskList { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
