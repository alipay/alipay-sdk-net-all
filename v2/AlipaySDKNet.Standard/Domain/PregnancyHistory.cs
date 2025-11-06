using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PregnancyHistory Data Structure.
    /// </summary>
    [Serializable]
    public class PregnancyHistory : AopObject
    {
        /// <summary>
        /// 末次月经时间
        /// </summary>
        [XmlElement("last_menstruation")]
        public string LastMenstruation { get; set; }

        /// <summary>
        /// 怀孕状态（孕期）
        /// </summary>
        [XmlElement("pregnancy_status")]
        public string PregnancyStatus { get; set; }
    }
}
