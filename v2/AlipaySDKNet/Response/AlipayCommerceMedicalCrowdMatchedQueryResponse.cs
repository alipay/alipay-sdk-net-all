using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCrowdMatchedQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCrowdMatchedQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否匹配人群包
        /// </summary>
        [XmlElement("matched_res")]
        public bool MatchedRes { get; set; }
    }
}
