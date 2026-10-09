using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankcustDailydiscountuserCheckResponse.
    /// </summary>
    public class AlipayUserDtbankcustDailydiscountuserCheckResponse : AopResponse
    {
        /// <summary>
        /// 检查用户是否可以报名天天减结果
        /// </summary>
        [XmlElement("pre_registration_status")]
        public bool PreRegistrationStatus { get; set; }
    }
}
