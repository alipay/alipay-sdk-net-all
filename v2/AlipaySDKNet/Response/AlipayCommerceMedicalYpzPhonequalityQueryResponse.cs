using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalYpzPhonequalityQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalYpzPhonequalityQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("ypz_sdk_phone_quality_stat_d_t_o_one")]
        public List<YpzSdkPhoneQualityStatDTOOne> Data { get; set; }
    }
}
