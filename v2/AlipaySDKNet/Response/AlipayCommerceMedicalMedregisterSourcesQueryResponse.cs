using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedregisterSourcesQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedregisterSourcesQueryResponse : AopResponse
    {
        /// <summary>
        /// 号源列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("source_v_o")]
        public List<SourceVO> Data { get; set; }
    }
}
