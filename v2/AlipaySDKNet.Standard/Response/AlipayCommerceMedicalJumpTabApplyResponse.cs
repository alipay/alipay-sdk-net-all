using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalJumpTabApplyResponse.
    /// </summary>
    public class AlipayCommerceMedicalJumpTabApplyResponse : AopResponse
    {
        /// <summary>
        /// tab4建联的链接
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }
    }
}
