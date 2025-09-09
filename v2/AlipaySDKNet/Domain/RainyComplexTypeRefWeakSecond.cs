using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyComplexTypeRefWeakSecond Data Structure.
    /// </summary>
    [Serializable]
    public class RainyComplexTypeRefWeakSecond : AopObject
    {
        /// <summary>
        /// boolean
        /// </summary>
        [XmlElement("test_a")]
        public bool TestA { get; set; }

        /// <summary>
        /// String
        /// </summary>
        [XmlElement("test_b")]
        public string TestB { get; set; }
    }
}
