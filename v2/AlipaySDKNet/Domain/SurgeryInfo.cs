using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SurgeryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SurgeryInfo : AopObject
    {
        /// <summary>
        /// 麻醉方式
        /// </summary>
        [XmlElement("surgery_anesthesia")]
        public string SurgeryAnesthesia { get; set; }

        /// <summary>
        /// 手术日期
        /// </summary>
        [XmlElement("surgery_date")]
        public string SurgeryDate { get; set; }

        /// <summary>
        /// 手术过程描述
        /// </summary>
        [XmlElement("surgery_desc")]
        public string SurgeryDesc { get; set; }

        /// <summary>
        /// 手术医师
        /// </summary>
        [XmlElement("surgery_doctor")]
        public string SurgeryDoctor { get; set; }

        /// <summary>
        /// 手术名称
        /// </summary>
        [XmlElement("surgery_name")]
        public string SurgeryName { get; set; }
    }
}
