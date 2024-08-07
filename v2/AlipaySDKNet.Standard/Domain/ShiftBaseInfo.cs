using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShiftBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShiftBaseInfo : AopObject
    {
        /// <summary>
        /// 班次唯一编号
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 星云租户下小二的唯一身份标识
        /// </summary>
        [XmlElement("nebula_user_id")]
        public string NebulaUserId { get; set; }

        /// <summary>
        /// 当前班次结束时间,单位/s
        /// </summary>
        [XmlElement("pb_end_time")]
        public string PbEndTime { get; set; }

        /// <summary>
        /// 当前班次开始时间，单位/s
        /// </summary>
        [XmlElement("pb_start_time")]
        public string PbStartTime { get; set; }

        /// <summary>
        /// 班次类型
        /// </summary>
        [XmlElement("shift_type")]
        public string ShiftType { get; set; }

        /// <summary>
        /// 星云技能组列表，一般只有一个
        /// </summary>
        [XmlArray("skill_group_id_list")]
        [XmlArrayItem("string")]
        public List<string> SkillGroupIdList { get; set; }

        /// <summary>
        /// 星云租户ID，开放平台appid对应
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
