using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryBotVerifyCheckResponse.
    /// </summary>
    public class AlipayEbppIndustryBotVerifyCheckResponse : AopResponse
    {
        /// <summary>
        /// 用于表示用户在当前场景中核身状态
        /// </summary>
        [XmlElement("verify_status")]
        public string VerifyStatus { get; set; }
    }
}
