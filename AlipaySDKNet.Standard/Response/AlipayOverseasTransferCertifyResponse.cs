using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTransferCertifyResponse.
    /// </summary>
    public class AlipayOverseasTransferCertifyResponse : AopResponse
    {
        /// <summary>
        /// 透传信息
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
