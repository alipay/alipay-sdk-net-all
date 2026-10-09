using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceGroupquerybygroupidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceGroupquerybygroupidQueryModel : AopObject
    {
        /// <summary>
        /// 技能组id
        /// </summary>
        [XmlElement("skill_group_id")]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
