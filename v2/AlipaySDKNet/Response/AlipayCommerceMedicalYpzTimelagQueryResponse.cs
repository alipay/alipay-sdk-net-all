using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalYpzTimelagQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalYpzTimelagQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("ypz_sdk_time_lag_d_t_o_one")]
        public List<YpzSdkTimeLagDTOOne> Data { get; set; }
    }
}
