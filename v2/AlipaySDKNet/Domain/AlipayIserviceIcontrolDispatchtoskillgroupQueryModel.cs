using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIcontrolDispatchtoskillgroupQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIcontrolDispatchtoskillgroupQueryModel : AopObject
    {
        /// <summary>
        /// 坐席id
        /// </summary>
        [XmlElement("seat_id")]
        public string SeatId { get; set; }

        /// <summary>
        /// 坐席类型
        /// </summary>
        [XmlElement("seat_type")]
        public string SeatType { get; set; }

        /// <summary>
        /// 服务唯一标识
        /// </summary>
        [XmlElement("service_uniq_code")]
        public string ServiceUniqCode { get; set; }

        /// <summary>
        /// 技能组id
        /// </summary>
        [XmlElement("skill_group_id")]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// 技能组类型
        /// </summary>
        [XmlElement("skill_group_type")]
        public string SkillGroupType { get; set; }

        /// <summary>
        /// 调度结果状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
