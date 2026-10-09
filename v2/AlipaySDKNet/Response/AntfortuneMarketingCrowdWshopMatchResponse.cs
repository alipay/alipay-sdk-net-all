using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneMarketingCrowdWshopMatchResponse.
    /// </summary>
    public class AntfortuneMarketingCrowdWshopMatchResponse : AopResponse
    {
        /// <summary>
        /// 用户是否匹配人群，枚举值：true/false
        /// </summary>
        [XmlElement("match_result")]
        public bool MatchResult { get; set; }
    }
}
