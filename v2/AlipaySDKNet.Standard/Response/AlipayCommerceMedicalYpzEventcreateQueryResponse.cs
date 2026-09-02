using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalYpzEventcreateQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalYpzEventcreateQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("ypz_sdk_event_detail_d_t_o")]
        public List<YpzSdkEventDetailDTO> Data { get; set; }
    }
}
