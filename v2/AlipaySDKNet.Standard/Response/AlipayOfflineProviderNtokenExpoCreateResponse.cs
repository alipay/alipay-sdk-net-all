using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNtokenExpoCreateResponse.
    /// </summary>
    public class AlipayOfflineProviderNtokenExpoCreateResponse : AopResponse
    {
        /// <summary>
        /// 收藏token
        /// </summary>
        [XmlElement("ntoken")]
        public string Ntoken { get; set; }
    }
}
