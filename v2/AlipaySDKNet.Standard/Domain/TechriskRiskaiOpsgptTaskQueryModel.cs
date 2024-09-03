using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskRiskaiOpsgptTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskRiskaiOpsgptTaskQueryModel : AopObject
    {
        /// <summary>
        /// 提交任务成功后返回的任务id，用户需要使用该 id 调用任务查询接口轮询任务结果
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
