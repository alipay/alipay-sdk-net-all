using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdTestModifyResponse.
    /// </summary>
    public class AlipayBossProdTestModifyResponse : AopResponse
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("out_boolean")]
        public string OutBoolean { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("out_date")]
        public string OutDate { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("out_number")]
        public long OutNumber { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("out_price")]
        public string OutPrice { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("out_string")]
        public string OutString { get; set; }
    }
}
