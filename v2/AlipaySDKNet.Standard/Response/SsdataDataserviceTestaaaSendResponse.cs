using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// SsdataDataserviceTestaaaSendResponse.
    /// </summary>
    public class SsdataDataserviceTestaaaSendResponse : AopResponse
    {
        /// <summary>
        /// desc
        /// </summary>
        [XmlElement("return_a")]
        public DumTestFFAA ReturnA { get; set; }
    }
}
