using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserInfoVerifyResponse.
    /// </summary>
    public class AlipayUserInfoVerifyResponse : AopResponse
    {
        /// <summary>
        /// MATCH, 信息匹配  NOT_MATCH, 信息不匹配  UNKNOWN, 未知（未认证的用户在校验姓名是否匹配时返回该结果）
        /// </summary>
        [XmlElement("match_result")]
        public string MatchResult { get; set; }
    }
}
