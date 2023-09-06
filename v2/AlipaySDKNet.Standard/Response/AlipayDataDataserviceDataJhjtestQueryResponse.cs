using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceDataJhjtestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceDataJhjtestQueryResponse : AopResponse
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_out_other")]
        public string TestOutOther { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_out_string")]
        public string TestOutString { get; set; }

        /// <summary>
        /// tse
        /// </summary>
        [XmlElement("test_out_string_yincang")]
        public string TestOutStringYincang { get; set; }
    }
}
