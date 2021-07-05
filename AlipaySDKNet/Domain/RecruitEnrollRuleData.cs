using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitEnrollRuleData Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitEnrollRuleData : AopObject
    {
        /// <summary>
        /// 素材的要求，json字符串，使用时需要把此字符串解析成json对象
        /// </summary>
        [XmlElement("schema")]
        public string Schema { get; set; }
    }
}
