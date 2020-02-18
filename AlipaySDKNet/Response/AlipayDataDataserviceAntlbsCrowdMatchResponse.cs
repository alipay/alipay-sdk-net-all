using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntlbsCrowdMatchResponse.
    /// </summary>
    public class AlipayDataDataserviceAntlbsCrowdMatchResponse : AopResponse
    {
        /// <summary>
        /// 匹配结果，入参中每个客群码都会返回是否匹配，即使该客群不存在
        /// </summary>
        [XmlArray("match_result")]
        [XmlArrayItem("promox_crowd_match_model")]
        public List<PromoxCrowdMatchModel> MatchResult { get; set; }
    }
}
