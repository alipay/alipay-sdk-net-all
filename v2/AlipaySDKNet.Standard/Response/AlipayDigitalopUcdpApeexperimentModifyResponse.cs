using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApeexperimentModifyResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApeexperimentModifyResponse : AopResponse
    {
        /// <summary>
        /// 操作任务Id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
