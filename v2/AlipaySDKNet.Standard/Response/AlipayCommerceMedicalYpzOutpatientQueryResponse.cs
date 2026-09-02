using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalYpzOutpatientQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalYpzOutpatientQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("ypz_sdk_event_problem_d_t_o")]
        public List<YpzSdkEventProblemDTO> Data { get; set; }
    }
}
