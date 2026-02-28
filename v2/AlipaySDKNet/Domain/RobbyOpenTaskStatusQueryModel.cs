using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RobbyOpenTaskStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class RobbyOpenTaskStatusQueryModel : AopObject
    {
        /// <summary>
        /// 子业务编号，全局唯一
        /// </summary>
        [XmlElement("sub_biz_no")]
        public string SubBizNo { get; set; }

        /// <summary>
        /// 灵波任务指令编号
        /// </summary>
        [XmlElement("task_no")]
        public string TaskNo { get; set; }
    }
}
