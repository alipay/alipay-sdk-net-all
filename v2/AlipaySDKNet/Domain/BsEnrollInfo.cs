using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsEnrollInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BsEnrollInfo : AopObject
    {
        /// <summary>
        /// 报名id
        /// </summary>
        [XmlElement("enroll_id")]
        public string EnrollId { get; set; }

        /// <summary>
        /// 该计划报名的剩余权益库存
        /// </summary>
        [XmlElement("remain_stock")]
        public long RemainStock { get; set; }

        /// <summary>
        /// 报名的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 报名进行到当前状态的原因
        /// </summary>
        [XmlElement("status_reason")]
        public string StatusReason { get; set; }

        /// <summary>
        /// 报名对象id，可以是商户pid
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 参与计划的权益总库存
        /// </summary>
        [XmlElement("total_stock")]
        public long TotalStock { get; set; }

        /// <summary>
        /// 报名信息更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
