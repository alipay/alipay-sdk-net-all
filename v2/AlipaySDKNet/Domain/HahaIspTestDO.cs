using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HahaIspTestDO Data Structure.
    /// </summary>
    [Serializable]
    public class HahaIspTestDO : AopObject
    {
        /// <summary>
        /// 32
        /// </summary>
        [XmlElement("one")]
        public string One { get; set; }

        /// <summary>
        /// 32
        /// </summary>
        [XmlElement("two")]
        public string Two { get; set; }
    }
}
