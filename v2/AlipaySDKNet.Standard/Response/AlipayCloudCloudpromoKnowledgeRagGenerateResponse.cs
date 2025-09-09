using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoKnowledgeRagGenerateResponse.
    /// </summary>
    public class AlipayCloudCloudpromoKnowledgeRagGenerateResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("hit_segment_detail")]
        public List<HitSegmentDetail> Hits { get; set; }
    }
}
