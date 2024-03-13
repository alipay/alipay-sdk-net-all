using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEngineeringInfrastructureAllSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEngineeringInfrastructureAllSyncModel : AopObject
    {
        /// <summary>
        /// 处理来源平台 用于展示
        /// </summary>
        [XmlElement("deal_source")]
        public string DealSource { get; set; }

        /// <summary>
        /// 完结这条舆情的同学的工号
        /// </summary>
        [XmlElement("emp_id")]
        public string EmpId { get; set; }

        /// <summary>
        /// 舆情对应的id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 对于当前问题的处理。
        /// </summary>
        [XmlElement("opinion")]
        public string Opinion { get; set; }

        /// <summary>
        /// 反馈为问题缺陷，已处理完节
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
