using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFChronicDisease Data Structure.
    /// </summary>
    [Serializable]
    public class HDFChronicDisease : AopObject
    {
        /// <summary>
        /// 慢性病描述
        /// </summary>
        [XmlElement("chronic_desc")]
        public string ChronicDesc { get; set; }

        /// <summary>
        /// 患病时长
        /// </summary>
        [XmlElement("have_time")]
        public string HaveTime { get; set; }

        /// <summary>
        /// 治疗
        /// </summary>
        [XmlElement("treatment")]
        public string Treatment { get; set; }

        /// <summary>
        /// 疾病
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
