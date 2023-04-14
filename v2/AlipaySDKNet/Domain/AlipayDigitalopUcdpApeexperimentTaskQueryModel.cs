using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApeexperimentTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApeexperimentTaskQueryModel : AopObject
    {
        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 操作任务id，用于查询本次操作当前的状态
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
