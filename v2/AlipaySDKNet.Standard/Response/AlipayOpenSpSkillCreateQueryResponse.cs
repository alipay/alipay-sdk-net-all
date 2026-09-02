using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpSkillCreateQueryResponse.
    /// </summary>
    public class AlipayOpenSpSkillCreateQueryResponse : AopResponse
    {
        /// <summary>
        /// SKILL能力编码code
        /// </summary>
        [XmlElement("ability_code")]
        public string AbilityCode { get; set; }

        /// <summary>
        /// SKILL中文名称
        /// </summary>
        [XmlElement("skill_chinese_name")]
        public string SkillChineseName { get; set; }

        /// <summary>
        /// SKILL英文名称
        /// </summary>
        [XmlElement("skill_english_name")]
        public string SkillEnglishName { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
