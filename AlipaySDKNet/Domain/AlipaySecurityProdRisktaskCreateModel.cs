using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdRisktaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdRisktaskCreateModel : AopObject
    {
        /// <summary>
        /// 外部业务流水号，可支持根据外部业务流水号判断任务重复创建
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 任务风险信息，描述业务场景或者审理上下文的键值对,可在任务审理阶段展示
        /// </summary>
        [XmlElement("risk_info")]
        public string RiskInfo { get; set; }

        /// <summary>
        /// 风险任务备注
        /// </summary>
        [XmlElement("risk_task_memo")]
        public string RiskTaskMemo { get; set; }

        /// <summary>
        /// 任务来源
        /// </summary>
        [XmlElement("task_source")]
        public string TaskSource { get; set; }

        /// <summary>
        /// 生成的审理任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 审理任务对应的租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
