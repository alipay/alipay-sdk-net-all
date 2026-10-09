using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PatientInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PatientInfoDTO : AopObject
    {
        /// <summary>
        /// 年纪
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 患者ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
