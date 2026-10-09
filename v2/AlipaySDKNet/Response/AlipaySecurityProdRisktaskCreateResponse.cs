using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdRisktaskCreateResponse.
    /// </summary>
    public class AlipaySecurityProdRisktaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 成功创建的审理任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
