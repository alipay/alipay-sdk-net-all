using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RobbyOpenTaskCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class RobbyOpenTaskCancelModel : AopObject
    {
        /// <summary>
        /// 机器人编号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

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
