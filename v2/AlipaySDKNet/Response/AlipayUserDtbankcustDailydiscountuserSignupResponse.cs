using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankcustDailydiscountuserSignupResponse.
    /// </summary>
    public class AlipayUserDtbankcustDailydiscountuserSignupResponse : AopResponse
    {
        /// <summary>
        /// 天天减报名结果
        /// </summary>
        [XmlElement("register_status")]
        public bool RegisterStatus { get; set; }
    }
}
