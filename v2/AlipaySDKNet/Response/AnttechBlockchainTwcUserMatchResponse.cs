using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainTwcUserMatchResponse.
    /// </summary>
    public class AnttechBlockchainTwcUserMatchResponse : AopResponse
    {
        /// <summary>
        /// 不匹配
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 是否匹配
        /// </summary>
        [XmlElement("match_success")]
        public bool MatchSuccess { get; set; }
    }
}
