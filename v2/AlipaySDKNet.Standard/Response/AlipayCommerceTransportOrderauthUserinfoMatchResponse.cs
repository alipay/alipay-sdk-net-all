using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportOrderauthUserinfoMatchResponse.
    /// </summary>
    public class AlipayCommerceTransportOrderauthUserinfoMatchResponse : AopResponse
    {
        /// <summary>
        /// 支付宝唯一用户开放ID
        /// </summary>
        [XmlElement("matched_open_id")]
        public string MatchedOpenId { get; set; }

        /// <summary>
        /// 支付宝唯一用户开放ID
        /// </summary>
        [XmlElement("matched_user_id")]
        public string MatchedUserId { get; set; }

        /// <summary>
        /// 匹配得到的支付宝账号风险级别。N1：未匹配到用户；L序列为低风险，M序列为中风险，H序列为高风险；
        /// </summary>
        [XmlElement("matched_user_risk_level")]
        public string MatchedUserRiskLevel { get; set; }

        /// <summary>
        /// 匹配得到的支付宝账号风险原因
        /// </summary>
        [XmlElement("matched_user_risk_reason")]
        public string MatchedUserRiskReason { get; set; }
    }
}
