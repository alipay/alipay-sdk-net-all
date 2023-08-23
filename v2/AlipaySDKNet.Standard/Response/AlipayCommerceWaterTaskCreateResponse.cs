using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWaterTaskCreateResponse.
    /// </summary>
    public class AlipayCommerceWaterTaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 任务创建结果
        /// </summary>
        [XmlElement("task_result")]
        public bool TaskResult { get; set; }
    }
}
