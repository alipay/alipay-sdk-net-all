using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpSkillInfoModifyResponse.
    /// </summary>
    public class AlipayOpenSpSkillInfoModifyResponse : AopResponse
    {
        /// <summary>
        /// SKILL能力编码code
        /// </summary>
        [XmlElement("ability_code")]
        public string AbilityCode { get; set; }

        /// <summary>
        /// SKILL能力版本
        /// </summary>
        [XmlElement("ability_version")]
        public string AbilityVersion { get; set; }
    }
}
