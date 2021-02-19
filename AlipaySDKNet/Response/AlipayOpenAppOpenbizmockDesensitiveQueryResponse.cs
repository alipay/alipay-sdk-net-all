using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppOpenbizmockDesensitiveQueryResponse.
    /// </summary>
    public class AlipayOpenAppOpenbizmockDesensitiveQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_field_converter")]
        public string TestFieldConverter { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("test_fields_converter")]
        [XmlArrayItem("string")]
        public List<string> TestFieldsConverter { get; set; }
    }
}
