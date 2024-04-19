using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAigcDiyitemConsultResponse.
    /// </summary>
    public class AlipayUserAigcDiyitemConsultResponse : AopResponse
    {
        /// <summary>
        /// 咨询是否通过
        /// </summary>
        [XmlElement("pass")]
        public bool Pass { get; set; }

        /// <summary>
        /// 咨询未通过原因
        /// </summary>
        [XmlElement("unpass_reason")]
        public string UnpassReason { get; set; }
    }
}
