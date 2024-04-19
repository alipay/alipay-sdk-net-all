using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWaterTaskModifyResponse.
    /// </summary>
    public class AlipayCommerceWaterTaskModifyResponse : AopResponse
    {
        /// <summary>
        /// 任务更新结果
        /// </summary>
        [XmlElement("task_result")]
        public bool TaskResult { get; set; }
    }
}
