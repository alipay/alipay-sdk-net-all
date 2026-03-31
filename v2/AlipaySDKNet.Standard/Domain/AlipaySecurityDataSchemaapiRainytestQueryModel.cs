using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataSchemaapiRainytestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataSchemaapiRainytestQueryModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("demo_body")]
        public string DemoBody { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("demo_path")]
        public string DemoPath { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("demo_query")]
        [XmlArrayItem("string")]
        public List<string> DemoQuery { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test")]
        public UserInfoDemo Test { get; set; }
    }
}
