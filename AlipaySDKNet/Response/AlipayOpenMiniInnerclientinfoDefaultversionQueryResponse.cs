using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerclientinfoDefaultversionQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerclientinfoDefaultversionQueryResponse : AopResponse
    {
        /// <summary>
        /// Android客户端版本信息
        /// </summary>
        [XmlElement("android_client_version_info")]
        public MiniAppClientVersionInfo AndroidClientVersionInfo { get; set; }

        /// <summary>
        /// iOS客户单版本号信息
        /// </summary>
        [XmlElement("ios_client_version_info")]
        public MiniAppClientVersionInfo IosClientVersionInfo { get; set; }
    }
}
