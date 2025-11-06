using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FamilyHistory Data Structure.
    /// </summary>
    [Serializable]
    public class FamilyHistory : AopObject
    {
        /// <summary>
        /// 疾病名称
        /// </summary>
        [XmlElement("disease_name")]
        public string DiseaseName { get; set; }

        /// <summary>
        /// 患者与本人关系（本人、配偶、子女）
        /// </summary>
        [XmlElement("family_relationship")]
        public string FamilyRelationship { get; set; }
    }
}
