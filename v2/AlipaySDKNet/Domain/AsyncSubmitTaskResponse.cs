using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AsyncSubmitTaskResponse Data Structure.
    /// </summary>
    [Serializable]
    public class AsyncSubmitTaskResponse : AopObject
    {
        /// <summary>
        /// 本次任务的id，后续使用查询接口以该 id 作为参数查询任务的执行结果
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
