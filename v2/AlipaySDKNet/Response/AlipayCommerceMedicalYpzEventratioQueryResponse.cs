using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalYpzEventratioQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalYpzEventratioQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("ypz_sdk_event_ratio_d_t_o")]
        public List<YpzSdkEventRatioDTO> Data { get; set; }
    }
}
