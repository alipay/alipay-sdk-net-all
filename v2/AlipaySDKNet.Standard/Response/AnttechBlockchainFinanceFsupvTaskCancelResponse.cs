using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvTaskCancelResponse.
    /// </summary>
    public class AnttechBlockchainFinanceFsupvTaskCancelResponse : AopResponse
    {
        /// <summary>
        /// 资金管控任务编号
        /// </summary>
        [XmlElement("fund_supv_task_id")]
        public string FundSupvTaskId { get; set; }

        /// <summary>
        /// 任务失效
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }
    }
}
