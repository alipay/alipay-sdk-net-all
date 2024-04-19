using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityYyuDvsdvdsBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityYyuDvsdvdsBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// asd
        /// </summary>
        [XmlElement("asd")]
        public PageTemplateParamInfoDTO Asd { get; set; }

        /// <summary>
        /// sadasdas
        /// </summary>
        [XmlElement("asdasda")]
        public bool Asdasda { get; set; }

        /// <summary>
        /// sadf
        /// </summary>
        [XmlElement("asdf")]
        public string Asdf { get; set; }

        /// <summary>
        /// sdfasdf
        /// </summary>
        [XmlElement("sadf")]
        public bool Sadf { get; set; }
    }
}
