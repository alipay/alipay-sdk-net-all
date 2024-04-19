using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LeaseEnrollDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LeaseEnrollDTO : AopObject
    {
        /// <summary>
        /// 品牌商pid
        /// </summary>
        [XmlElement("brand_pid")]
        public string BrandPid { get; set; }

        /// <summary>
        /// 计划创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 租赁商计划报名状态，spu下有一个skuid报价就为已报价
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
