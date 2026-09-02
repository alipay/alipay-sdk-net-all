using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpSkillDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpSkillDetailQueryModel : AopObject
    {
        /// <summary>
        /// SKILL能力编码code
        /// </summary>
        [XmlElement("ability_code")]
        public string AbilityCode { get; set; }
    }
}
