using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentCommercialStoretaskBatchqueryResponse.
    /// </summary>
    public class AlipayContentCommercialStoretaskBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 任务列表
        /// </summary>
        [XmlArray("live_task_list")]
        [XmlArrayItem("live_task_list")]
        public List<LiveTaskList> LiveTaskList { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，单位条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数，单位条
        /// </summary>
        [XmlElement("total")]
        public string Total { get; set; }
    }
}
