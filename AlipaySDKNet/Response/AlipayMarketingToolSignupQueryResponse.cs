using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolSignupQueryResponse.
    /// </summary>
    public class AlipayMarketingToolSignupQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动ID。
        /// </summary>
        [XmlElement("play_id")]
        public string PlayId { get; set; }

        /// <summary>
        /// 是否已经报名。
        /// </summary>
        [XmlElement("sign_up")]
        public bool SignUp { get; set; }
    }
}
