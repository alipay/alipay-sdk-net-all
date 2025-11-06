using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SurgicalHistory Data Structure.
    /// </summary>
    [Serializable]
    public class SurgicalHistory : AopObject
    {
        /// <summary>
        /// 手术日期
        /// </summary>
        [XmlElement("surgery_date")]
        public string SurgeryDate { get; set; }

        /// <summary>
        /// 手术名称
        /// </summary>
        [XmlElement("surgery_name")]
        public string SurgeryName { get; set; }
    }
}
