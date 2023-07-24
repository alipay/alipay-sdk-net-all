using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdTestAproveModifyResponse.
    /// </summary>
    public class AlipayBossProdTestAproveModifyResponse : AopResponse
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("out_string")]
        public string OutString { get; set; }
    }
}
