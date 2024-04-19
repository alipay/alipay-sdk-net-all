using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceSkillgroupFreenumberQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceSkillgroupFreenumberQueryModel : AopObject
    {
        /// <summary>
        /// 实例ID
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 第几页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 技能组的ID
        /// </summary>
        [XmlElement("skill_group_id")]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// 要查询坐席的状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
