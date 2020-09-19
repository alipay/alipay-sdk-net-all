using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRopgnRisktaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRopgnRisktaskCreateModel : AopObject
    {
        /// <summary>
        /// 任务扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 业务系统流水号
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 任务来源
        /// </summary>
        [XmlElement("task_source")]
        public string TaskSource { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 租户，目前只有ALIPW3CN这一个租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
