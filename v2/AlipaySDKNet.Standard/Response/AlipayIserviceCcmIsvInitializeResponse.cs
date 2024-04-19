using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmIsvInitializeResponse.
    /// </summary>
    public class AlipayIserviceCcmIsvInitializeResponse : AopResponse
    {
        /// <summary>
        /// Base64编码CCM公钥：CCM公私钥对由CCM自动生成，用于Iframe spi接口安全认证
        /// </summary>
        [XmlElement("ccm_pub_key")]
        public string CcmPubKey { get; set; }
    }
}
