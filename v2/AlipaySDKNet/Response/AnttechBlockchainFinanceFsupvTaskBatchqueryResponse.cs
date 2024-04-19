using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvTaskBatchqueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceFsupvTaskBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 任务列表
        /// </summary>
        [XmlArray("task_list")]
        [XmlArrayItem("supv_fund_task")]
        public List<SupvFundTask> TaskList { get; set; }

        /// <summary>
        /// 任务数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
