using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpVerdictPartiesInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpVerdictPartiesInfo : AopObject
    {
        /// <summary>
        /// 案件判决结果
        /// </summary>
        [XmlElement("judgment_result")]
        public string JudgmentResult { get; set; }

        /// <summary>
        /// 当事人是公司，公司的法定代表人
        /// </summary>
        [XmlArray("legal_representative")]
        [XmlArrayItem("string")]
        public List<string> LegalRepresentative { get; set; }

        /// <summary>
        /// 当事人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 案件中的其他角色
        /// </summary>
        [XmlArray("other_roles")]
        [XmlArrayItem("string")]
        public List<string> OtherRoles { get; set; }

        /// <summary>
        /// 当事人在案件中的角色
        /// </summary>
        [XmlArray("roles")]
        [XmlArrayItem("string")]
        public List<string> Roles { get; set; }

        /// <summary>
        /// 当事人的类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
