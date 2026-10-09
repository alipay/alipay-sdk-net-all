using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWaterTaskFinishResponse.
    /// </summary>
    public class AlipayCommerceWaterTaskFinishResponse : AopResponse
    {
        /// <summary>
        /// 结束任务结果
        /// </summary>
        [XmlElement("task_result")]
        public bool TaskResult { get; set; }
    }
}
