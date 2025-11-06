using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMemberTokenInvalidResponse.
    /// </summary>
    public class AlipayCommerceMedicalMemberTokenInvalidResponse : AopResponse
    {
        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
