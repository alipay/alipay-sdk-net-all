using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneEquityShopCustrelationQueryResponse.
    /// </summary>
    public class AntfortuneEquityShopCustrelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户关注商户pid对应的财富号的时间
        /// </summary>
        [XmlElement("follow_time")]
        public string FollowTime { get; set; }

        /// <summary>
        /// 当前用户是否关注商户pid对应的财富号
        /// </summary>
        [XmlElement("match_result")]
        public bool MatchResult { get; set; }
    }
}
