using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalMedmsgArg Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalMedmsgArg : AopObject
    {
        /// <summary>
        /// 模版字段key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 模版字段value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
