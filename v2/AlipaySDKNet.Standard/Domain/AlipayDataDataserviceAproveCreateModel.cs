using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAproveCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAproveCreateModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_body")]
        public string TestBody { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_path")]
        public string TestPath { get; set; }
    }
}
