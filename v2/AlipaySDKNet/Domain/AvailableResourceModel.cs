using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AvailableResourceModel Data Structure.
    /// </summary>
    [Serializable]
    public class AvailableResourceModel : AopObject
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 可用资源信息
        /// </summary>
        [XmlArray("resources")]
        [XmlArrayItem("available_seat_model")]
        public List<AvailableSeatModel> Resources { get; set; }

        /// <summary>
        /// 技能组code
        /// </summary>
        [XmlElement("skill_group_code")]
        public string SkillGroupCode { get; set; }

        /// <summary>
        /// 技能组名称
        /// </summary>
        [XmlElement("skill_group_name")]
        public string SkillGroupName { get; set; }
    }
}
