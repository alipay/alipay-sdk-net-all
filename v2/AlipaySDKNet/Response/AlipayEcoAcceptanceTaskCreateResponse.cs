using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoAcceptanceTaskCreateResponse.
    /// </summary>
    public class AlipayEcoAcceptanceTaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建的任务ID
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 结果记录条数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
