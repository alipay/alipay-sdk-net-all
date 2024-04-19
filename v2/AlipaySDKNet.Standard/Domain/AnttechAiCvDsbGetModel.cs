using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiCvDsbGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiCvDsbGetModel : AopObject
    {
        /// <summary>
        /// 定损任务接口返回的task_id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
