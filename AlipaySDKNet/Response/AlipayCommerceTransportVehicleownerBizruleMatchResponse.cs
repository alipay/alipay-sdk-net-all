using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerBizruleMatchResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerBizruleMatchResponse : AopResponse
    {
        /// <summary>
        /// 匹配详情
        /// </summary>
        [XmlElement("match_result")]
        public string MatchResult { get; set; }
    }
}
