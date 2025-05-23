using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMiorinsuranceJumpurlQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMiorinsuranceJumpurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }
    }
}
