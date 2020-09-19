using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolSignupSubmitResponse.
    /// </summary>
    public class AlipayMarketingToolSignupSubmitResponse : AopResponse
    {
        /// <summary>
        /// 玩法ID。
        /// </summary>
        [XmlElement("play_id")]
        public string PlayId { get; set; }
    }
}
