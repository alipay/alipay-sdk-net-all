using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PreConsultMap Data Structure.
    /// </summary>
    [Serializable]
    public class PreConsultMap : AopObject
    {
        /// <summary>
        /// v1等级下的花呗金返回比例
        /// </summary>
        [XmlElement("v_1")]
        public string V1 { get; set; }

        /// <summary>
        /// v2等级下的花呗金返回比例
        /// </summary>
        [XmlElement("v_2")]
        public string V2 { get; set; }

        /// <summary>
        /// v3等级下的花呗金返回比例
        /// </summary>
        [XmlElement("v_3")]
        public string V3 { get; set; }

        /// <summary>
        /// v4等级下的花呗金返回比例
        /// </summary>
        [XmlElement("v_4")]
        public string V4 { get; set; }
    }
}
