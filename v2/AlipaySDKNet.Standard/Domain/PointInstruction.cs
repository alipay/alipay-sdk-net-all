using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PointInstruction Data Structure.
    /// </summary>
    [Serializable]
    public class PointInstruction : AopObject
    {
        /// <summary>
        /// 流水动作 RECEIVE 积分发放 EXCHANGE 积分兑换
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 积分数量，单位个
        /// </summary>
        [XmlElement("point_amount")]
        public string PointAmount { get; set; }

        /// <summary>
        /// 积分类型
        /// </summary>
        [XmlElement("point_type")]
        public string PointType { get; set; }

        /// <summary>
        /// 失败的原因文案描述，例如失败原因为账号异常问题，转账失败等。
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 状态 SUCCESS 成功 PROCCESSING 处理中 FAIL 失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
