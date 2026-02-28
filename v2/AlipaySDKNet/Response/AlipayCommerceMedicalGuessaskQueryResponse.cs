using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalGuessaskQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalGuessaskQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("diseases")]
        [XmlArrayItem("string")]
        public List<string> Diseases { get; set; }
    }
}
