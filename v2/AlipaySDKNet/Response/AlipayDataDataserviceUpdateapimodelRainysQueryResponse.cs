using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceUpdateapimodelRainysQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceUpdateapimodelRainysQueryResponse : AopResponse
    {
        /// <summary>
        /// boolean
        /// </summary>
        [XmlArray("out_array_tc_1")]
        [XmlArrayItem("boolean")]
        public List<bool> OutArrayTc1 { get; set; }
    }
}
