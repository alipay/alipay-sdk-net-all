using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupervisorTaskInstanceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SupervisorTaskInstanceDTO : AopObject
    {
        /// <summary>
        /// 激励信息
        /// </summary>
        [XmlElement("incentive_mode")]
        public IncentiveMode IncentiveMode { get; set; }

        /// <summary>
        /// 获取金币数
        /// </summary>
        [XmlElement("receive_point")]
        public long ReceivePoint { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [XmlElement("task_desc")]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [XmlElement("task_end_time")]
        public string TaskEndTime { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 赚钱攻略
        /// </summary>
        [XmlElement("task_rule_pic")]
        public string TaskRulePic { get; set; }

        /// <summary>
        /// 任务开始时间
        /// </summary>
        [XmlElement("task_start_time")]
        public string TaskStartTime { get; set; }

        /// <summary>
        /// 任务模板状态
        /// </summary>
        [XmlElement("template_status")]
        public string TemplateStatus { get; set; }

        /// <summary>
        /// 测试积分
        /// </summary>
        [XmlElement("test_point_amount")]
        public long TestPointAmount { get; set; }
    }
}
