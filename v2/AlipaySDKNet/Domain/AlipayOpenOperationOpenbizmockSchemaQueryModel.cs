using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockSchemaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockSchemaQueryModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("c")]
        public string C { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("complex_a")]
        public TestDemo ComplexA { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("fuza")]
        public TestDemoWzw Fuza { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// {"test":"test"}
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("uid_a")]
        public string UidA { get; set; }
    }
}
