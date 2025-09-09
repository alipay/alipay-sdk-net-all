using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNtokenExpoModifyResponse.
    /// </summary>
    public class AlipayOfflineProviderNtokenExpoModifyResponse : AopResponse
    {
        /// <summary>
        /// 收藏token
        /// </summary>
        [XmlElement("ntoken")]
        public string Ntoken { get; set; }
    }
}
