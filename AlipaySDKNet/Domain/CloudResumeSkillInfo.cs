using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloudResumeSkillInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CloudResumeSkillInfo : AopObject
    {
        /// <summary>
        /// 技能标签名字
        /// </summary>
        [XmlElement("skill_name")]
        public string SkillName { get; set; }
    }
}
