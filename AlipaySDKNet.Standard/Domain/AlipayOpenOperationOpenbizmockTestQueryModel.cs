using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockTestQueryModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("fuza")]
        public TestDemoWzw Fuza { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("out_open_id")]
        public string OutOpenId { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("u_test")]
        public string UTest { get; set; }
    }
}
